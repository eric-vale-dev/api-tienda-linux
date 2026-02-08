# 🐧 Tiendita API (Linux Edition)

Una API RESTful completa para la gestión de inventario, desarrollada y probada al 100% en un entorno **Fedora Linux**.

Este proyecto demuestra la capacidad multiplataforma de **.NET 8**, integrando **Entity Framework Core** con una base de datos **PostgreSQL** ejecutándose en un contenedor **Docker**.

##  Tecnologías Utilizadas

* **Sistema Operativo:** Fedora Linux (Workstation)
* **Framework:** .NET 8 SDK (C#)
* **Base de Datos:** PostgreSQL 16
* **ORM:** Entity Framework Core (Code-First)
* **Virtualización:** Docker
* **Documentación:** Swagger UI

##  Requisitos Previos

Para ejecutar este proyecto en tu máquina local, asegúrate de tener instalado:

1.  **SDK de .NET 8.0**: [Descargar aquí](https://dotnet.microsoft.com/download/dotnet/8.0)
2.  **Docker Desktop o Engine**: Necesario para levantar la base de datos sin instalar Postgres localmente.
3.  **Git**: Para clonar el repositorio.

## Levantar la Base de Datos (Docker)
El proyecto requiere una instancia de PostgreSQL. Ejecuta el siguiente comando para descargar la imagen, crear el contenedor y configurar el puerto:

docker run --name tiendita-db -e POSTGRES_PASSWORD=1234 -p 5432:5432 -d postgres
Nota: Este comando configura la contraseña 1234 y expone el puerto 5432 en tu localhost.

## COnfiguración de credenciales 
La cadena de conexión por defecto asume que estás usando el contenedor Docker del paso anterior, si deseas cambiar la contraseña o el usuario:

* Abre el archivo appsettings.json en la raíz del proyecto.
* Busca la sección ConnectionStrings.
* Modifica el valor Password=1234 por tu contraseña real.

## Crear la Base de Datos (Migraciones)
Una vez que el contenedor de Docker esté corriendo, inicializa la base de datos y crea las tablas usando Entity Framework:

dotnet ef database update
