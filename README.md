
## 🧩 PRODUCT BACKLOG (funcionalidades principales)

| Nº | Épica / Funcionalidad                    | Descripción general                                                      |
| -- | ---------------------------------------- | ------------------------------------------------------------------------ |
| 1  | Gestión de personas                      | Registrar, editar y listar personas (alumnos, docentes, externos, etc.). |
| 2  | Gestión de eventos                       | Crear, editar y consultar eventos universitarios.                        |
| 3  | Registro de asistencia                   | Permitir marcar asistencia (manual o con QR).                            |
| 4  | Reportes y estadísticas                  | Generar reportes de asistencia por evento, facultad o tipo de persona.   |
| 5  | Gestión de usuarios del sistema          | Administrar cuentas, roles y accesos.                                    |
| 6  | Interfaz de navegación y panel principal | Menú lateral, pantalla de inicio, diseño general.                        |
| 7  | Módulo de ayuda                          | Manual, contacto y soporte al usuario.                                   |

---

## 🏃‍♂️ SPRINT 1 — **Estructura base y gestión de personas**

**Duración sugerida:** 2 semanas
**Objetivo:** Tener lista la base de datos, el login, y la gestión de personas.

### Historias de Usuario

| ID  | Historia de Usuario                                                | Criterio de Aceptación                                      |
| --- | ------------------------------------------------------------------ | ----------------------------------------------------------- |
| HU1 | Como administrador, quiero iniciar sesión para acceder al sistema. | Puede iniciar sesión con usuario/clave de `UsuarioSistema`. |
| HU2 | Como administrador, quiero registrar nuevos tipos de personas.     | Se guarda correctamente en `TipoPersona`.                   |
| HU3 | Como registrador, quiero agregar personas con sus datos básicos.   | Se guarda en la tabla `Persona` y asocia con `TipoPersona`. |
| HU4 | Como registrador, quiero listar y buscar personas.                 | Puedo ver una lista filtrable por tipo o nombre.            |

### 🧰 Tareas

* [ ] Crear estructura de base de datos (script SQL).
* [ ] Conectar app con la base de datos (MySQL).
* [ ] Crear formulario de login.
* [ ] Crear módulo “Personas” (listar/agregar/editar/eliminar).
* [ ] Validar correos y DNI únicos.
* [ ] Diseño inicial de menú lateral e interfaz base (Inicio – Personas – Ajustes).
* Inicio: Nombre del evento, foto, descripción del evento, contador de asistentes a tiempor real.
* Marcar: verificar si la persona registrada asistió
* personas: Registrar y mostrar de participantes en el evento -> registrador
* lista: mostrar los participantes en el evento -> solo consultor
* Evento: Añadir Eventos a la base de datos y añadir imagen
* Ajustes: Nombre del evento, fotos, tamaño de fuente, descripcion del evento, cerrar sesión
* Ayuda: Texto e imágenes explicando el uso de la app
* reportes: Muestra el registro de varios eventos, descargar como pdf o como Excel, imprimir
* usuarios: Separar cuentas de registradores para un evento en especifico, 3 o 4 personas registrarán en un evento, eliminar usuarios
* Agregar una tabla tipo de evento

---

## 🏃‍♀️ SPRINT 2 — **Eventos y Asistencias**

**Duración:** 2 semanas
**Objetivo:** Poder registrar eventos y marcar asistencias.

### Historias de Usuario

| ID  | Historia de Usuario                                                | Criterio de Aceptación                        |
| --- | ------------------------------------------------------------------ | --------------------------------------------- |
| HU5 | Como administrador, quiero registrar eventos académicos.           | Se crea un evento con fecha, tipo y facultad. |
| HU6 | Como registrador, quiero marcar asistencia de una persona.         | Se guarda en `Asistencia` y evita duplicados. |
| HU7 | Como registrador, quiero ver la lista de asistencias de un evento. | Puedo ver quienes asistieron y quienes no.    |

### 🧰 Tareas

* [ ] Crear formulario de eventos (alta, edición, eliminación).
* [ ] Crear formulario para marcar asistencia (por QR o DNI).
* [ ] Crear vista “Lista” con filtro por evento.
* [ ] Mostrar nombre del evento, participantes y estado.
* [ ] Implementar validaciones (no duplicar asistencias).

---

## 🏃 SPRINT 3 — **Reportes y visualización**

**Duración:** 2 semanas
**Objetivo:** Mostrar y exportar reportes estadísticos de asistencia.

### Historias de Usuario

| ID   | Historia de Usuario                                                     | Criterio de Aceptación                    |
| ---- | ----------------------------------------------------------------------- | ----------------------------------------- |
| HU8  | Como administrador, quiero ver un resumen general de asistencia.        | Muestra totales por evento y porcentajes. |
| HU9  | Como registrador, quiero exportar reportes a PDF o Excel.               | Los archivos se generan correctamente.    |
| HU10 | Como administrador, quiero ver reportes por facultad o tipo de persona. | Reporte agrupado y filtrable.             |

### 🧰 Tareas

* [ ] Crear módulo “Reportes” con filtros.
* [ ] Mostrar gráficas (porcentaje de asistencia, barras).
* [ ] Implementar exportación a PDF/Excel.
* [ ] Agregar resumen al panel de Inicio.

---

## 🏁 SPRINT 4 — **Ajustes, roles y ayuda**

**Duración:** 1-2 semanas
**Objetivo:** Pulir configuraciones, seguridad y soporte.

### Historias de Usuario

| ID   | Historia de Usuario                                        | Criterio de Aceptación                 |
| ---- | ---------------------------------------------------------- | -------------------------------------- |
| HU11 | Como administrador, quiero gestionar usuarios del sistema. | Crear, activar o inactivar usuarios.   |
| HU12 | Como usuario, quiero cambiar mi contraseña.                | El cambio se guarda con hash SHA2.     |
| HU13 | Como usuario, quiero consultar la sección de ayuda.        | Acceso a manual y soporte del sistema. |

### 🧰 Tareas

* [ ] Crear formulario “Ajustes → Usuarios”.
* [ ] Permitir edición de contraseñas.
* [ ] Implementar control de roles (Administrador, Registrador, Consulta).
* [ ] Crear sección “Ayuda” con guía básica.
* [ ] Realizar pruebas y documentación final.