<!-- Registro histórico: los pendientes antiguos del IDE fueron sustituidos por la validación manual del usuario. -->
# Registro de verificación manual

## Diagnóstico Toolbox en Demon1

Se encontró y corrigió la incompatibilidad real: Demon1 era .NET Framework 4.7.2 con Reference/HintPath a una DLL .NET 8 y sin ProjectReference, aunque ambos proyectos estaban en la solución. El consumidor ahora compila como net8.0-windows/UseWindowsForms con referencia al proyecto; cero errores/advertencias. Form1.Designer.cs se conserva sin cambios (SHA-256). La configuración guardada de AutoToolboxPopulate era true/True.

58 comprobaciones específicas verifican accesibilidad pública, constructores, metadatos Toolbox y creación en DesignSurface de 14 componentes. Un consumidor de diagnóstico referencia Demon1 y verifica la resolución transitiva, creación de Form1 y ocho fuentes embebidas. Para KDataGridView, la disponibilidad del diseñador de runtime se compara con el DataGridView nativo; no representa el diseñador externo de VS.

**El usuario detuvo Computer Use con Escape.** No se continuó manejando Visual Studio. La aparición visual en Toolbox, lista de IntelliSense y arrastrar/guardar/reabrir siguen sin verificación en esta sesión. El diagnóstico, cambios y pasos para completarla están en [TOOLBOX.md](TOOLBOX.md). Copias previas y artefactos locales: artifacts/toolbox-diagnosis, excluido de Git.

## Entrega 0.8.0 · esenciales y pulido

- Solución Release y biblioteca compiladas con cero errores y cero advertencias. Salida de verificación aislada: `artifacts/essentials`.
- Suite completa: **633 comprobaciones aprobadas**, incluidos controles existentes, 96 de esenciales, 39 de pulido y mensajes DPI sintéticos para slider/switch/toasts.
- Inicialización de Inter en LicenseUsageMode.Designtime aprobada para trece controles y las dos fuentes del notifier.
- DesignSurface/PropertyGrid resuelven diseñadores de los tres componentes. CodeDOM restaura rango, valor, Checked, estilos, OwnerForm, posición y duración, con root/componente de bandeja precreados como contexto. DesignerSandbox compila con el constructor IContainer.
- Revisión visual de capturas claras, oscuras, tamaño mínimo y cuatro toasts. Se corrigieron contraste del thumb oscuro, posición inicial del selector de demo, esquinas de tarjetas y borde nativo residual en previsualizaciones de ComboBox.
- Botones: presión, arrastre fuera/dentro, cancelación fuera, pérdida de captura, clics rápidos y desactivación global/per-control. Segmentos: recorrido, reversión, RTL y dimensiones. Texto: normal, readonly, password, multiline, RTL y disabled preservan editor y selección.
- Cola limitada, no solapamiento, seis posiciones, owner oculto/cerrado, ventanas independientes, expiración, persistencia, hilo incorrecto, acción accesible y liberación GDI verificados.
- DLL final generada con `dotnet build .\src\KovaqsUI\KovaqsUI.csproj -c Release`: `src/KovaqsUI/bin/Release/net8.0-windows/KovaqsUI.dll`, versión 0.8.0.0. Se compiló y ejecutó un consumidor WinForms que la referencia como DLL, sin ProjectReference; slider, switch, fuentes y toasts funcionan.
- Logs y capturas quedan en `artifacts/essentials`, excluido de Git. La incidencia histórica intermitente de peso GDI de Outfit no apareció en esta ejecución; no se declara corregida.

Pendiente de comprobación física: arrastrar/guardar/reabrir los nuevos componentes en Visual Studio, lector de pantalla y cambio entre monitores reales al 100/125/150/200 %. Las capturas y mensajes DPI sintéticos no certifican esos escenarios ni miden parpadeo de pantalla. API y decisiones: [ESSENTIAL-CONTROLS.md](ESSENTIAL-CONTROLS.md).

Esta guía registra comprobaciones no cubiertas por la ejecución automática. Ninguna casilla implica aprobación por defecto. Anotar versión de Windows, versión del IDE, escala del monitor y resultado observado.

## Diseñador y Toolbox

