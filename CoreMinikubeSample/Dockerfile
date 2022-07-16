#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /webapp
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CoreMinikubeSample/CoreMinikubeSample.csproj", "CoreMinikubeSample/"]
RUN dotnet restore "CoreMinikubeSample/CoreMinikubeSample.csproj"
COPY . .
WORKDIR "/src/CoreMinikubeSample"
RUN dotnet build "CoreMinikubeSample.csproj" -c Release -o /webapp/build

FROM build AS publish
RUN dotnet publish "CoreMinikubeSample.csproj" -c Release -o /webapp/publish

FROM base AS final
WORKDIR /webapp
COPY --from=publish /webapp/publish .
ENTRYPOINT ["dotnet", "CoreMinikubeSample.dll"]