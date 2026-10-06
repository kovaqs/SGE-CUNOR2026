# KSegmentedControl

Selector de una sola opción inspirado en la referencia: contenedor gris redondeado y superficie seleccionada blanca, claramente separada por Padding. Disponible desde 0.6.0; no cambia las APIs de los controles anteriores.

## Uso

```csharp
using KovaqsUI.Controls;
using KovaqsUI.Styling;

var selector = new KSegmentedControl {
    Size = new Size(480, 64), Padding = new Padding(8),
    CornerRadius = 14, SegmentCornerRadius = 10,
    FillColor = Color.FromArgb(218, 218, 218),
    SelectedFillColor = Color.White, ForeColor = Color.Black,
    AccessibleName = "Periodo"
};
selector.Items.AddRange(new KSegmentItem("Día", "day"),
    new KSegmentItem("Semana", "week"),
    new KSegmentItem("Mes", "month") { Enabled = false });
selector.SelectedValue = "day";
selector.SelectedIndexChanged += (_, _) => Console.WriteLine(selector.SelectedValue);
form.Controls.Add(selector);

selector.Items[1].Text = "Esta semana";
selector.Items.Add(new KSegmentItem("Año", "year"));
selector.Items.RemoveAt(2);
selector.Orientation = Orientation.Vertical;
selector.Size = new Size(240, 300);
selector.ItemSizeMode = KSegmentSizeMode.Content;
selector.Appearance.Hover.FillColor = Color.LightBlue;
selector.SelectedAppearance.Pressed.FillColor = Color.LightSteelBlue;
KThemeManager.Apply(form, KTheme.Light);
```

## Datos y selección

| API | Contrato |
| --- | --- |
| `Items` | Colección de contenido, solo lectura como propiedad. Admite Add, AddRange, Insert, Remove, RemoveAt, Clear y reemplazo por índice. |
| `KSegmentItem.Text` | Texto visible; vacío por defecto. No interpreta `&` como mnemónico. |
| `KSegmentItem.Value` | Identificador string, vacío por defecto. Null se normaliza a vacío. |
| `KSegmentItem.Enabled` | True por defecto. False impide seleccionar el elemento. |
| `SelectedIndex` | Índice basado en cero; -1 significa sin selección y es el valor inicial. |
| `SelectedItem` | Referencia al elemento seleccionado o null. No se serializa directamente. |
| `SelectedValue` | String del elemento seleccionado o null; asignar busca el primer elemento habilitado coincidente. Un valor ausente limpia la selección. |
| `SelectedIndexChanged` | Cambio de índice o identidad seleccionada; evento predeterminado. |
| `SelectedItemChanged` | Cambio de identidad seleccionada. |
| `SelectedValueChanged` | Cambio del valor, incluso al editar Value del elemento seleccionado. |
| `PropertyChanged` del elemento | Notifica Text, Value y Enabled; el control actualiza layout y presentación. |

Las tres propiedades de selección admiten binding. Ejemplo: `selector.DataBindings.Add("SelectedValue", modelo, "Periodo", true, DataSourceUpdateMode.OnPropertyChanged)`; el modelo debe notificar cambios con `INotifyPropertyChanged` para actualizar la vista.

Insertar/eliminar antes de la selección conserva la identidad y notifica el índice nuevo. Eliminar, reemplazar o deshabilitar el elemento seleccionado limpia la selección; deshabilitar el control completo la conserva. Asignar repetidamente la misma selección no duplica eventos. Índices inválidos, elementos ajenos o selección explícita de un elemento deshabilitado producen una excepción. Cada instancia de elemento pertenece a un solo control; no se permiten duplicados de instancia. Se permiten valores repetidos, aunque se recomiendan identificadores únicos. Remove no destruye el elemento: puede reutilizarse. Todas las modificaciones se realizan en el hilo UI.

## Propiedades visuales y layout

