#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HelloEnterprise.BackgroundJob/HelloEnterprise.BackgroundJob.csproj", "HelloEnterprise.BackgroundJob/"]
RUN dotnet restore "HelloEnterprise.BackgroundJob/HelloEnterprise.BackgroundJob.csproj"
COPY . .
WORKDIR "/src/HelloEnterprise.BackgroundJob"
RUN dotnet build "HelloEnterprise.BackgroundJob.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HelloEnterprise.BackgroundJob.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloEnterprise.BackgroundJob.dll"]