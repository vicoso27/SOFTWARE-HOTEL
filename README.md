SoftwareHotel

SoftwareHotel es una plataforma para la gestión de reservas en hoteles, diseñada con una arquitectura moderna utilizando .NET 8 para el backend y React con TypeScript para el frontend. La aplicación permite a los administradores gestionar habitaciones y reservas, y a los clientes realizar reservas de manera sencilla.

Características

Gestión de Reservas: Creación, modificación y cancelación de reservas.

Galería de Imágenes: Visualización de imágenes de habitaciones y sitios de interés cercanos.

Autenticación Segura: Implementación de JWT para la seguridad de usuarios.

Integración con API Externas: Planeado para futuras conexiones con Booking y Airbnb.

Interfaz Responsiva: Desarrollado con React y Tailwind CSS para una mejor experiencia de usuario.

Tecnologías Utilizadas

Backend (C# .NET 8 - API RESTful)

.NET Core 8 para la API.

Entity Framework Core para la gestión de base de datos.

PostgreSQL como motor de base de datos.

Swagger para la documentación de la API.

Autenticación con JWT y ASP.NET Identity.

Frontend (React + TypeScript)

React con TypeScript para el desarrollo de la SPA (Single Page Application).

React Router para la navegación.

Axios para la comunicación con la API.

Tailwind CSS para el diseño y estilos.

Base de Datos (PostgreSQL)

Migraciones con Entity Framework Core para facilitar la gestión de esquemas.

Despliegue

Backend: Contenerizado con Docker y desplegado en Azure o AWS.

Frontend: Desplegado en Vercel, Netlify o Azure Static Web Apps.

Arquitectura

El sistema sigue una arquitectura en capas:

+-------------------+        +--------------------+        +--------------------+
|  React Frontend   | <----> | .NET API Backend  | <----> |  PostgreSQL DB     |
|  (UI/UX)         |        | (Business Logic)  |        | (Data Storage)     |
+-------------------+        +--------------------+        +--------------------+
       ⬆                        ⬆
       |                        |
       | REST API Calls         | Entity Framework Core
       | (Axios, Fetch)         |
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

Instalar Node.js y npm

Descarga desde: Node.js

Verifica con:

node -v
npm -v

Instalar PostgreSQL

Descarga desde: PostgreSQL

Verifica con:

psql --version

Configuración del Backend

Clonar el repositorio:

git clone https://github.com/tu-usuario/SoftwareHotel.git
cd SoftwareHotel

Crear el proyecto API:

dotnet new webapi -n BackendHotel
cd BackendHotel

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

Aplicar migraciones y ejecutar la API:

dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run

Configuración del Frontend

Crear el proyecto React:

npx create-react-app frontend --template typescript
cd frontend

Instalar dependencias:

npm install axios react-router-dom tailwindcss

Configurar Tailwind CSS:

npx tailwindcss init -p

Ejecutar el frontend:

npm start

Contribución

Si deseas contribuir, sigue estos pasos:

Haz un fork del repositorio.

Crea una nueva rama con tu función o corrección: git checkout -b feature-nueva.

Realiza tus cambios y haz un commit: git commit -m "Agrega nueva funcionalidad".

Sube los cambios: git push origin feature-nueva.

Abre un Pull Request en GitHub.
