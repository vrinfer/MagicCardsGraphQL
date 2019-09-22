FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MagicCardsGraphQL/MagicCardsGraphQL.csproj", "MagicCardsGraphQL/"]
RUN dotnet restore "MagicCardsGraphQL/MagicCardsGraphQL.csproj"
COPY . .
WORKDIR "/src/MagicCardsGraphQL"
RUN dotnet build "MagicCardsGraphQL.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MagicCardsGraphQL.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MagicCardsGraphQL.dll"]