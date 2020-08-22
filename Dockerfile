#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#auto generated file by VisualStudio

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/PL.API/PL.API.csproj", "src/PL.API/"]
RUN dotnet restore "src/PL.API/PL.API.csproj"
COPY . .
WORKDIR "/src/src/PL.API"
RUN dotnet build "PL.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PL.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PL.API.dll"]