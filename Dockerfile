FROM mcr.microsoft.com/dotnet/aspnet:8.0-bookworm-slim AS base
RUN apt-get update -yq && apt-get install -yq libfontconfig1
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0-bookworm-slim AS build
RUN apt-get update -yq && \
    apt-get upgrade -yq \
    && apt-get install -yq curl git nano
RUN curl -fsSL https://deb.nodesource.com/setup_18.x | bash - && apt-get install -yq nodejs 
RUN npm install -g npm

WORKDIR /src

ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Ticketing.Web.csproj", "Ticketing/"]
RUN dotnet restore "./Ticketing/Ticketing.Web.csproj"

WORKDIR "/src/Ticketing"
COPY . .

RUN dotnet build "./Ticketing.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish "./Ticketing.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ticketing.Web.dll"]