Requisito: Visual Studio con soporte .NET 8 y carga de trabajo de desarrollo de escritorio .NET. La instalación actual se identifica como Visual Studio Community 2026 (18.10); falta completar la prueba directa del diseñador.

1. Abrir KovaqsUI.sln y compilar Release.
2. Crear una aplicación Windows Forms .NET 8 de prueba y agregar referencia al proyecto KovaqsUI.
3. Abrir Form1 en el diseñador. Confirmar KButton y KTextBox en Toolbox; si no aparecen automáticamente, registrar el resultado de Choose Items con la DLL compilada.
4. Arrastrar ambos controles. Verificar tamaño, selección, movimiento, alineación, Dock y Anchor, sin excepciones del diseñador.
5. Editar Appearance.Normal, Hover, Pressed, Focused y Disabled. Probar colores arbitrarios, GradientColor, GradientAngle y GradientMode.
6. Editar CornerRadius, Shape, BorderThickness, Font, Padding e Image/ImageList. En el campo, editar placeholder, multiline, contraseña e iconos.
7. Guardar, cerrar el diseñador y volverlo a abrir. Confirmar que persisten valores y que el editor interno no aparece duplicado.
8. Restablecer un color/ángulo desde Properties. Guardar y reabrir para verificar la recuperación de la herencia.
9. Ejecutar el formulario y comprobar que la apariencia coincide con lo configurado.

Resultado: **pendiente**. La prueba automática de DesignSurface/CodeDOM es complementaria y no sustituye estos pasos.

## DPI físico

1. Ejecutar la Demo con escala 100 %, 125 %, 150 % y 200 % en Windows; registrar DeviceDpi y capturas.
2. Revisar botones de 32/40/48, iconos, texto, bordes, foco y campos con fuente 10/13. Buscar recortes, doble escalado y desalineación.
3. Cambiar el tamaño de la ventana y comprobar scroll y contenido.
4. Si hay dos monitores con escalas distintas, mover la ventana entre ellos varias veces. Verificar que fuente, editor interno, imágenes y bordes cambian juntos y recuperan sus proporciones al volver.
5. Repetir con la ventana maximizada y con el campo enfocado.

Resultado: **pendiente**. Los mensajes WM_DPICHANGED sintéticos sólo verifican la ruta del formulario; los controles hijos siguen consultando el DPI físico.

## Edición y accesibilidad de extremo a extremo

1. En el campo de la Demo, probar Ctrl+A/C/X/V, menú contextual y Ctrl+Z con texto Unicode de prueba. Registrar selección y caret antes/después.
2. Con un IME instalado, componer y confirmar texto, cancelar composición y mover el caret; repetir en multilínea.
3. Con Narrador u otro lector de pantalla, recorrer con Tab/Shift+Tab. Confirmar nombre, rol, valor, readonly, contraseña y deshabilitado; activar el botón mediante su acción accesible.
4. Cambiar AccessibleName y AccessibleDescription durante ejecución y comprobar el anuncio actualizado.
5. Verificar Enter/Escape en un diálogo modal y la cancelación de Validating al salir del campo.

Resultado: **pendiente**. Las pruebas MSAA, WM_CHAR y de enlace de datos no equivalen a una sesión completa de lector de pantalla, IME o portapapeles.

## Registro

| Entorno y versión | Caso | Resultado observado | Evidencia | Incidencia |
|---|---|---|---|---|
| Pendiente | Toolbox/diseñador | Sin ejecutar | — | — |
| Pendiente | DPI físico | Sin ejecutar | — | — |
| Pendiente | Clipboard/IME/lector | Sin ejecutar | — | — |

Las diferencias visuales deliberadas están documentadas en README.md: KTextBox usa composición, su zona editable es sólida y KButton conserva el dibujo Kova al normalizar FlatStyle.System. No debe afirmarse compatibilidad visual idéntica con Button.


## Validación parcial en Visual Studio — 2026-09-27

