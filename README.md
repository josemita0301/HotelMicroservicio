# API REST - Gestión de Habitaciones

## Requisitos Previos

Antes de ejecutar la API, asegúrate de cumplir con los siguientes requisitos:

1. **.NET 8 SDK**: Asegúrate de tener instalado .NET 8 en tu computadora. Puedes descargarlo desde [aquí](https://dotnet.microsoft.com/download/dotnet/8.0).
2. **Base de Datos**: Se requiere que ejecutes el script SQL para crear la tabla `Room` antes de ejecutar la API.
3. **Cadena de Conexión**: Actualiza la cadena de conexión en el archivo de configuración appsettings.json para que apunte a tu base de datos local.

## Configuración de la Base de Datos

Ejecuta el script SQL incluido en este repositorio para configurar la base de datos. Este script crea la tabla `Room` necesaria para que la API funcione correctamente.

1. Abre tu herramienta de gestión de bases de datos (como SQL Server Management Studio).
2. Carga y ejecuta el archivo SQL proporcionado (`create_room_table.sql`).

### Script SQL

A continuación, un ejemplo del script SQL necesario:

```sql
CREATE TABLE Room (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Capacity INT NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    Status NVARCHAR(50) NOT NULL
);
