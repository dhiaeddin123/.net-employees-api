# 1. Base image with .NET Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0.14 AS base
WORKDIR /app

# 2. SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0.408 AS build
WORKDIR /src

# 3. Copy the project files
COPY *.csproj ./
RUN dotnet restore

# 4. Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# 5. Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

# 6. Start the app
ENTRYPOINT ["dotnet", "blockchain-api.dll"]
