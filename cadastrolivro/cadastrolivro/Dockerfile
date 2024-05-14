#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["cadastrolivro/cadastrolivro.csproj", "cadastrolivro/"]
RUN dotnet restore "./cadastrolivro/cadastrolivro.csproj"
COPY . .
WORKDIR "/src/cadastrolivro"
RUN dotnet build "./cadastrolivro.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./cadastrolivro.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cadastrolivro.dll"]

#E se você quiser automatizar o processo de construção do seu código, publicá-lo e criar uma imagem Docker de produção? A boa notícia é que você pode usar imagens e contêineres para essas etapas criando algo chamado "Dockerfile de vários estágios". Este tipo de Dockerfile oferece os seguintes benefícios:

  #  Evita a criação manual de imagens intermediárias
  #  Reduz a complexidade
  #  Copia seletivamente artefatos de um estágio para outro
  #  Minimiza o tamanho final da imagem

#Stage 1: Define base image that will be used for production.
 #Sets up the image that will be used for production (aliased as "base").
 #FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
 #WORKDIR /app 
#
# ENV ASPNETCORE_ENVIROMENT=Development

# # Stage 2: Build and publish the code
# # Uses an sdk image (aliased as "build"), copies our project code into a working directory, 
# # restores NuGet packages, builds the code and publishes it to a directory named publish. 
#  FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#  ARG BUILD_CONFIGURATION=Release
#  WORKDIR /src
#  COPY ["cadastrolivro.csproj", "."]
#  RUN dotnet restore "./cadastrolivro.csproj"
#  COPY . .
#  WORKDIR "/src/."
#  RUN dotnet build "./cadastrolivro.csproj" -c $BUILD_CONFIGURATION -o /app/build

#  FROM build AS publish

#  ARG BUILD_CONFIGURATION=Release
#  RUN dotnet publish "./cadastrolivro.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# # # Stage 3 copies the publish directory 
# # # into the production image's working directory and defines the dotnet command to run once the container is running.
#  FROM base AS final 
#  EXPOSE 80
#  WORKDIR /app
#  COPY --from=publish /app/publish .
#  ENTRYPOINT ["dotnet", "cadastrolivro.dll"]


#----------------------------------------------------------------------------------------------------------------------------#
# FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
# WORKDIR /app
# EXPOSE 80

# COPY *.csproj ./
# RUN dotnet restore

# COPY . ./
# RUN dotnet publish -c Release -o out

# FROM mcr.microsoft.com/dotnet/aspnet:5.0
# WORKDIR /app
# COPY --from=build-env /app/out .
# ENTRYPOINT ["dotnet", "cadastrolivro.dll"]


#---------------------------------------------------------------------------------------------------------------------------#
#DOCKERFILE PARA DESENVOLVIMENTO EM MÁQUINA COM SDK JÁ INSTALADA
#Custom Dockerfile
##Imagem base que utiliza da sdk instalada no meu pc
# FROM mcr.microsoft.com/dotnet/sdk:5.0
# LABEL author="Guilherme"

# #Configuração para um ambiente do tipo desenvolvimento e, como a porta ouvida não será default, mudamos a url para a porta 5000
# ENV ASPNETCORE_URLS=http://+:5000
# ENV ASPNETCORE_ENVIRONMENT="development"

# #Expõe a porta 5000, isso porque: "By default, Docker runs on port 80 with ASP.NET Core"
# EXPOSE 5000
# WORKDIR /app
# COPY . .

# #Restaura os pacotes NuGet, por isso a flag '-c'
# CMD ["/bin/bash", "-c", "dotnet restore && dotnet run"]


#---------------------------------------------------------------------------------------------------------------------------#
#DOCKERFILE COPY PARA PUBLICAR UMA APLICAÇÃO DE PRODUÇÃO
#Rodar o seguinte comando: dotnet publish “-c” Release -o dist
# FROM mcr.microsoft.com/dotnet/core/aspnet
# LABEL author="Guilherme"

# ENV ASPNETCORE_URLS=http://*:5000
# ENV ASPNETCORE_ENVIRONMENT="production"

# EXPOSE 5000
# WORKDIR /app
# COPY . .
# ENTRYPOINT [ "executable" ] ["/bin/bash", "-c", "dotnet restore && dotnet run"]
# CMD ["dotnet", "cadastrolivro.csproj"]


#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#ENV ASPNETCORE_LOGGING__CONSOLE__DISABLECOLORS=true
#ENV ASPNETCORE_ENVIRONMENT=Development
#ENV DOTNET_USE_POLLING_FILE_WATCHER=1
#ENV NUGET_PACKAGES=/.nuget/fallbackpackages2
#ENV NUGET_FALLBACK_PACKAGES=/.nuget/fallbackpackages;/.nuget/fallbackpackages2
#ENV PATH=/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin
#ENV ASPNETCORE_URLS=http://+:80
#ENV DOTNET_RUNNING_IN_CONTAINER=true
#ENV DOTNET_VERSION=5.0.17
#ENV ASPNET_VERSION=5.0.17
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#COPY ["cadastrolivro.csproj", "."]
#RUN dotnet restore "./cadastrolivro.csproj"
#COPY . .
#WORKDIR "/src/."
#
#RUN dotnet build "./cadastrolivro.csproj" -c $BUILD_CONFIGURATION -o /app/build
#
#FROM build AS publish
#
#ARG BUILD_CONFIGURATION=Release
#RUN dotnet publish "./cadastrolivro.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "cadastrolivro.dll"]