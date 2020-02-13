FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["abcBadgeGenAPI_Kubernetes/abcBadgeGenAPI_Kubernetes.csproj", "abcBadgeGenAPI_Kubernetes/"]

RUN dotnet restore "abcBadgeGenAPI_Kubernetes/abcBadgeGenAPI_Kubernetes.csproj"
COPY . .
WORKDIR "/src/abcBadgeGenAPI_Kubernetes"
RUN dotnet build "abcBadgeGenAPI_Kubernetes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "abcBadgeGenAPI_Kubernetes.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "abcBadgeGenAPI_Kubernetes.dll"]