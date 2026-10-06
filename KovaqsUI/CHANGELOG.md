# Cambios

## Diagnóstico de consumo externo (posterior a 0.8.0)

- Se identifica Demon1 como consumidor .NET Framework 4.7.2 con referencia binaria antigua y sin ProjectReference, incompatible con KovaqsUI .NET 8.
- Se adapta la aplicación de prueba externa a net8.0-windows/UseWindowsForms, referencia real al proyecto y arranque moderno, conservando formulario, recursos y metadatos. No se modifica el framework ni la API de la biblioteca.
- Se añaden 58 verificaciones de elegibilidad/constructores de los 14 componentes y documentación de Toolbox, namespaces, consumo entre soluciones y límites del diseñador moderno.
- Se corrige la recomendación de usar indiscriminadamente el selector clásico de componentes .NET Framework para la DLL .NET 8. La revisión visual del IDE fue interrumpida por el usuario.

## 0.8.0

- KSlider: superficie única horizontal/vertical, rango entero, ValueChanged/binding, arrastre, teclado, RTL, accesibilidad y pista/thumb con estados, tamaños, radios y bordes configurables.
- KSwitch: Checked/CheckedChanged nativos, etiqueta, dimensiones independientes, colores por estado, thumb animado con reversión suave y opción de desactivar movimiento.
- KToastNotifier: componente para Toolbox/bandeja; cuatro tipos, seis posiciones, estilos por tipo, icono, fuentes, duración, cierre, cola FIFO limitada y múltiples propietarios independientes.
- KToastWindow separa dibujo/accesibilidad de administración; ventanas sin activación, apiladas dentro del propietario y monitor. Reloj compartido, pausa con propietario oculto y liberación de ventanas/fuentes propias/callbacks.
- Demo Esenciales con temas, disabled, cola, segundo propietario y personalización. DesignerSandbox incorpora los tres componentes.
- Pulido de contraste oscuro, presión/captura, alineación y animaciones; la previsualización DropDownList ya no conserva un borde nativo bajo el personalizado.
- Pruebas de clics rápidos, navegación, binding, diseñador, cola, expiración, foco, DPI sintético y recursos. API/decisiones/límites en docs/ESSENTIAL-CONTROLS.md.
- Se conserva la API existente y se prepara la DLL Release para WinForms .NET 8.

## 0.7.2

- KSegmentedControl inicia con FocusAppearance desactivado y sin grosor/inset; una única píldora anima posición y tamaño, con redirección suave y soporte RTL.
- Las ondas de KButton parten del clic y se cancelan al desactivar, ocultar o deshabilitar; se ajusta el estado de presión al arrastrar.
- KTextBox limita editor e iconos al marco y responde a cambios directos de fuente/multilínea del editor nativo.
- Demo con interruptor de movimiento y campo compacto; pruebas de geometría animada, cancelación de ondas y variantes de texto.

## 0.7.1

- Se reorganiza la demo de KDataGridView con secciones visibles, barras adaptables, columnas con mínimos, estado vacío y validación de edición.
- Se corrigen hover (fondo/texto y limpieza), restauración de alturas, respeto a estilos nativos y colores de temas personalizados.
- Los encabezados conservan texto, ordenación, wrapping, RTL y eventos de pintura nativos.
- Las insignias respetan padding, clipping y formato; Inactivo deja de clasificarse como Activo y se preservan foco/errores.
- Búsqueda segura de caracteres especiales, pruebas visuales/de integración y documentación alineada con la API real.

## 0.7.0

- Incorporación de `KDataGridView`, control de tabla de datos profesional basado en `System.Windows.Forms.DataGridView` con integración completa en el sistema de temas (`IKThemeControl`) y diseño de KovaqsUI.
- Modelo estructurado `KGridAppearance` con subestilos anidados (`Header`, `Rows`, `AlternateRows`, `Hover`, `Selection`) y soporte completo de serialización en el diseñador de Visual Studio mediante `ExpandableObjectConverter`, `Reset*()` y `ShouldSerialize*()`.
- Jerarquía estricta de precedencia visual: Sobrescritura local del desarrollador > Tema activo de KovaqsUI (`KTheme`) > Valores predeterminados.
- Presets ergonómicos de densidad (`KGridDensity.Compact`, `Normal`, `Comfortable`) que ajustan alturas y paddings escalados por DPI sin bloquear personalizaciones manuales posteriores.
- Sistema de resaltado de fila bajo cursor (`HoverHighlight`) con invalidación selectiva (`InvalidateRow`) para scrolling fluido y sin parpadeos (`DoubleBuffered = true`).
- Columna especializada `KBadgeColumn` y celda `KBadgeCell` para renderizado antialiased de insignias y estados (`Success`, `Warning`, `Danger`, `Neutral`, `Info`) con selector dinámico `StyleSelector`.
- Integración nativa con la tipografía privada `Inter` y protección contra degradación tipográfica en el diseñador mediante `KFontConverter`.
- Formulario de demostración interactivo `DataGridDemoForm` accesible mediante el argumento CLI `--grid` y navegación desde los formularios principales de la suite.
- Suite de pruebas ampliada a 440 verificaciones automáticas que cubren binding con `DataTable` y `BindingList<T>`, ordenamiento, selección, propiedades de apariencia, serialización en diseñador y estabilidad de recursos GDI sin fugas de handles.
- Documentación técnica y guía de extensión detalladas en `docs/DATAGRID.md`.

