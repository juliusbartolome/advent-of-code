﻿FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AdventOfCode.DayOneTribuchet/AdventOfCode.DayOneTribuchet.csproj", "AdventOfCode.DayOneTribuchet/"]
RUN dotnet restore "AdventOfCode.DayOneTribuchet/AdventOfCode.DayOneTribuchet.csproj"
COPY . .
WORKDIR "/src/AdventOfCode.DayOneTribuchet"
RUN dotnet build "AdventOfCode.DayOneTribuchet.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "AdventOfCode.DayOneTribuchet.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdventOfCode.DayOneTribuchet.dll"]
