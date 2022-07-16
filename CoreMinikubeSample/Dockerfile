#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /webapp
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore 

FROM build AS publish
RUN dotnet publish  -c Release -o /webapp/publish

FROM base AS final
WORKDIR /webapp
COPY --from=publish /webapp/publish .
ENTRYPOINT ["dotnet", "CoreMinikubeSample.dll"]