<div align="center">
  <img width=100% src="https://capsule-render.vercel.app/api?type=waving&height=100&color=B5EAD7&reversal=true" />
</div>

<h1 align="center">
  <a href="https://git.io/typing-svg"><img src="https://readme-typing-svg.herokuapp.com?font=Righteous&pause=500&color=2E7D32&size=35&center=true&vCenter=true&random=false&width=600&lines=Sistema+de+Reinscripci%C3%B3n+Acad%C3%A9mica" alt="Sistema de Reinscripción Académica" /></a>
</h1>
<p align="center"><b>Gestión de Materias y CRUD en C# Windows Forms | Universidad de Sonora</b></p>

<br>

<p><b>Creador y Modalidad</b></p>

* **Estudiante:** Natalia Valenzuela ([@NataliaVlza](https://github.com/NataliaVlza))
* **Institución:** Universidad de Sonora (UNISON) - Facultad Interdisciplinaria de Ingenierías
* **Modalidad:** Proyecto guiado y desarrollado en sesiones prácticas de laboratorio.
* **Contacto:** natalia.sanchezvlza@gmail.com
* **Ubicación:** Hermosillo, Sonora, México

<br>

<p><b><font size="4">Descripción del Proyecto</font></b></p>

<p>Aplicación de escritorio desarrollada en <b>C# (Windows Forms)</b> enfocada en la gestión interactiva de asignaturas y procesos de reinscripción académica. El proyecto implementa arquitectura orientada a objetos, manejo de controles visuales avanzados y persistencia de datos mediante operaciones <b>CRUD</b> conectadas a una base de datos relacional.</p>

<p><b>Funcionalidades y Requisitos Implementados:</b></p>

* **Ventana Principal:** Consulta interactiva con `DataGridView` y barra de herramientas (`ToolStrip`) para las acciones principales (*Obtener*, *Agregar*, *Editar*, *Eliminar*, *Salir*).
* **Control de Modales:** Formulario dinámico `AgregarEditar` para el alta y modificación con validación de campos en tiempo de ejecución.
* **Modelo `Materia`:** Clase con propiedades de `ID`, `NombreMateria`, `Tipo` (Obligatoria, Optativa, Eje Formación Común), `Horario` y `Calificacion`.
* **Validación de Horarios:** Lógica de negocio que impide la duplicidad de registros y el empalme de horarios en materias registradas.
* **Persistencia Directa:** Conexión y ejecución de consultas SQL para el almacenamiento e integridad de la información.

<br>

<p><b><font size="4">Imágenes del Proyecto</font></b></p>

<p><b>1. Ventana Principal</b><br>
Interfaz inicial del sistema integrada con un <code>DataGridView</code> y una barra de herramientas (<code>ToolStrip</code>) con accesos rápidos a las operaciones principales.</p>

![Ventana Principal](screenshots/ventana_principal.png)

<br>

<p><b>2. Formulario Agregar / Editar Materia</b><br>
Ventana modal encargada de capturar y validar los datos de la materia (ID, Nombre, Tipo, Horario y Calificación). Incluye lógica para evitar duplicidad o empalme de horarios.</p>

![Agregar Materia](screenshots/agregar_materia.png)

<br>

<p><b>3. Carga de Datos y Consulta</b><br>
Representación del flujo al ejecutar el método <b>Obtener</b>, realizando una petición a la base de datos para recuperar e imprimir la lista actualizada de asignaturas.</p>

![Obtener Materias](screenshots/obtener_materias.png)

<br>

<p><b>4. Confirmación de Eliminación</b><br>
Cuadro de diálogo de confirmación previa a eliminar un registro seleccionado de la base de datos, garantizando integridad y prevención de borrados accidentales.</p>

![Eliminar Materia](screenshots/eliminar_materia.png)

<br>

<p align="center"><sub>Créditos de componentes visuales: <a href="https://github.com/kyechan99/capsule-render/blob/main/docs/README_es.md">capsule-render</a> por @kyechan99 y <a href="https://github.com/denvercoder1">readme-typing-svg</a> por @DenverCoder1</sub></p>

<div align="center">
  <img width=100% src="https://capsule-render.vercel.app/api?type=waving&height=100&color=B5EAD7&section=footer" />
</div>
