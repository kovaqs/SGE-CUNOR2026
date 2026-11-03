# KSlider, KSwitch y KToastNotifier (0.8)

WinForms .NET 8. Espacios de nombres: `KovaqsUI.Controls`, `KovaqsUI.Components`, `KovaqsUI.Styling`.

## Arquitectura

- `KSlider : Control` dibuja pista, tramo activo y thumb en una superficie sin controles hijos.
- `KSwitch : CheckBox` conserva Checked, CheckedChanged, AutoCheck, binding, Space, mnemonic, Tab y accesibilidad nativos. Su presentación es propia.
- `KToastNotifier : Component` tiene constructores vacío y `IContainer` para Toolbox/bandeja. Administra cola y duración; `KToastWindow`, interna, representa cada aviso.
- Se reutilizan KTheme/IKThemeControl, KAppearance/KStateStyle/KFocusStyle, KRenderer, KStateTransition/KScalarTransition, KFontManager/KFontConverter/KTypography y el reloj existente KAnimationClock. No hay temporizadores por aviso ni sistemas de estilos paralelos.
- Antialiasing, doble buffer y recursos desechables. Las métricas visuales son píxeles lógicos a 96 DPI; Size, Padding, Margin y Font siguen WinForms. El componente no visual cachea una pareja de fuentes escaladas al DPI del propietario.
- Color.Empty hereda. Los colores locales prevalecen sobre el tema. Las imágenes/fuentes proporcionadas por el consumidor le siguen perteneciendo; mantenerlas vivas mientras se utilizan.

## KSlider

| Propiedad/evento | Valor inicial y comportamiento |
| --- | --- |
| Minimum / Maximum | 0 / 100. Enteros, incluido todo Int32. Cambiar un extremo puede ajustar el otro y limitar Value. |
| Value / ValueChanged | 0; enlazable, una notificación por cambio efectivo. Asignar un valor fuera de rango lanza ArgumentOutOfRangeException. |
| SmallChange / LargeChange | 1 / 10, positivos. Flechas y PageUp/PageDown. |
| Orientation | Horizontal o Vertical. No cambia Size automáticamente. |
| TrackThickness / TrackCornerRadius | 4 / 2; pista y tramo activo. |
| TrackBorderThickness | 0; borde de pista y tramo activo. |
| ThumbSize / ThumbCornerRadius / BorderThickness | 20 / 10 / 1; diámetro, radio y borde del thumb. Se limitan al espacio al pintar. |
| TrackAppearance / FillAppearance / ThumbAppearance | KAppearance para pista, tramo activo y thumb. Normal, Hover, Pressed, Focused, Disabled. |
| FocusAppearance | Visible=false, Thickness=0, Inset=0 y Color.Empty. |
| Animation | 150 ms, EaseOutCubic. Anima colores; valor/posición siguen inmediatamente al arrastre. |
| ThumbBounds | Rectángulo cliente de sólo lectura, no serializado. |
| Theme / Font / BackColor | Infraestructura común; fondo transparente inicial. Text no se dibuja. |

Clic en la pista selecciona la posición. Arrastrar conserva el punto sujetado dentro del thumb y limita el valor fuera del control. Pérdida de captura/foco, ocultación o deshabilitación cancelan el arrastre. Flechas usan SmallChange, PageUp/PageDown LargeChange, Home/End los extremos. Tab/Shift+Tab navegan normalmente. En vertical el mínimo está abajo y Up aumenta; RTL invierte posición/flechas horizontales. El objeto accesible expone rol Slider y valor editable.

```csharp
var volume = new KSlider {
    Minimum = 0, Maximum = 100, Value = 40,
    SmallChange = 2, LargeChange = 10, Width = 280,
    AccessibleName = "Volumen"
};
volume.FillAppearance.Normal.FillColor = Color.Teal;
volume.ThumbAppearance.Hover.FillColor = Color.MediumTurquoise;
volume.ValueChanged += (_, _) => volumeLabel.Text = $"{volume.Value} %";
Controls.Add(volume);
var vertical = new KSlider {
    Orientation = Orientation.Vertical, Size = new Size(40, 220), Value = 65
};
Controls.Add(vertical);
```

No incluye ticks, etiquetas, intervalos, decimales ni rueda del mouse. Minimum=Maximum es válido.

## KSwitch

| Propiedad/evento | Valor inicial y comportamiento |
| --- | --- |
| Checked / CheckedChanged / AutoCheck | API nativa de dos estados; false / evento sin duplicados / true. |
| SwitchSize | 48 × 26 para la pista; independiente del control completo. |
| ThumbSize / ThumbInset | 0 (automático) / 3. El inset se suma al borde de la pista. |
| CornerRadius / ThumbCornerRadius | 13 / 12. Cero permite esquinas rectas. |
| BorderThickness / ThumbBorderThickness | 1 / 0. |
| Text / TextSpacing / TextAlign / UseMnemonic | Etiqueta opcional, separación 10, alineación y mnemonic. |
| AppearanceStates | KAppearance de pista/texto Off; evita colisión con CheckBox.Appearance. |
| CheckedAppearance | KAppearance On. Texto normal también hereda AppearanceStates.Normal.ForeColor. |
| ThumbAppearance | KAppearance del thumb; relleno inicial Theme.OnSecondary, con contraste en claro/oscuro. |
| ForeColor | Sincronizado con AppearanceStates.Normal.ForeColor. |
| Animation | 150 ms, EaseOutCubic, activada. Posición/colores con reversión desde el estado actual. |
| FocusAppearance | Sin indicador inicial, igual que KSlider. |
| AutoSize / Padding / RightToLeft / Theme / Font | Layout nativo, pista espejada en RTL, tema y tipografía compartidos. |

