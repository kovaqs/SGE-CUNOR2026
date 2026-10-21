# Sistema de Gestión de Empleados

Proyecto de Introducción a la Programación 2.

Aplicación de escritorio para la gestión de empleados desarrollada con C#, Windows Forms y .NET 8.

## Arquitectura

El proyecto está organizado en capas:

- Presentación (`Presentacion`)
- Negocios (`Negocios`)
- Datos (`Datos`)
- Entidades (`Entidades`)

La interfaz utiliza la biblioteca de controles KovaqsUI. Su código y recursos están incluidos en `KovaqsUI/` y se referencian mediante rutas relativas dentro de este repositorio.

## Estado del proyecto

Proyecto en desarrollo.

Incluye navegación entre formularios e inicio de sesión con MySQL. La lógica de gestión de empleados todavía está en desarrollo.

## Conexión y acceso

La capa `Datos` utiliza MySqlConnector. La base debe tener las tablas de `BaseDatos/schema.sql`; este script inicial se ejecuta una sola vez en una base vacía.

Al abrir la aplicación en otra computadora, configura la conexión con los datos de la pestaña **Admin** del servicio MySQL de Clever Cloud. Se comprueba la conexión antes de guardarla en el Administrador de credenciales de Windows, bajo `SGE_CUNOR2026/MySQL`. Cada usuario de Windows configura su propia conexión. No se utilizan variables de entorno, archivos `.env` ni cadenas de conexión en el código o en archivos del proyecto.

La conexión exige TLS y, por defecto, valida la autoridad del certificado y el nombre del servidor. Si el proveedor utiliza un certificado autofirmado, se puede configurar su huella SHA-256 localmente, confirmándola por un canal de confianza o aceptando expresamente la identidad del servidor en el primer contacto. En este último caso, la identidad inicial no cuenta con una comprobación independiente. La huella se conserva en Windows y un certificado diferente o vencido se rechaza. Un cambio de certificado requiere revisar y actualizar la configuración local. No se instala ningún certificado en Windows ni se desactiva TLS.

Las cuentas del sistema deben estar registradas antes de iniciar sesión. Si la tabla `usuarios` está vacía, el acceso muestra un aviso para contactar al administrador. Inicia sesión en `FrmLogin` para abrir `FrmPrincipal`. El botón **Cerrar sesión** regresa al acceso.

Las contraseñas del sistema se almacenan como hash PBKDF2-SHA256 con sal aleatoria. Las consultas utilizan parámetros; los accesos y cierres de sesión se registran en `bitacora`. La aplicación no recuerda contraseñas de usuarios ni muestra detalles técnicos de errores de conexión.

El plan DEV admite 5 conexiones simultáneas en total. Cada aplicación usa un pool de hasta una conexión y libera las conexiones inactivas. Los accesos desde phpMyAdmin u otras herramientas también consumen ese límite.

No copies al repositorio credenciales, exportaciones de configuración ni respaldos con datos. La configuración de conexión se puede cambiar desde **Configurar conexión a MySQL** en el acceso.

## Requisitos y compilación

- Windows.
- SDK de .NET 8 o posterior compatible con proyectos .NET 8.
- Para trabajar con el diseñador: Visual Studio compatible con .NET 8 y la carga de trabajo de desarrollo de escritorio con .NET.

Desde la raíz del repositorio:

```powershell
dotnet restore SGE_CUNOR2026.sln
dotnet build SGE_CUNOR2026.sln -c Release --no-restore
```

Para ejecutar la aplicación:

```powershell
dotnet run --project Presentacion/Presentacion.csproj
```