| Propiedad | Predeterminado / significado |
| --- | --- |
| `Orientation` | Horizontal; también Vertical. |
| `ItemSizeMode` | Equal: espacios iguales. Content: espacios proporcionales al tamaño preferido del texto, padding y mínimo. Ambos llenan el interior disponible. |
| `Padding` | 6 por lado, espacio interior del contenedor; propiedad estándar escalada por WinForms. |
| `ItemPadding` | 12 horizontal, 6 vertical; espacio interno del texto. |
| `ItemSpacing` | 4 entre opciones. |
| `MinimumItemSize` | 40×32; mínimo preferido para medición, no fuerza desbordamientos. |
| `CornerRadius` | 12, radio exterior. |
| `SegmentCornerRadius` | -1 automático: radio exterior menos el menor padding y borde. Cero o positivo fija el radio interior. |
| `BorderThickness` / `SegmentBorderThickness` | 0 / 0; grosores independientes. |
| `TextAlign` | MiddleCenter; las nueve alineaciones ContentAlignment. |
| `AutoEllipsis` | True; el texto se recorta al interior disponible. |
| `Font` | KTypography.Button (Inter), KFontConverter y KFontManager existentes. ResetFont restaura la fuente predeterminada. |
| `Surface` | KStateStyle del contenedor: relleno, degradado, dirección y borde. |
| `Appearance` | KAppearance de opciones sin seleccionar; Normal, Hover, Pressed, Focused, Disabled. |
| `SelectedAppearance` | Los mismos estados para la opción seleccionada. |
| `FillColor` / `BorderColor` | Alias de Surface. |
| `ForeColor` | Sincronizado con Appearance.Normal.ForeColor; base de texto para ambos tipos de opción. |
| `SelectedFillColor` / `SelectedForeColor` | Alias de SelectedAppearance.Normal. |
| `FocusAppearance` | Visible = false, Thickness = 0, Inset = 0 y Color.Empty. No dibuja un borde azul inicial; se habilita explícitamente. |
| `Animation` | Transiciones de color y desplazamiento de una única píldora mediante KAnimationStyle y el reloj compartido. |
| `Theme` | KTheme.Light inicial; compatible con KThemeManager.Apply. |

Los colores vacíos heredan del tema/estado base. El contenedor usa Theme.Border, el seleccionado Theme.Surface; opciones normales transparentes y texto Theme.TextPrimary. Disabled usa los tokens deshabilitados salvo overrides explícitos. Los estados específicos se aplican después de Normal, con prioridad disabled, pressed, hover y focused. En estados de un seleccionado se configura SelectedAppearance, no Appearance. Los atributos locales sobreviven a cambios de tema. Surface configura un contenedor común; los estados interactivos son de cada opción.

Las métricas propias son unidades lógicas a 96 DPI; Padding, Size y MinimumSize siguen el escalado estándar de WinForms. GetPreferredSize calcula el tamaño natural. MinimumItemSize es una preferencia: cuando falta espacio las opciones se reducen y el texto se recorta; configure MinimumSize en el control si necesita un mínimo físico. La separación también se reduce para no desbordar tamaños extremos. RightToLeft invierte el orden horizontal y la alineación del texto. GetItemBounds(index) devuelve rectángulos en píxeles del cliente; HitTest(Point) devuelve índice (también de elementos deshabilitados) o -1 en padding, huecos y fuera del contenedor.

## Interacción y accesibilidad

Un único TabStop entra/sale del selector; Tab/Shift+Tab conservan navegación de formulario. Izquierda/derecha en horizontal, arriba/abajo en vertical seleccionan la siguiente opción habilitada, sin circular. En RTL horizontal se invierte la dirección. Home/End seleccionan primera/última habilitada. Enter/Space activan al soltar la tecla; el mouse selecciona al soltar dentro de la misma opción. Salir al soltar o perder captura/foco cancela la pulsación. El foco entra en la opción seleccionada o la primera habilitada sin cambiar automáticamente la selección.

El AccessibleObject expone una lista con hijos ListItem, nombre, valor, rectángulos, foco, selección, disponibilidad y acción Seleccionar. Configure AccessibleName en el selector. Se notifican cambios de selección/foco/colección. Se reutiliza la accesibilidad de WinForms; no se añade un proveedor UIA propio. La experiencia con lectores de pantalla requiere verificación manual.

## Diseñador

Compile la solución, abra DesignerSandbox en Visual Studio y seleccione Items → `…`. El CollectionEditor estándar agrega, quita y edita Text, Value y Enabled. Configure SelectedIndex después de los elementos. Los elementos son componentes serializables y las apariencias usan serialización de contenido; no hay ensamblado de diseñador adicional. Al guardar, Visual Studio puede generar campos para los elementos y agregarlos al contenedor components. No reutilice la misma instancia entre selectores.