Space y mnemonic alternan el estado; Enter mantiene el comportamiento nativo del formulario. AutoCheck=false permite administrar Checked desde la aplicación. La API oculta/rechaza ThreeState=true e Indeterminate; no use una referencia base CheckBox para forzar un tercer estado.

La superficie siempre representa un switch: FlatStyle, UseVisualStyleBackColor y Appearance.Button no cambian su dibujo. La pista ocupa el extremo inicial (izquierdo, derecho en RTL). CheckAlign, Image/ImageList y TextImageRelation heredados no forman parte de esta presentación; para un checkbox con imagen use KCheckBox.

```csharp
var toggle = new KSwitch {
    Text = "&Notificaciones", Checked = true, AutoSize = true,
    SwitchSize = new Size(52, 28), ThumbInset = 3
};
toggle.CheckedAppearance.Normal.FillColor = Color.Teal;
toggle.CheckedAppearance.Hover.FillColor = Color.DarkCyan;
toggle.CheckedChanged += (_, _) => settings.Notifications = toggle.Checked;
toggle.Animation.Duration = 160;
Controls.Add(toggle);
// toggle.Animation.Enabled = false;
```

## KToastNotifier

### Creación y API

```csharp
// Reutilice el campo components generado por el diseñador.
private readonly KToastNotifier toasts;
public MyForm()
{
    InitializeComponent();
    components ??= new System.ComponentModel.Container();
    toasts = new KToastNotifier(components) {
        OwnerForm = this, Position = KToastPosition.BottomRight,
        Duration = 4000, MaximumVisible = 3
    };
    toasts.SuccessAppearance.BorderColor = Color.SeaGreen;
    Shown += (_, _) => toasts.Show("Listo", "El formulario está preparado.", KToastKind.Success);
}
// El Dispose generado debe conservar: if (disposing) components?.Dispose();
```

También puede arrastrarse desde Toolbox a la bandeja y asignar OwnerForm. No abre ventanas en diseño. Con constructor vacío, el consumidor debe llamar a Dispose.

`Show(string title, string message, KToastKind kind = Information, Image? icon = null, int? duration = null)` devuelve Guid. Exige título o mensaje no vacío. `Close(id)` inicia salida suave o quita inmediatamente un aviso en cola; false si no existe. `CloseAll()` elimina todo inmediatamente. No introduce eventos de acciones o clic: sólo conserva Disposed de Component.

| Propiedad | Valor inicial y alcance |
| --- | --- |
| OwnerForm | null. Obligatorio, visible y con handle antes de Show. Cambiarlo vacía la cola anterior. |
| Position | BottomRight; admite TopLeft, TopCenter, TopRight, BottomLeft, BottomCenter, BottomRight. |
| Duration | 4000 ms; 0 persistente, máximo 24 h. Cada aviso captura su duración al encolarse; Show puede sustituirla. |
| MaximumVisible / Capacity | 3 / 100. Rangos 1–10 visibles y 1–1000 totales. Capacidad llena lanza InvalidOperationException sin perder avisos. |
| ActiveCount / PendingCount | Sólo lectura. Los avisos sin superficie por falta de espacio cuentan como pendientes. |
| ToastWidth / MaximumHeight | 340 / 180. Rangos 120–2000 y 80–1000. Se limitan al área disponible. |
| EdgeMargin / Spacing | 16 / 8, separación del propietario y entre avisos. |
| CornerRadius / BorderThickness | 12 / 1. |
| ShowCloseButton | true; mouse con hover/pressed y acción accesible. |
| Appearance | KStateStyle común: FillColor, GradientColor, GradientMode, GradientAngle, ForeColor y BorderColor. |
| SuccessAppearance / InformationAppearance / WarningAppearance / ErrorAppearance | KStateStyle aplicado después del común. |
| IconColor | Color.Empty: símbolo integrado con color semántico. No recolorea imágenes externas. |
| Font / TitleFont | KTypography.Body / Button, KFontConverter, Reset y serialización. |
| Animation | 150 ms, EaseOutCubic; opacidad de entrada/salida, respeta KAnimationSettings.Enabled. |
| Theme | KTheme.Light; asignación explícita porque la bandeja no pertenece a Controls. |

