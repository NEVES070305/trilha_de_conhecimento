#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["./WebApplication.csproj", "./WebApplication.csproj"]
RUN dotnet restore "./WebApplication.csproj"
COPY . .
RUN dotnet build "./WebApplication.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WebApplication.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication.dll"]

##Adequado para desenvolvimento local
#FROM mcr.microsoft.com/dotnet/sdk:5.0
#LABEL author="Guilherme"
#EXPOSE 80
##Configura��o para um ambiente do tipo desenvolvimento 
##No contexto de uma aplica��o .NET Core, 
##a vari�vel de ambiente ASPNETCORE_ENVIRONMENT � 
##frequentemente utilizada para configurar o ambiente de execu��o da aplica��o. 
##Por exemplo, a aplica��o .NET Core pode ler essa vari�vel para determinar se est� executando em um ambiente de desenvolvimento, 
##teste ou produ��o, e ajustar sua configura��o de acordo.
#
#ENV ASPNETCORE_ENVIRONMENT="development"
#
#WORKDIR /app
#COPY . .
#
##Restaura os pacotes NuGet, por isso a flag '-c'
##Isso s� � executado no momento de run
#CMD ["/bin/bash", "-c", "dotnet restore && dotnet run"]   

#
##See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#WORKDIR /app
#
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#COPY ["WebApplicationBasic.csproj", "."]
#RUN dotnet restore "./WebApplicationBasic.csproj"
#COPY . .
#WORKDIR "/src/."
#RUN dotnet build "./WebApplicationBasic.csproj" -c $BUILD_CONFIGURATION -o /app/build
#
#FROM build AS publish
#ARG BUILD_CONFIGURATION=Release
#
#RUN dotnet publish "./WebApplicationBasic.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "WebApplicationBasic.dll"]

##  Com dois stages
#Build stage
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
#WORKDIR /app
#COPY *.csproj ./
#RUN dotnet restore
#COPY . ./
#RUN dotnet publish -c Release -o out
#
##Run stage
#FROM mcr.microsoft.com/dotnet/aspnet:5.0
#WORKDIR /app
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "WebApplicationBasic.dll"]
#