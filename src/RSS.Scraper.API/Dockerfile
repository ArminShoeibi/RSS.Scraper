FROM mcr.microsoft.com/dotnet/sdk:6.0.401-bullseye-slim-amd64 AS sdk
WORKDIR /rss
COPY ["src/RSS.Scraper.API/RSS.Scraper.API.csproj", "src/RSS.Scraper.API/"]
RUN dotnet restore "src/RSS.Scraper.API/RSS.Scraper.API.csproj"
COPY . .
RUN dotnet publish "src/RSS.Scraper.API/RSS.Scraper.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:6.0.9-bullseye-slim-amd64
ENV TZ=Asia/Tehran
ENV ASPNETCORE_ENVIRONMENT=Production
WORKDIR /app
EXPOSE 80
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RSS.Scraper.API.dll"]