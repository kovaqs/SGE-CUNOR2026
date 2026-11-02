-- Consultas de lectura. Ejecutar después de seleccionar la base del sistema.
SET @inicio = CAST(DATE_FORMAT(CURRENT_DATE, '%Y-%m-01') AS DATE);
SET @fin = DATE_ADD(@inicio, INTERVAL 1 MONTH);
SET @departamento = 0;

-- Resumen relacionado: empleados, historial, puestos y departamentos.
SELECT COALESCE(d.nombre, 'Sin asignar') AS departamento,
       e.estado, COUNT(*) AS empleados
FROM empleados e
LEFT JOIN historial_laboral h ON h.id_empleado = e.id_empleado
    AND h.fecha_inicio < @fin
    AND (h.fecha_fin IS NULL OR h.fecha_fin >= @fin)
LEFT JOIN puestos p ON p.id_puesto = h.id_puesto
LEFT JOIN departamentos d ON d.id_departamento = p.id_departamento
WHERE e.fecha_contratacion < @fin
  AND (@departamento = 0 OR p.id_departamento = @departamento)
GROUP BY d.id_departamento, d.nombre, e.estado
ORDER BY empleados DESC, departamento, e.estado;

-- Departamentos que reúnen al menos cinco empleados al cierre del mes.
SELECT d.nombre AS departamento, COUNT(*) AS empleados
FROM empleados e
JOIN historial_laboral h ON h.id_empleado = e.id_empleado
    AND h.fecha_inicio < @fin AND (h.fecha_fin IS NULL OR h.fecha_fin >= @fin)
JOIN puestos p ON p.id_puesto = h.id_puesto
JOIN departamentos d ON d.id_departamento = p.id_departamento
WHERE e.fecha_contratacion < @fin
  AND (@departamento = 0 OR p.id_departamento = @departamento)
GROUP BY d.id_departamento, d.nombre
HAVING COUNT(*) >= 5
ORDER BY empleados DESC, departamento;

-- Filtro original: se aplica una función sobre cada fecha.
EXPLAIN SELECT COUNT(*) FROM asistencias
WHERE DATE_FORMAT(fecha, '%Y-%m') = DATE_FORMAT(@inicio, '%Y-%m');

SELECT COUNT(*) AS cantidad_original FROM asistencias
WHERE DATE_FORMAT(fecha, '%Y-%m') = DATE_FORMAT(@inicio, '%Y-%m');

-- Filtro por rango: permite aprovechar el índice idx_asistencias_fecha_estado.
EXPLAIN SELECT COUNT(*) FROM asistencias
WHERE fecha >= @inicio AND fecha < @fin;

SELECT COUNT(*) AS cantidad_por_rango FROM asistencias
WHERE fecha >= @inicio AND fecha < @fin;

-- Comparar cantidades, tipo de acceso, clave y filas estimadas de ambos planes.
