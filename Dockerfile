FROM mcr.microsoft.com/dotnet/aspnet:8.0-bookworm-slim AS base
RUN apt-get update -yq && apt-get install -yq libfontconfig1 libkrb5-3 libgssapi-krb5-2 \
    && rm -rf /var/lib/apt/lists/*
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0-bookworm-slim AS build
RUN apt-get update -yq && apt-get upgrade -yq && apt-get install -yq curl git nano
RUN curl -fsSL https://deb.nodesource.com/setup_24.x | bash - && apt-get install -yq nodejs 
RUN npm install -g npm@latest

# Set npm cache directory
ENV NPM_CONFIG_CACHE=/root/.npm

WORKDIR /src

ARG BUILD_CONFIGURATION=Release

# Copy project file first for better caching
COPY ["Dew.Web.csproj", "Dew/"]

# Restore with a PERSISTENT CACHE MOUNT. Only MISSING packages will be downloaded!
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages dotnet restore "./Dew/Dew.Web.csproj" --verbosity diagnostic

WORKDIR "/src/Dew"
COPY . .

# npm with caching - this will use the mounted volume. Skip cache clean in development to preserve cache
RUN --mount=type=cache,id=npm,target=/root/.npm npm install --legacy-peer-deps --no-fund --no-audit --allow-remote

# npm with global cache mount
#RUN --mount=type=cache,id=npm-global,target=/root/.npm --mount=type=cache,id=npm-cache,target=/root/.cache/npm \
#    npm cache clean --force || true && npm install --legacy-peer-deps --no-fund --no-audit --cache /root/.npm

# Build using the same cache mount and --no-restore
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet build "./Dew.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build --no-restore --verbosity diagnostic

FROM build AS publish
# Publish using the same cache mount and --no-restore
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet publish "./Dew.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false --no-restore  --verbosity diagnostic

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dew.Web.dll"]