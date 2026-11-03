# KDataGridView

Tabla basada directamente en `System.Windows.Forms.DataGridView`. Conserva binding, edición, selección, ordenación, validación, teclado, portapapeles, columnas congeladas y modo virtual de WinForms. La revisión 0.7.1 corrige la pintura y la distribución de la demo sin cambiar las firmas públicas.

## Uso

```csharp
using KovaqsUI.Controls;
using KovaqsUI.Styling;

var grid = new KDataGridView {
    Dock = DockStyle.Fill,
    AutoGenerateColumns = false,
    AllowUserToAddRows = false,
    ReadOnly = true,
    Density = KGridDensity.Normal,
    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
    AccessibleName = "Colaboradores"
};
grid.Columns.Add(new DataGridViewTextBoxColumn {
    HeaderText = "Nombre", DataPropertyName = "Nombre", MinimumWidth = 150
});
var status = new KBadgeColumn {
    HeaderText = "Estado", DataPropertyName = "Estado", MinimumWidth = 110,
    SortMode = DataGridViewColumnSortMode.Automatic
};
status.StyleSelector = value => value?.ToString() switch {
    "Activo" => KBadgeStyle.Success,
    "Pendiente" => KBadgeStyle.Warning,
    "Inactivo" => KBadgeStyle.Danger,
    _ => KBadgeStyle.Neutral
};
grid.Columns.Add(status);
grid.DataSource = colaboradores; // DataTable, DataView o BindingList<T>, por ejemplo
form.Controls.Add(grid);
KThemeManager.Apply(form, KTheme.Dark);
```

## Apariencia y precedencia

| API | Propiedades y comportamiento |
| --- | --- |
| `Appearance.Header` | BackColor, ForeColor, BorderColor y Height. La línea inferior se pinta sobre el contenido nativo. |
| `Appearance.Rows` | BackColor, ForeColor, GridColor y Height. El padding se configura mediante `DefaultCellStyle.Padding`. |
| `Appearance.AlternateRows` | Enabled, BackColor y ForeColor; desactivado por defecto. Selección y fuente heredan del estilo base. |
| `Appearance.Hover` | Enabled (true), BackColor y ForeColor. Se aplica mediante CellFormatting, sin modificar permanentemente los estilos de las filas. |
| `Appearance.Selection` | BackColor y ForeColor; también respeta selección individual de celdas. |
| `GridLines` | None, Horizontal (predeterminado) o Both. Para otros bordes use la API nativa CellBorderStyle. No hay miembro Vertical en este enum. |
| `Density` | Compact, Normal, Comfortable y Custom. |
| `Font` | Inter mediante KTypography.Body; KFontConverter conserva familias privadas. Los estilos heredan la fuente salvo override local. |
| `Theme` | KTheme.Light inicial; propagable con KThemeManager. |

Los colores vacíos recuperan la herencia. Los subestilos admiten Reset y serialización de contenido en PropertyGrid. Una propiedad explícita de Appearance prevalece sobre el valor global correspondiente. Los overrides nativos de fila, columna o celda conservan su precedencia WinForms. Las asignaciones directas a DefaultCellStyle, estilos de encabezado, GridColor y BackgroundColor se conservan al cambiar de tema si difieren del último valor administrado por el control. Para fijar incluso un color idéntico al valor actual del tema, use Appearance: la igualdad de valores no permite distinguir una reasignación nativa idéntica.

Los temas personalizados derivados de Dark usan sus propios tokens Surface/SurfaceHover/Focus y no comparaciones con una instancia concreta. El área vacía acompaña al fondo de filas, salvo BackgroundColor explícito. La selección usa una mezcla de Surface y Focus; su texto usa TextPrimary. La fuente del encabezado o celda asignada explícitamente no se sustituye al cambiar Font del grid.

La selección tiene prioridad sobre hover en cada celda seleccionada. CellFormatting del consumidor se ejecuta después y puede ajustar el resultado. El hover se limpia al entrar en el espacio vacío, salir, deshabilitarlo, desplazar, ordenar, cambiar datos o quitar filas. Solo se invalidan las filas afectadas por movimiento del puntero.

## Encabezados nativos

Se conserva el pintado nativo de texto, padding, alineación, wrapping, RTL y flecha de ordenación. KDataGridView añade la línea inferior configurable y elimina los bordes de relieve de las columnas. Los encabezados de fila y la esquina mantienen su comportamiento nativo. Un handler CellPainting puede asumir el pintado con `e.Handled = true`, también en encabezados. EnableHeadersVisualStyles comienza en false para aplicar colores propios.

Para encabezados de varias líneas, configure WrapMode y ColumnHeadersHeightSizeMode.AutoSize, o una altura suficiente. La demo utiliza una línea y truncado nativo, de modo que no aparecen segundos renglones cortados al estrechar columnas. Las barras de desplazamiento siguen siendo nativas y su aspecto depende de Windows.

## Densidad y tamaño

Todas las métricas de Appearance son lógicas a 96 DPI. Los presets reales son:

