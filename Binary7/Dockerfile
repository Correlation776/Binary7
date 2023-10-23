FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Binary7/Binary7.csproj", "Binary7/"]
RUN dotnet restore "Binary7/Binary7.csproj"
COPY . .
WORKDIR "/src/Binary7"
RUN dotnet build "Binary7.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Binary7.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Binary7.dll"]