Visual Studio Community 2026 abrió `DesignerSandbox.cs [Diseño]` con `actionButton` y `nameField`. El árbol accesible del IDE muestra el botón «Continuar» y un solo editor nativo bajo el campo. La lista de errores muestra cero errores y cero advertencias. El guardado mediante Ctrl+S quitó la marca de cambios y generó InitializeComponent en DesignerSandbox.Designer.cs. Se conservaron los ajustes hechos por el usuario en tamaño, posición y TabStop.

Toolbox muestra el grupo KovaqsUI con `KButton (KovaqsUI.Controls)` y `KTextBox (KovaqsUI.Controls)`. Esto verifica descubrimiento en el IDE. Aún no verifica inserción por arrastre, edición y reapertura de todas las propiedades anidadas. La captura gráfica del escritorio sigue fallando (`FrameArrived timed out`); la evidencia anterior procede del árbol de accesibilidad y de los archivos guardados, no de una inspección visual por captura.

Se corrigió el metadato predeterminado de KTextBox.TabStop a true, coincidiendo con el constructor. La prueba de TypeDescriptor verifica que Restablecer recupera true y sincroniza el editor interno. Suite actual: 160 comprobaciones aprobadas.

### Evidencia adicional del usuario

La captura `codex-clipboard-8a56b00e-e106-4865-a5af-041a50ca9a09.png` muestra Animation expandido (Duration 150, Easing Linear, Enabled True) y Appearance con estados y propiedades de degradado. Confirma que esas propiedades se pueden desplegar en el IDE; no prueba todavía su persistencia tras cerrar y reabrir.

El archivo DesignerSandbox.Designer.cs guardado contiene dos instancias adicionales, kButton1 y kTextBox1, con declaraciones, construcción, propiedades y Controls.Add. La solución con esas instancias compila en Release sin errores ni advertencias. Esto prueba que las instancias añadidas quedaron guardadas y son compilables; el gesto concreto de arrastre no fue observado. El archivo aún no contiene asignaciones Animation.Duration o Animation.Easing: queda pendiente comprobar un valor modificado y guardado, seguido de reapertura del diseñador.

### Guardado de propiedades anidadas confirmado

Tras la edición del usuario, DesignerSandbox.Designer.cs contiene `kButton1.Animation.Duration = 180`, `kButton1.Animation.Easing = Styling.KEasing.Linear` y `kButton1.Appearance.Normal.BorderColor = Color.Black`. Visual Studio muestra la pestaña sin cambios pendientes y Properties identifica kButton1 como KovaqsUI.Controls.KButton. La solución con ese código compila Release con cero errores y advertencias. Queda confirmado el guardado real desde Properties de Animation y Appearance; no sólo el despliegue de sus categorías.

Se cerró la pestaña de diseñador mediante Ctrl+F4 para probar recarga. La selección posterior del archivo falló con `coordinate input geometry is unavailable`, por lo que la reapertura todavía no se declara verificada. No se modificaron los valores elegidos por el usuario.

## Decisión del usuario

El usuario confirma haber realizado cambios y verificado el diseñador, y solicita omitir la automatización del IDE cuando no sea posible. Se acepta esta validación manual; los pasos pendientes de automatización no bloquean la ampliación solicitada. No se presentan como ejecutadas por el agente las comprobaciones que realizó el usuario.



## KSegmentedControl (0.6.0)

Validación automatizada: colección y selección, binding, Tab/Shift+Tab, handlers de teclado/mouse, RTL, accesibilidad, renderizado de estados, animación, fuentes y DPI sintético. DesignSurface/PropertyGrid y CodeDOM verifican la edición y persistencia de elementos y apariencias. La captura de la demo fue revisada visualmente.

Pendiente de validación interactiva (no equivalente a las pruebas automatizadas):

- Abrir DesignerSandbox en Visual Studio, agregar/quitar/reordenar Items, cambiar valores/estados y SelectedIndex; guardar, cerrar y reabrir sin errores.
- Probar la demo horizontal/vertical con teclado físico, Enter/Space, foco visible, captura de mouse, Tab y opciones deshabilitadas.
- Mover entre monitores reales al 100/125/150/200 %, revisar textos, esquinas, espacios y ausencia de parpadeo.
- Probar con lector de pantalla los nombres, selección, foco y opciones deshabilitadas.

Guía completa: [KSegmentedControl](SEGMENTED-CONTROL.md).

