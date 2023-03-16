ARG BUILD_IMAGE

FROM mcr.microsoft.com/dotnet/runtime:6.0-alpine AS base
WORKDIR /app

FROM $BUILD_IMAGE AS publish
RUN dotnet publish "HelloEnterprise.BackgroundJob/HelloEnterprise.BackgroundJob.csproj" -c Release -o /app/publish --no-build --no-restore --no-dependencies

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloEnterprise.BackgroundJob.dll"]