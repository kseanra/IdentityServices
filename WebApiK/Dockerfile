FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 58105
EXPOSE 44349

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY WebApiK/WebApiK.csproj WebApiK/
RUN dotnet restore WebApiK/WebApiK.csproj
COPY . .
WORKDIR /src/WebApiK
RUN dotnet build WebApiK.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish WebApiK.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApiK.dll"]