## Arquitectura y archivos

- `src/KovaqsUI/Controls/KSegmentedControl.cs`: control, layout, pintura, interacción, accesibilidad y enum KSegmentSizeMode.
- `src/KovaqsUI/Controls/KSegmentItem.cs`: modelo notificable y colección con propiedad exclusiva.
- `src/KovaqsUI/KovaqsUI.csproj`: versión 0.6.0.
- `demo/KovaqsUI.Demo/SegmentedDemoForm.cs`: referencia horizontal/vertical, colores, contenido, disabled, colección dinámica e inspector.
- `demo/KovaqsUI.Demo/Program.cs` y `SuiteForm.cs`: accesos a demo; argumento `--segments` y ruta opcional para captura.
- `demo/KovaqsUI.Demo/DesignerSandbox.Designer.cs`: ejemplos persistidos horizontal/vertical.
- `demo/KovaqsUI.Demo/AppearanceInspector.cs`: nombres descriptivos para selectores.
- `tests/KovaqsUI.SmokeTests/SegmentedControlTests.cs`: interacción, binding, píxeles, colección, accesibilidad y round trip CodeDOM.
- `tests/KovaqsUI.SmokeTests/Program.cs`, `TypographyTests.cs` y `DpiRegressionTests.cs`: integración de pruebas, fuente en noveno control y DPI sintético.
- `README.md`, `CHANGELOG.md`, `docs/DESIGN.md`, `docs/GETTING-STARTED.md`, `docs/MANUAL-VALIDATION.md` y esta guía: descripción, ejecución, decisiones y verificación.

Renderizado propio sin controles superpuestos; doble búfer, antialiasing y clipping exterior/interior. Reutiliza KRenderer, PaintStyle, KTheme, KAppearance, KFocusStyle, KStateTransition y tipografía existente. Las transiciones por elemento se liberan al retirar elementos o destruir el control. No introduce dependencias, fuentes, licencias ni temporizadores adicionales.

## Verificación

Ejecute `./build.ps1` para toda la regresión o `dotnet run --project tests/KovaqsUI.SmokeTests -- --segmented` para las pruebas específicas. La demo se abre con `dotnet run --project demo/KovaqsUI.Demo -- --segments`.

Se verifica automáticamente selección, cambios de colección, binding bidireccional, Tab real de formulario, handlers de mouse/teclado, RTL, estados pintados, límites pequeños, animación con eliminación, árbol accesible, PropertyGrid y serialización/restauración de componentes con DesignSurface. DPI usa mensajes sintéticos a 120/144/192/96: comprueba layout y pintura, pero no reemplaza migración entre monitores físicos. Se revisó una captura de la demo. No se afirma validación interactiva del IDE ni de lector de pantalla; completar la lista manual antes de una entrega de producción.

## Movimiento de la selección (0.7.2)

La píldora interpola posición y tamaño hasta la opción seleccionada, en horizontal, vertical y RTL, también con tamaños por contenido. Un cambio rápido redirige el movimiento desde la posición actual. Los textos permanecen fijos; el color seleccionado se recorta a la píldora en movimiento. SelectedIndex/Item/Value y sus eventos cambian inmediatamente, sin esperar a la animación.

Se reutilizan cuatro KScalarTransition y KStateTransition, con el mismo reloj compartido. Animation.Duration (150 ms por defecto) y Easing controlan el movimiento; la demo usa 240 ms y ofrece «Animación sí / no». Animation.Enabled=false, duración cero o KAnimationSettings.Enabled=false aplican el destino directamente. La primera selección aparece en su lugar. Cambios de layout/colección recalculan la posición sin arrastrar coordenadas antiguas; borrar la selección quita la píldora. Los recursos se liberan con el control.

FocusAppearance comienza completamente vacío/desactivado. Si un formulario antiguo guardó Visible=true, Thickness o Inset en InitializeComponent, esos valores explícitos se conservan: restablézcalos en el diseñador para utilizar los nuevos predeterminados. Para activar el foco voluntariamente, configure Visible=true, Thickness y opcionalmente Color/Inset.