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
WORKDIR /src
COPY ["Dew.Web.csproj", "Dew/"]
RUN dotnet restore "./Dew/Dew.Web.csproj" --verbosity diagnostic

WORKDIR "/src/Dew"
COPY . .

RUN dotnet build "./Dew.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish "./Dew.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dew.Web.dll"]