#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:2.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:2.1 AS build
WORKDIR /src
COPY ["Gmud.API/Gmud.API.csproj", "Gmud.API/"]
RUN dotnet restore "Gmud.API/Gmud.API.csproj"
COPY . .
WORKDIR "/src/Gmud.API"
RUN dotnet build "Gmud.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gmud.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gmud.API.dll"]