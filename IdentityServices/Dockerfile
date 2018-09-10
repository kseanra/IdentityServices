FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 56155
EXPOSE 44316

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY IdentityServices/IdentityServices.csproj IdentityServices/
RUN dotnet restore IdentityServices/IdentityServices.csproj
COPY . .
WORKDIR /src/IdentityServices
RUN dotnet build IdentityServices.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish IdentityServices.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "IdentityServices.dll"]
