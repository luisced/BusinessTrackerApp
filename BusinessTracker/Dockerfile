FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY . .
RUN dotnet restore "BusinessTracker.csproj"
RUN dotnet publish "BusinessTracker.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal 
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000
ENTRYPOINT ["dotnet", "BusinessTracker.dll"]