```csharp
var id = toasts.Show("Atención", "Revisa la conexión.", KToastKind.Warning, duration: 0);
toasts.Close(id);
toasts.Show("Error", "No se pudo guardar.", KToastKind.Error);
KThemeManager.Apply(this, KTheme.Dark);
toasts.Theme = KTheme.Dark; // el árbol de Controls no incluye la bandeja
```

### Cola, hilo UI y monitores

- FIFO por componente. El primer aviso ocupa el extremo elegido; los demás se apilan hacia dentro. El excedente espera, su duración empieza al mostrarse. Los avisos en salida reservan su hueco; la recolocación de la pila es inmediata, sólo se anima opacidad.
- Posición calculada dentro de la intersección del área cliente con Screen.FromControl(owner).WorkingArea. Sigue tamaño, posición y DPI del propietario y evita la barra de tareas. Muy poco espacio deja los avisos pendientes.
- Ocultar/minimizar retira superficies y pausa duración. Restaurar conserva el tiempo transcurrido. Cerrar/destruir el handle, cambiar de propietario o Dispose vacían la cola y liberan ventanas/callbacks.
- Crear y utilizar en el hilo UI del formulario. La API rechaza workers antes de modificar la cola; no crea otro message loop. Desde await que conserva el contexto UI puede llamarse normalmente; desde workers use BeginInvoke, con cancelación y comprobación de cierre de su formulario.

```csharp
// En el hilo UI, después de una operación asíncrona que conserve su contexto:
await SaveAsync(cancellationToken); // cancelar el trabajo al cerrar el formulario
if (!IsDisposed && !Disposing)
    toasts.Show("Completado", "Los datos se guardaron.", KToastKind.Success);
```

Las ventanas son propiedad del formulario, no toman foco ni aparecen en la barra de tareas. Exponen rol Alert, texto accesible, aviso de aparición y acción accesible de cierre. No entran en Tab: mensajes que necesiten respuesta de teclado deben existir también en la UI del formulario.

No son notificaciones del sistema ni persisten al salir. No incluyen acciones, historial, arrastre o pausa por hover. Texto largo se envuelve y limita con elipsis a MaximumHeight. Use un notifier por formulario para compartir pila; componentes distintos administran sus colas independientemente. No manipule las ventanas internas mediante OwnedForms. Los estilos se modifican en UI, igual que la API pública.

## Demos y archivos

Abra **Esenciales…** o ejecute:

```powershell
dotnet run --project demo/KovaqsUI.Demo -c Release -- --essentials
dotnet run --project demo/KovaqsUI.Demo -c Release -- --essentials-dark
dotnet run --project tests/KovaqsUI.SmokeTests -c Release -- --essentials
```

La galería ofrece orientación, rangos, tamaños, radios, colores, disabled, animación, cuatro tipos de toast, seis posiciones, duración, cola, segundo formulario y PropertyGrid. `--essentials-small` usa el tamaño mínimo. Añada una ruta PNG para capturas; `--essentials-dark-toasts` compone también los cuatro avisos desde sus superficies. Las capturas no miden flicker de pantalla.

| Archivo | Responsabilidad |
| --- | --- |
| src/KovaqsUI/Controls/KSlider.cs | Rango, input, binding, accesibilidad, geometría y dibujo. |
| src/KovaqsUI/Controls/KSwitch.cs | CheckBox con pista/thumb animados y etiqueta. |
| src/KovaqsUI/Components/KToastNotifier.cs | Enums, API de bandeja, cola, hilo UI, propietario, duración, fuentes DPI. |
| src/KovaqsUI/Components/KToastWindow.cs | Dibujo, iconos, cierre, opacidad, accesibilidad y región. |
| demo/KovaqsUI.Demo/EssentialsDemoForm.cs | Galería y personalización en vivo. |
| demo/KovaqsUI.Demo/Program.cs | Acceso y argumentos/capturas de demo. |
| demo/KovaqsUI.Demo/DesignerSandbox.Designer.cs | Instancias convencionales de diseño y constructor IContainer. |
| tests/KovaqsUI.SmokeTests/EssentialControlsTests.cs | Input, binding, extremos, CodeDOM, cola, owner, recursos, animación. |
| tests/KovaqsUI.SmokeTests/DpiRegressionTests.cs | Mensajes DPI sintéticos y límites de ventanas. |
| tests/KovaqsUI.SmokeTests/InteractionPolishTests.cs | Clics, presión/captura, segmentos y texto nativo. |
| src/KovaqsUI/Controls/KComboBox.cs | Previsualización DropDownList sin borde nativo residual. |
| src/KovaqsUI/Bibliotecas.csproj, README.md, CHANGELOG.md, guías | Versión, API, uso y alcance. |

Se prueba DesignSurface/PropertyGrid y CodeDOM con root y componente de bandeja existentes como contexto de restauración de propiedades/referencias. DesignerSandbox compila usando IContainer. Esto no equivale a arrastrar, guardar y reabrir los tres componentes en Visual Studio; esa comprobación, lector de pantalla y migración entre monitores físicos siguen pendientes. Mensajes DPI sintéticos no cambian el DPI físico.
