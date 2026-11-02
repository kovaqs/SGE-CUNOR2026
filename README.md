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

Incluye acceso con MySQL, expedientes de empleados, departamentos, puestos, asistencias, configuración, usuarios, operaciones de nómina y reportes. Las ventanas principales conservan su instancia y actualizan los datos al volver a ellas.

La bitácora, el catálogo de horarios y el listado de permisos laborales ya incluyen sus consultas. Queda pendiente el aporte del listado de períodos de nómina. Las consultas se mantienen separadas de las operaciones de edición mediante los archivos `.Operaciones.cs` cuando corresponde.

## Conexión y acceso

La capa `Datos` utiliza MySqlConnector. La base debe tener las tablas de `BaseDatos/schema.sql`; este script inicial se ejecuta una sola vez en una base vacía.

Al abrir la aplicación en otra computadora, pulsa **Configurar la conexión** en el login e introduce los datos de la pestaña **Admin** del servicio MySQL de Clever Cloud. El botón aparece cuando falta la configuración o falla la comprobación de conexión y se oculta cuando esta funciona. Se comprueba la conexión antes de guardarla en el Administrador de credenciales de Windows, bajo `SGE_CUNOR2026/MySQL`. Cada usuario de Windows configura su propia conexión. No se utilizan variables de entorno, archivos `.env` ni cadenas de conexión en el código o en archivos del proyecto.

La conexión exige TLS y, por defecto, valida la autoridad del certificado y el nombre del servidor. Si el proveedor utiliza un certificado autofirmado, se puede configurar su huella SHA-256 localmente, confirmándola por un canal de confianza o aceptando expresamente la identidad del servidor en el primer contacto. En este último caso, la identidad inicial no cuenta con una comprobación independiente. La huella se conserva en Windows y un certificado diferente o vencido se rechaza. Un cambio de certificado requiere revisar y actualizar la configuración local. No se instala ningún certificado en Windows ni se desactiva TLS.

Las cuentas del sistema deben estar registradas antes de iniciar sesión. Si la tabla `usuarios` está vacía, el acceso muestra un aviso para contactar al administrador. Inicia sesión en `FrmLogin` para abrir `FrmPrincipal`. El botón **Cerrar sesión** regresa al acceso.

Las contraseñas del sistema se almacenan como hash PBKDF2-SHA256 con sal aleatoria. Las consultas utilizan parámetros; los accesos y cierres de sesión se registran en `bitacora`. La aplicación no recuerda contraseñas de usuarios ni muestra detalles técnicos de errores de conexión.

El plan DEV admite 5 conexiones simultáneas en total. Cada aplicación usa un pool de hasta una conexión y libera las conexiones inactivas. Los accesos desde phpMyAdmin u otras herramientas también consumen ese límite.

No copies al repositorio credenciales, exportaciones de configuración ni respaldos con datos. La configuración de conexión se puede cambiar desde **Configuración** en el panel principal. Al guardarla se cierra la sesión y se regresa al login. Los cambios o la eliminación de la configuración desde Windows también cierran la sesión al detectarse; la aplicación revisa su fecha de modificación local cada tres segundos, sin consultar MySQL.

## Datos sensibles

Los sueldos, números de cuenta bancaria e importes de nómina se cifran con AES-GCM antes de guardarse en MySQL. `RepositorioEmpleados` guarda el expediente y su condición inicial, `ServicioDatosSensibles` registra cambios de condición laboral y `RepositorioNomina` conserva los importes de pago. La clave se deriva automáticamente de la contraseña de MySQL configurada localmente; las computadoras que comparten la base deben utilizar esa misma contraseña. Cambiarla requiere volver a cifrar los datos antes del cambio. No hay una contraseña adicional para el cifrado.

Las contraseñas de usuarios mantienen su hash PBKDF2-SHA256. Los cambios de salario requieren confirmar la contraseña del usuario que realiza la operación. Se conserva la condición laboral anterior y el cambio queda registrado en `bitacora`, con su usuario, fecha y registro afectado, sin incluir el sueldo ni la cuenta en el texto de la bitácora.

Un `INSERT` desde Workbench no ejecuta el cifrado de C#: los datos de ejemplo con sueldos o cuentas deben prepararse mediante las funciones del sistema.

## Uso de los módulos

1. En Configuración, completa los datos de la empresa. Registra departamentos, puestos, tipos de contrato y horarios antes de crear expedientes.
2. En Empleados, Agregar abre el expediente. Sus tres secciones se guardan juntas; la foto se puede seleccionar o arrastrar y se reduce antes de almacenarse. El menú de la tabla permite editar, consultar historial, cambiar estado, emitir constancia o eliminar. Los cambios de puesto y sueldo se registran desde Historial laboral.
3. En Asistencias, registra la jornada y sus marcas. Una fila existente se corrige con doble clic. No se considera falta una fila inexistente: la falta se registra con su estado correspondiente. La exportación a Excel incluye todos los resultados del filtro.
4. En Usuarios, el doble clic abre la edición de cuenta y el restablecimiento de contraseña. Para modificar la propia cuenta se utiliza Mi cuenta. Los permisos se asignan por módulo desde Roles y se aplican al volver a iniciar sesión; el administrador conserva acceso completo.
5. En Nómina, crea un período mensual y abre su detalle para calcularlo. Se utiliza el sueldo vigente al cierre del mes completo, sin prorrateo ni deducciones automáticas. Los ingresos y deducciones se agregan manualmente y sus totales se recalculan juntos. Un período calculado no se sobrescribe; al cerrarlo se bloquean sus movimientos. La anulación conserva sus registros.
6. Reportes permite consultar empleados, resumen por departamento, asistencias y nómina, y guardar el resultado completo en PDF o Excel. Las constancias se emiten desde el menú de Empleados; las boletas individuales o por departamento se generan desde Nómina.

Los catálogos y expedientes comprueban sus relaciones antes de eliminar. La eliminación de un empleado incluye su historial, pero se rechaza si tiene usuarios, asistencias, permisos o pagos relacionados. Puede mantenerse inactivo para conservar esos datos.

Las consultas del inicio generan los indicadores y gráficos desde MySQL. `BaseDatos/consultas_analisis.sql` contiene la consulta agrupada y la comparación de un filtro mensual con su versión por rango de fechas para revisarlas desde Workbench.

La exportación utiliza [PDFsharp/MigraDoc](https://docs.pdfsharp.net/) para PDF y [ClosedXML](https://docs.closedxml.io/) para Excel. Los archivos se guardan en el destino elegido por el usuario.

Horarios y Permisos laborales actualizan sus consultas después de guardar o eliminar registros. Al incorporar la guía pendiente de Nómina, conecta `DatosActualizados` a `Consulta_Filtro` para refrescar el listado después de una operación. Los bloques de esa guía se pegan en sus cuatro archivos respectivos.

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