Resultado de esta entrega: compilación Release sin errores ni advertencias; 369 comprobaciones aprobadas, incluida la regresión existente; inicialización tipográfica en modo diseño aprobada en nueve controles; paquete local KovaqsUI.0.6.0 generado. Se usó `dotnet build KovaqsUI.sln -c Release --artifacts-path artifacts/verify` porque una instancia abierta de la demo bloqueaba su salida habitual. Las salidas y capturas permanecen en artifacts, excluido de Git.

## Numeric único y ComboBox

KNumericUpDown reemplaza la composición anterior de Cantidad. Se revisó la captura de la demo con tamaños normal y compacto; no contiene controles hijos. Se verificaron 16 comprobaciones específicas de valor, límites, input, RTL, accesibilidad, tamaños y round trip del diseñador. ComboBox añade cinco comprobaciones de repintado conservando texto, selección y popup en DropDownList/DropDown/Simple. Última ejecución completa: 400 comprobaciones aprobadas; compilación sin advertencias ni errores.

En una ejecución intermedia falló la comprobación existente de GDI para Outfit Medium (devolvió peso 400); al repetir la suite pasó. Se registra como incidencia tipográfica intermitente, sin atribuirla al Numeric ni afirmar que esta entrega la corrige. Confirmar manualmente la ausencia de parpadeo del ComboBox en el equipo del usuario, incluida apertura/cierre y hover con animaciones. Captura: artifacts/screenshots/numeric-combo.png (no versionada).

## Revisión KDataGridView 0.7.1

- Compilación Release con cero errores y cero advertencias, usando salida aislada `artifacts/grid-review`.
- Suite completa: 488 comprobaciones aprobadas; ejecución focalizada `--grid`: 78 comprobaciones de tabla y demo.
- Regresión de hover/fondo/texto, selección por celda, headers personalizados, restablecimiento de alturas, temas derivados, estilos nativos, badges estrechos e Inactivo, edición/copia, RTL, columnas congeladas y 10.000 filas virtuales.
- Serialización/restauración real de KDataGridView y KBadgeColumn con DesignSurface/CodeDOM.
- Demo ejecutada a 840×640, 1060×840 y 1280×900; se comprueban secciones sin superposición, botones dentro de sus barras, filtros, caracteres especiales, agregar registros, cambio de tema/densidad y validación de valores numéricos.
- Capturas revisadas: `artifacts/screenshots/grid-after.png`, `grid-dark.png` y `grid-small.png`. Son artefactos locales excluidos de Git.
- Pendiente de comprobación manual: diseñador Visual Studio interactivo, lectores de pantalla y cambio entre monitores físicos con diferente DPI. Las barras de desplazamiento conservan el aspecto nativo de Windows.

## Pulido de segmentos, botones y texto (0.7.2)

Compilación sin advertencias ni errores. Última suite completa: 519 comprobaciones aprobadas. La nueva ejecución `--polish` aporta 31 comprobaciones: predeterminados de foco sin serialización, posición intermedia de píldora horizontal/vertical, redirección, RTL, contenido, cancelación; origen de onda mediante evento Click de mouse y cancelación al desactivar/ocultar/deshabilitar; geometría de editor a tamaños extremos, edición directa de Multiline/Font, conservación de selección y HWND en normal, contraseña, readonly, multilínea, RTL y disabled. La regresión existente cubre binding, validación, teclado y estados del editor nativo.

Capturas revisadas de la demo segmentada y campos claros/oscuros: `artifacts/screenshots/segments-polish.png`, `fields-polish.png`, `fields-polish-dark-final.png`. El modo de captura principal ahora desactiva animaciones como los otros modos, evitando capturar transiciones parciales de tema; el runtime interactivo conserva las animaciones. Las pruebas de movimiento muestrean frames y posiciones, no solo propiedades finales.

Una primera ejecución completa encontró nuevamente el fallo intermitente existente de Outfit SemiBold/peso GDI 400; la siguiente suite completa pasó. Esta entrega no modifica el cargador de fuentes ni afirma resolver esa incidencia. La verificación interactiva del IDE y monitores físicos de distinto DPI sigue siendo manual.
