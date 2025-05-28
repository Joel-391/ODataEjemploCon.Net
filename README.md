# Proyecto ODataEjemplo (.NET 8 + ASP.NET Core OData)

Este repositorio contiene dos ejemplos de servicios OData en ASP.NET Core 8:

- `ODataServiceSinDB`: Servicio OData en memoria (sin base de datos)
- `ODataServiceConDB`: Servicio OData conectado a PostgreSQL usando Entity Framework Core

## 🚀 Requisitos

- [.NET SDK 8.0.410](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- PostgreSQL (solo para `ODataServiceConDB`)
- Editor recomendado: Visual Studio Code o Visual Studio 2022+

## 📂 Comando para restaurar y ejecutar el proyecto

```bash
cd ODataServiceSinDB
dotnet restore              # Restaura paquetes NuGet
dotnet run                  # Ejecuta la API

cd ODataServiceConDB
dotnet restore              # Restaura paquetes NuGet
dotnet ef database update   # Restaura la base de datos
dotnet run                  # Ejecuta la API