| Density | Fila | Encabezado | Padding horizontal / vertical |
| --- | --- | --- | --- |
| Compact | 32 | 32 | 6 / 2 |
| Normal | 42 | 38 | 8 / 4 |
| Comfortable | 56 | 46 | 10 / 6 |

Asignar un preset actualiza las filas existentes y RowTemplate; esto es una operación explícita sobre la colección. Las alturas positivas de Appearance.Rows/Header prevalecen sobre el preset. Restablecerlas a cero recupera las alturas del último preset. Los valores respetan los límites de WinForms y MinimumHeight de cada fila. Custom conserva las dimensiones actuales, permitiendo usar las propiedades nativas de tamaño y autosizing.

Los cambios de tema o colores no recorren las filas ni deshacen alturas ajustadas manualmente. Para un layout enteramente manual use Custom; con otros presets el cambio de DPI recalcula las métricas del preset. La selección de densidad conserva el modo nativo de autosizing de encabezados configurado por el consumidor.

## KBadgeColumn y KBadgeCell

Las insignias preservan fondo/selección, bordes, foco y errores de la celda. Respetan Padding, alineación, RTL y el área visible al hacer scroll; el texto largo se trunca y no invade columnas vecinas. Se utiliza el valor formateado por WinForms, incluidos NullValue y CellFormatting.

`StyleSelector` es **`Func<object?, KBadgeStyle>`**, con un solo parámetro (el valor). Es configuración de runtime, no se serializa como código de diseñador. Cambiarlo invalida la columna; Clone conserva selector y tipo de celda. La edición continúa siendo la de DataGridViewTextBoxCell.

KBadgeStyle ofrece Success, Warning, Danger, Info y Neutral. Son paletas fijas claras; si se desean colores propios para un tema, asigne StyleSelector. Sin selector se usa reconocimiento simple de estados; los negativos, como Inactivo, se resuelven antes de Activo para evitar falsos éxitos. Para vocabularios de negocio use coincidencias exactas como en el ejemplo. Las celdas vacías no muestran insignia y mantienen sus indicadores nativos de foco/error.

## Demo

```powershell
dotnet run --project demo/KovaqsUI.Demo -- --grid
dotnet run --project demo/KovaqsUI.Demo -- --grid-dark
dotnet run --project demo/KovaqsUI.Demo -- --grid-small
```

DataGridDemoForm utiliza TableLayoutPanel con título, herramientas, tabla, acciones y estado separados. Las herramientas se distribuyen en varias líneas cuando falta ancho. La tabla rellena el espacio restante; columnas con ancho mínimo conservan legibilidad y usan scroll horizontal si es necesario. El padding de la tarjeta deja visibles sus esquinas.

La búsqueda filtra nombre/correo/cargo y trata apóstrofos, corchetes, asteriscos y porcentajes como texto literal. Se pueden combinar filtros de estado, agregar una fila, cambiar tema/densidad/divisores/alternas, habilitar edición y personalizar controles. Un valor inválido muestra un mensaje en la barra de estado y permite corregirlo o cancelar con Esc. La vista vacía muestra una explicación. La selección utiliza las filas nativas; se retiraron las casillas sin binding y la exportación simulada. Los datos de ejemplo son ficticios.

## Archivos de la revisión

- `src/KovaqsUI/Controls/KDataGridView.cs`: hover, encabezados nativos, precedencia de estilos, restauración de alturas y gestión de recursos.
- `src/KovaqsUI/Controls/Columns/KBadgeColumn.cs`: clasificación de estados, clipping, padding, formato, foco/errores y actualización del selector.
- `demo/KovaqsUI.Demo/DataGridDemoForm.cs`: layout adaptable, filtros seguros, edición, estado vacío y liberación de recursos.
- `demo/KovaqsUI.Demo/Program.cs`: variante pequeña de captura/demo.
- `tests/KovaqsUI.SmokeTests/GridVisualRegressionTests.cs`: regresión de píxeles, estilos, interacción nativa, virtualización y CodeDOM.
- `tests/KovaqsUI.SmokeTests/GridDemoRegressionTests.cs`: ejecución real de la demo, tamaños, filtros, acciones y validación.
- Proyecto de pruebas y Program: referencia a la demo para pruebas de integración y ejecución focalizada `--grid`.
- `src/KovaqsUI/Bibliotecas.csproj`, CHANGELOG y documentación: versión 0.7.1 y contratos actualizados.

## Verificación

```powershell
dotnet run --project tests/KovaqsUI.SmokeTests -c Release -- --grid
./build.ps1
```

Las pruebas cubren binding, ordenación, selección por fila/celda, edición y contenido para portapapeles, fuentes, hover, overrides, alturas, celdas estrechas, RTL, columnas congeladas, 10.000 filas virtuales, CodeDOM con KBadgeColumn, recursos GDI y demo en tres tamaños. No escriben datos de prueba en el portapapeles del usuario. La persistencia se verifica con DesignSurface y serialización/restauración real, no solo atributos de propiedades. Las capturas claras/oscuras y de ventana pequeña se revisan visualmente. Quedan para validación manual el diseñador de Visual Studio interactivo, lectores de pantalla y monitores físicos de distinto DPI.
