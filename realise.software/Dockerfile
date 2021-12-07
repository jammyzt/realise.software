#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY [".", "realise.software/"]
RUN dotnet restore "realise.software/realise.software.csproj"
COPY . .
WORKDIR "/src/realise.software"
RUN dotnet build "realise.software.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "realise.software.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "realise.software.dll"]

# Use Entrypoint above for local testing
# Use the following instead for Heroku
CMD ASPNETCORE_URLS=http://*:$PORT dotnet "realise.software.dll"