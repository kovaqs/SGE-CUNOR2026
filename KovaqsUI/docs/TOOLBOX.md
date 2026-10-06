# Consumir KovaqsUI desde otra solución y diagnosticar el Toolbox

## Causa comprobada en Demon1

El problema estaba en la aplicación consumidora, no en la declaración WinForms de KovaqsUI:

| Inspección previa | Resultado |
| --- | --- |
| KovaqsUI.csproj, evaluación de MSBuild | TargetFramework=net8.0-windows, UseWindowsForms=true, OutputType=Library, plataforma Windows, AssemblyName/RootNamespace=KovaqsUI. |
| Directory.Build.props | Define correctamente TargetFramework y UseWindowsForms para biblioteca, Demo y SmokeTests. No tienen que repetirse en cada csproj. |
| Demo | net8.0-windows, WinExe y ProjectReference real a KovaqsUI. |
| Demon1.csproj original | Proyecto clásico con TargetFrameworkVersion=v4.7.2; consumidor .NET Framework, incompatible con esta biblioteca net8.0-windows. |
| Referencia original de Demon1 | Reference/HintPath a libs/KovaqsUI.dll; **no había ningún ProjectReference**. MSBuild devolvía ProjectReference vacío. |
| Demon1.sln | KovaqsUI sí estaba agregada a la solución. ProjectDependencies imponía orden de compilación, pero no creaba una referencia del consumidor. |
| Namespaces | Controles en KovaqsUI.Controls; notifier en KovaqsUI.Components. Un `using KovaqsUI;` no importa esos subespacios. |
| AutoToolboxPopulate | Dos entradas guardadas en CurrentSettings.vssettings con true/True. No se cambió esa preferencia. Su estado en la UI no se comprobó. |

No se puede cargar una biblioteca WinForms de .NET 8 en el diseñador del consumidor .NET Framework 4.7.2. Microsoft distingue las dos implementaciones y explica que el diseñador de .NET moderno utiliza un proceso separado, DesignToolsServer, con el framework de la aplicación: [diferencias del diseñador](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls-design/designer-differences-framework).

### Inspección de clases y constructores

Los trece controles KButton, KTextBox, KCheckBox, KRadioButton, KComboBox, KProgressBar, KPanel, KLabel, KSegmentedControl, KNumericUpDown, KDataGridView, KSlider y KSwitch son públicos, concretos, derivados de Control/UserControl o controles WinForms nativos, y disponen de constructor público sin argumentos y ToolboxItem(true). KToastNotifier es un Component público concreto, con ToolboxItem(true), constructor vacío y constructor IContainer. No tienen exclusión explícita DesignTimeVisible(false).

KSegmentItem está excluido intencionalmente: se edita dentro de Items. KBadgeColumn está excluida como entrada independiente del Toolbox: se agrega como columna de KDataGridView. KToastWindow es interna. No se cambiaron esos metadatos.

## Corrección realizada

Sólo se adaptó el consumidor de prueba al framework ya utilizado por KovaqsUI. No se cambiaron APIs, temas, tipografía privada, fuentes embebidas, versión ni empaquetado de la biblioteca.

| Archivo | Cambio |
| --- | --- |
| Demon1/Demon1.csproj, externo al repositorio | SDK Microsoft.NET.Sdk, net8.0-windows, UseWindowsForms=true, WinExe y PerMonitorV2. Se sustituye la referencia a libs por ProjectReference al csproj original. Se preservan metadatos de recursos/settings y AssemblyInfo existente; se usan Update para evitar duplicar elementos implícitos del SDK. |
| Demon1/Program.cs | ApplicationConfiguration.Initialize antes de Application.Run. |
| Demon1/Form1.cs | Using de Controls y Components. |
| Demon1/App.config | Se retira el arranque CLR v4.0/.NETFramework4.7.2; el runtime ahora lo define el proyecto y runtimeconfig.json. |
| Demon1/Properties/AssemblyInfo.cs | SupportedOSPlatform("windows6.1") para el destino Windows; se conserva el resto de metadatos, sin duplicar atributos generados. |
| tests/KovaqsUI.SmokeTests/ToolboxDiscoveryTests.cs | Regresión de elegibilidad, constructores, metadata y diseñadores estándar disponibles. |
| tests/KovaqsUI.SmokeTests/Program.cs | Modo --toolbox e inclusión de la prueba en la suite. |
| README, GETTING-STARTED, MANUAL-VALIDATION, CHANGELOG y esta guía | Diagnóstico, consumo externo y límites de la verificación. |

Form1.Designer.cs se conservó byte por byte, comprobado con SHA-256. No se eliminó la copia de DLL en libs; ya no participa como referencia. La solución externa ya contenía ambos proyectos y no necesitó cambios. Hay copias locales previas en `artifacts/toolbox-diagnosis/Demon1-before-net8`, excluidas de Git; los archivos/configuraciones del consumidor no se incorporan a este repositorio.

## Verificación y límites

