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

Actualmente se trabaja en la estructura inicial y en la maquetación de los formularios. La lógica de gestión de empleados todavía no está implementada.

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
