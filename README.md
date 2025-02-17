SoftwareHotel

SoftwareHotel es una plataforma para la gestión de reservas en hoteles, desarrollada como una aplicación web en ASP.NET Core, donde el frontend y el backend están integrados en un solo proyecto. La aplicación permite a los administradores gestionar habitaciones y reservas, y a los clientes realizar reservas de manera sencilla.

Características

Gestión de Reservas: Creación, modificación y cancelación de reservas.

Galería de Imágenes: Visualización de imágenes de habitaciones y sitios de interés cercanos.

Autenticación Segura: Implementación de JWT para la seguridad de usuarios.

Integración con API Externas: Planeado para futuras conexiones con Booking y Airbnb.

Interfaz Responsiva: Desarrollado con Razor Pages y Bootstrap para una mejor experiencia de usuario.

Tecnologías Utilizadas

Aplicación Web (ASP.NET Core)

ASP.NET Core 8 como framework principal.

Entity Framework Core para la gestión de base de datos.

PostgreSQL como motor de base de datos.

Swagger para la documentación de la API.

Autenticación con JWT y ASP.NET Identity.

Razor Pages y Bootstrap para el desarrollo del frontend.

Base de Datos (PostgreSQL)

Migraciones con Entity Framework Core para facilitar la gestión de esquemas.

Despliegue

Aplicación Web: Contenerizada con Docker y desplegada en Azure o AWS.

Arquitectura

El sistema sigue una arquitectura en capas:

+----------------------+        +--------------------+        +--------------------+
| ASP.NET Core (UI)   | <----> | .NET API Backend  | <----> |  PostgreSQL DB     |
| (Razor Pages)       |        | (Business Logic)  |        | (Data Storage)     |
+----------------------+        +--------------------+        +--------------------+
       ⬆                        ⬆
       |                        |
       | REST API Calls         | Entity Framework Core
       |                        |
       ⬇                        ⬇
+-------------------+        +--------------------+
|    Auth (JWT)     |        |   Repositories    |
| (Login/Register)  |        |   Services        |
+-------------------+        +--------------------+

Instalación y Configuración

Requisitos Previos

Instalar .NET SDK 8+

Descarga desde: Microsoft .NET

Verifica la instalación con:

dotnet --version

Instalar PostgreSQL

Descarga desde: PostgreSQL

Verifica con:

psql --version

Configuración del Proyecto

Clonar el repositorio:

git clone https://github.com/tu-usuario/SoftwareHotel.git
cd SoftwareHotel

Crear el proyecto en ASP.NET Core:

dotnet new webapp -n SoftwareHotel
cd SoftwareHotel

Instalar dependencias:

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Npgsql
dotnet add package Swashbuckle.AspNetCore
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package Microsoft.AspNetCore.Identity
dotnet add package Microsoft.Extensions.Configuration

Configurar la conexión a PostgreSQL en appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=SoftwareHotelDB;Username=postgres;Password=tu_password"
}

Aplicar migraciones y ejecutar la aplicación:

dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run

Contribución

Si deseas contribuir, sigue estos pasos:

Haz un fork del repositorio.

Crea una nueva rama con tu función o corrección: git checkout -b feature-nueva.

Realiza tus cambios y haz un commit: git commit -m "Agrega nueva funcionalidad".

Sube los cambios: git push origin feature-nueva.

Abre un Pull Request en GitHub.
