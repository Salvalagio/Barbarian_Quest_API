#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Barbarian_Quest_API/Barbarian_Quest_API.csproj", "Barbarian_Quest_API/"]
RUN dotnet restore "Barbarian_Quest_API/Barbarian_Quest_API.csproj"
COPY . .
WORKDIR "/src/Barbarian_Quest_API"
RUN dotnet build "Barbarian_Quest_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Barbarian_Quest_API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Barbarian_Quest_API.dll"]