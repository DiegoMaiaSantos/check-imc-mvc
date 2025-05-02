# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia os arquivos da pasta atual para dentro do container
COPY . ./

# Restaura apenas o projeto principal
RUN dotnet restore ./Check_IMC.csproj

# Publica apenas o projeto principal
RUN dotnet publish ./Check_IMC.csproj -c Release -o /app/publish

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copia a saída da publicação da imagem de build
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "Check_IMC.dll"]
