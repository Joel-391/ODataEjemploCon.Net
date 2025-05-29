# Proyecto ODataEjemplo (.NET 8 + ASP.NET Core OData)

Este repositorio contiene dos ejemplos de servicios OData en ASP.NET Core 8:

- `ODataServiceSinDB`: Servicio OData en memoria (sin base de datos)
- `ODataServiceConDB`: Servicio OData conectado a PostgreSQL usando Entity Framework Core

## 🚀 Requisitos

- [.NET SDK 8.0.410](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- PostgreSQL (solo para `ODataServiceConDB`)
- Editor recomendado: Visual Studio Code o Visual Studio 2022+
#  🚀 Ver las Versiones

```bash
dotnet --list-sdks
```
8.0.410 [C:\Program Files\dotnet\sdk]

```bash
dotnet --list-runtimes
```
Microsoft.AspNetCore.App 8.0.16 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.NETCore.App 8.0.16 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.WindowsDesktop.App 8.0.16 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]

## 📂 Comando para restaurar y ejecutar el proyecto

```bash
cd ODataServiceSinDB
dotnet restore
dotnet run
```

```bash
cd ODataServiceConDB
dotnet restore
dotnet ef database update
dotnet run
```
