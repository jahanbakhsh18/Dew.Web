FROM mcr.microsoft.com/dotnet/aspnet:8.0-bookworm-slim AS base
RUN apt-get update -yq && apt-get install -yq libfontconfig1 \
        libkrb5-3 \
        libgssapi-krb5-2 \
    && rm -rf /var/lib/apt/lists/*
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0-bookworm-slim AS build
RUN apt-get update -yq && \
    apt-get upgrade -yq && \
    apt-get install -yq curl git nano
RUN curl -fsSL https://deb.nodesource.com/setup_18.x | bash - && apt-get install -yq nodejs 
RUN npm install -g npm

WORKDIR /src

ARG BUILD_CONFIGURATION=Release
# Remove next line for caching nuget
WORKDIR /src  
COPY ["Dew.Web.csproj", "Dew/"]
RUN dotnet restore "./Dew/Dew.Web.csproj" --verbosity diagnostic
# Restore with a PERSISTENT CACHE MOUNT. Only MISSING packages will be downloaded!
#RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
#    dotnet restore "./Dew/Dew.Web.csproj" --verbosity diagnostic

WORKDIR "/src/Dew"
COPY . .

RUN dotnet build "./Dew.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build --verbosity diagnostic
# Build using the same cache mount and --no-restore
#RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
#    dotnet build "./Dew.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build --no-restore

FROM build AS publish
RUN dotnet publish "./Dew.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false --verbosity diagnostic
# Publish using the same cache mount and --no-restore
#RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
#    dotnet publish "./Dew.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false --no-restore

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dew.Web.dll"]