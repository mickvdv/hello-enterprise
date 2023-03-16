ARG BUILD_IMAGE

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM $BUILD_IMAGE AS publish
RUN dotnet publish "HelloEnterprise.Frontend/Server/HelloEnterprise.Frontend.Server.csproj" -c Release -o /app/publish --no-build --no-restore --no-dependencies

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloEnterprise.Frontend.Server.dll"]