- Demon1.sln compila después de la corrección sin errores ni advertencias. La evaluación efectiva confirma net8.0-windows, UseWindowsForms=true y la ruta correcta de ProjectReference.
- Un consumidor de diagnóstico referencia el proyecto externo Demon1, resuelve los tipos de KovaqsUI a través de esa referencia, instancia Form1 y ejecuta **58 comprobaciones sobre los 14 componentes**. También confirma ocho TTF embebidos e inicialización de Inter.
- DesignSurface puede crear los 14 componentes. Para KDataGridView se compara disponibilidad del diseñador con el DataGridView nativo: el host de runtime no incluye todos los diseñadores que usa Visual Studio. Esto no es un fallo de ToolboxItem ni prueba la UI del diseñador externo.
- No fue necesario añadir un control mínimo a la DLL: la incompatibilidad del consumidor y la ausencia de ProjectReference quedaron demostradas directamente.
- Se inició Visual Studio para validar la UI, pero el usuario detuvo Computer Use con Escape. **No se declara verificada la aparición visual en Toolbox, la lista emergente de IntelliSense ni arrastrar/guardar/reabrir desde Visual Studio.** La resolución de tipos sí está comprobada mediante compilación.
- AutoToolboxPopulate es una opción de Visual Studio, no una propiedad MSBuild de este proyecto. Un valor vacío consultado con `-getProperty:AutoToolboxPopulate` no equivale a false; no se añadió un XML sin efecto al csproj.

El Toolbox depende del documento/diseñador activo, framework compatible, compilación y estado del IDE. `[ToolboxItem(true)]` permite la inclusión, pero no obliga a Visual Studio a descubrir un ensamblado que su diseñador no puede cargar. Ver [Toolbox de Visual Studio](https://learn.microsoft.com/en-us/visualstudio/ide/reference/toolbox).

El asistente clásico **Elegir elementos → Componentes de .NET Framework** no es una validación de compatibilidad con net8.0-windows. No hay que convertir KovaqsUI a .NET Framework para que lo acepte. La [guía de autopoblación](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/walkthrough-automatically-populating-the-toolbox-with-custom-components) explica la inclusión de proyectos/compilación/AutoToolboxPopulate, pero advierte que su ejemplo se escribió para .NET Framework; sus pasos no garantizan todos los casos del diseñador moderno.

## Pasos exactos para otra solución durante desarrollo

1. Crear **Aplicación de Windows Forms**, C#, con **.NET 8**; evitar la plantilla **Aplicación de Windows Forms (.NET Framework)**. Usar Visual Studio compatible con .NET 8 y la carga de trabajo de escritorio .NET (en la máquina inspeccionada: VS 2022 17.14.39).
2. Conservar el repositorio completo, incluido Directory.Build.props. Agregar a la solución consumidora el proyecto existente `src/KovaqsUI/KovaqsUI.csproj`. Puede permanecer en otra carpeta; no copiar sólo el csproj o sólo src.
3. En el proyecto consumidor: **Dependencias → Agregar referencia de proyecto → Proyectos → KovaqsUI**. Confirmar ProjectReference dentro del csproj. Agregar el proyecto a la solución y configurar ProjectDependencies no sustituye este paso.
4. El consumidor debe definir su propio destino WinForms; no hereda Directory.Build.props de la biblioteca. Un csproj mínimo nuevo es:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows</TargetFramework>
    <UseWindowsForms>true</UseWindowsForms>
    <ApplicationHighDpiMode>PerMonitorV2</ApplicationHighDpiMode>
  </PropertyGroup>
  <ItemGroup>
    <ProjectReference Include="..\..\KovaqsUI\src\KovaqsUI\KovaqsUI.csproj" />
  </ItemGroup>
</Project>
```

La ruta de ProjectReference es relativa al csproj consumidor, no a la solución. Adáptela a sus carpetas. En CLI, desde la solución consumidora:

```powershell
dotnet sln .\MiAplicacion.sln add C:\dev\KovaqsUI\src\KovaqsUI\KovaqsUI.csproj
dotnet add .\MiAplicacion\MiAplicacion.csproj reference C:\dev\KovaqsUI\src\KovaqsUI\KovaqsUI.csproj
dotnet build .\MiAplicacion.sln -c Debug
```

5. Abrir **Form1.cs → Ver diseñador** (Shift+F7). El archivo de código, csproj o biblioteca seleccionados no equivalen al diseñador de un formulario consumidor. Abrir Toolbox (Ctrl+Alt+X), vaciar su filtro y revisar el grupo del proyecto KovaqsUI.
6. En **Herramientas → Opciones → Diseñador de Windows Forms → General**, comprobar **AutoToolboxPopulate/Automatically Populate Toolbox=True**. Tras cambiar de framework o referencia, cerrar/reabrir la solución y compilar desde Visual Studio antes de reabrir el diseñador.
7. Verificar IntelliSense con `using KovaqsUI.Controls;` y `using KovaqsUI.Components;`. Escribir `new KButton` o `new KToastNotifier` debe resolver las clases. Arrastrar KButton al formulario y KToastNotifier a la bandeja, cambiar una propiedad, guardar y reabrir para validar la persistencia real.

```csharp
using KovaqsUI.Controls;
using KovaqsUI.Components;

var button = new KButton { Text = "Guardar" };
Controls.Add(button);
// Para toasts: usar un contenedor, OwnerForm y mostrarlos después de Shown.
```

Si aún no aparecen, revisar **Salida → Diseñador de Windows Forms** y **Compilación** y conservar el error exacto. Confirmar que ambos proyectos están cargados, que no hay una referencia duplicada a DLL antigua y que el proceso diseñador corresponde al framework del consumidor. No borrar caches ni restaurar Toolbox como primera medida: eso no corrige frameworks incompatibles. La prueba `dotnet run --project tests/KovaqsUI.SmokeTests -c Release -- --toolbox` valida elegibilidad/constructores, no la UI de Visual Studio.
