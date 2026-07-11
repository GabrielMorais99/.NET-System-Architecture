FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["Directory.Build.props", "."]
COPY ["src/TechChallenge.Domain/TechChallenge.Domain.csproj", "src/TechChallenge.Domain/"]
COPY ["src/TechChallenge.Application/TechChallenge.Application.csproj", "src/TechChallenge.Application/"]
COPY ["src/TechChallenge.Infrastructure/TechChallenge.Infrastructure.csproj", "src/TechChallenge.Infrastructure/"]
COPY ["src/TechChallenge.Api/TechChallenge.Api.csproj", "src/TechChallenge.Api/"]

RUN dotnet restore "src/TechChallenge.Api/TechChallenge.Api.csproj"

COPY . .
RUN dotnet publish "src/TechChallenge.Api/TechChallenge.Api.csproj" \
    --configuration Release \
    --output /app/publish \
    --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TechChallenge.Api.dll"]