## 0.6.0

- Cantidad pasa de una composición de panel, etiqueta y botones a KNumericUpDown, un único control con borde exterior, tamaño adaptable y zonas −/+ sin bordes independientes.
- KComboBox prepara su pintura en un búfer para evitar mostrar primero el marco nativo y después la apariencia personalizada; mantiene edición y lista nativas.

- Nuevo `KSegmentedControl` horizontal/vertical con colección `KSegmentItem`, edición en diseñador, selección única y enlace de datos.
- Distribución igual o proporcional al contenido, radios interiores, estados configurables, teclado, accesibilidad y renderizado propio con infraestructura compartida.
- Demo de segmentos, muestras en DesignerSandbox y pruebas de interacción, serialización, tipografía, renderizado y DPI sintético.
- API, ejemplos, decisiones y alcance de verificación documentados en `docs/SEGMENTED-CONTROL.md`.

## 0.5.0

- El proyecto, la solución, la DLL, el paquete y los espacios de nombres pasan a llamarse KovaqsUI.
- Se actualizan la Demo, las pruebas, la documentación y los nombres internos de los recursos tipográficos.
- El interruptor `KovaUI.DisableEmbeddedFonts` sigue funcionando como alias de compatibilidad; el nombre recomendado es `KovaqsUI.DisableEmbeddedFonts`.
- Se estabiliza la carga privada de Outfit cuando GDI+ agrupa temporalmente los nombres de sus pesos y se comprueban los cuatro pesos con GDI.
- Las aplicaciones consumidoras deben actualizar sus referencias al ensamblado y los `using` al nuevo espacio de nombres.

## 0.4.1

- Solución integral al problema de sustitución y degradación a "Microsoft Sans Serif" al modificar el tamaño o peso de la fuente en tiempo de diseño y ejecución.
- Introducción de KFontConverter como convertidor tipográfico especializado para el PropertyGrid y serialización de Windows Forms, preservando las familias privadas (Inter y Outfit).
- Implementación de KFontManager.ResolveFont(...) y registro automático en la propiedad Font de los ocho controles de la biblioteca (KButton, KTextBox, KCheckBox, KRadioButton, KComboBox, KProgressBar, KPanel y KLabel).
- Métodos de extensión ergonómicos font.WithSize(size) y font.WithWeight(weight) en KFontExtensions para manipular dimensiones y pesos sin riesgos de degradación.
- Respeto total hacia fuentes de sistema personalizadas asignadas intencionalmente por el consumidor (como Arial, Consolas o asignaciones explícitas de Microsoft Sans Serif).
- Suite ampliada de pruebas automatizadas a 303 verificaciones, comprobando exhaustivamente la edición en PropertyGrid, instanciación por nombre, cambio de tamaño y liberación de recursos GDI.

## 0.4.0

- Inter integrada como tipografía predeterminada en los ocho controles de la biblioteca, sin requerir instalación en Windows.
- Inclusión de los cuatro archivos TTF estáticos oficiales (Regular, Medium, SemiBold y Bold) y licencia SIL OFL en recursos incrustados y NuGet.
- Introducción de KFontManager como gestor centralizado de colecciones privadas y registro dual en memoria para GDI+ y GDI (AddFontMemResourceEx).
- Exposición de la API KFonts.Inter con resolución de pesos nativos reales (400, 500, 600 y 700), conservando KFonts.Outfit para compatibilidad retroactiva.
- Actualización de los presets de KTypography a Inter para todos los controles, preservando asignaciones explícitas de la propiedad Font.
- Verificación exhaustiva de 243 pruebas automáticas cubriendo concurrencia, métricas DPI, diseñador de Visual Studio y fallback seguro a Segoe UI.

## 0.3.0

- Outfit integrada en la DLL, sin instalación en Windows, en pesos Regular, Medium, SemiBold y Bold.
- KFonts y presets centralizados KTypography; valores Font personalizados conservados.
- Carga privada única para GDI/GDI+, con fallback Segoe UI y soporte de inicialización en diseño.
- Avisos y licencia originales de la fuente incluidos en recursos y NuGet.
- Demos actualizadas y comprobaciones de pesos nativos, métricas DPI, serialización y fallback.

## 0.2.0

- Suite de ocho controles: KButton, KTextBox, KCheckBox, KRadioButton, KComboBox, KProgressBar, KPanel y KLabel.
- Temas, colores por estado, degradados, formas, bordes y sombras configurables.
- Presión suave sin desplazamiento predeterminado del texto; color e intensidad configurables. Onda de clic con entrada y salida gradual.
- Reloj compartido para animaciones, detenido en reposo y al desactivar el movimiento.
- Selección, edición, eventos y agrupación sobre los controles nativos de WinForms.
- Sin indicador de foco inicial; se activa explícitamente mediante FocusAppearance.
- Cursor de mano predeterminado en botones y controles de selección.
- Tipografía reutilizable con KLabel, conservando Font y ForeColor personalizados.
- Flecha del ComboBox configurable y animada; sincronización de colores con las propiedades nativas.
- Demos con inspector de propiedades, formulario de diseñador y guía para otra computadora.

La suite implementa un lenguaje visual propio. Las diferencias intencionales respecto al dibujo de los controles clásicos se describen en README.md.
