<img width="2125" height="575" alt="github-header-banner (4)" src="https://github.com/user-attachments/assets/1a6c46b0-0698-45a1-9dee-59171ca683e2" />

## Creador
* **Estudiante:** Natalia Valenzuela ([@NataliaVlza](https://github.com/NataliaVlza))
* **Institución:** Universidad de Sonora (UNISON)
* **Modalidad:** Proyecto guiado y desarrollado en sesiones prácticas de laboratorio.

## Descripción
Aplicación de escritorio en C# (Windows Forms) enfocada en la gestión de materias y procesos de reinscripción académica. El proyecto implementa arquitectura orientada a objetos en C#, manejo de controles visuales avanzados y persistencia de datos mediante operaciones CRUD conectadas a una base de datos relacional.

### Funcionalidades y requisitos implementados:
* **Ventana Principal:** Consulta interactiva con `DataGridView` y barra de herramientas (`ToolStrip`) para las acciones principales (*Obtener*, *Agregar*, *Editar*, *Eliminar*, *Salir*).
* **Control de Modales:** Formulario dinámico `AgregarEditar` para el alta y modificación con validación de campos.
* **Modelo `Materia`:** Clase con propiedades de `ID`, `NombreMateria`, `Tipo` (Obligatoria, Optativa, Eje Formación Común), `Horario` y `Calificacion`.
* **Validación de Horarios:** Lógica de negocio que impide el empalme de horarios en materias registradas.
* **Persistencia:** Conexión y operaciones directas en la base de datos SQL.

