# Base de Datos en Heidi

''' mysql

CREATE DATABASE IF NOT EXISTS AsistenciaUniversitaria;
USE AsistenciaUniversitaria;


CREATE TABLE TipoPersona (
    id_tipo_persona INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL
);


CREATE TABLE Persona (
    id_persona INT AUTO_INCREMENT PRIMARY KEY,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    documento VARCHAR(15) UNIQUE NOT NULL,
    correo VARCHAR(100),
    telefono VARCHAR(20),
    id_tipo_persona INT NOT NULL,
    FOREIGN KEY (id_tipo_persona) REFERENCES TipoPersona(id_tipo_persona)
        ON UPDATE CASCADE ON DELETE RESTRICT
);


CREATE TABLE Facultad (
    id_facultad INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL
);


CREATE TABLE ProgramaAcademico (
    id_programa INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(150) NOT NULL,
    tipo ENUM('Pregrado','Posgrado') NOT NULL,
    nivel ENUM('Carrera','Diplomado','Maestría','Doctorado') NOT NULL,
    id_facultad INT,
    FOREIGN KEY (id_facultad) REFERENCES Facultad(id_facultad)
        ON UPDATE CASCADE ON DELETE SET NULL
);


CREATE TABLE PersonaPrograma (
    id_persona_programa INT AUTO_INCREMENT PRIMARY KEY,
    id_persona INT NOT NULL,
    id_programa INT NOT NULL,
    ciclo INT, -- solo aplica a estudiantes de pregrado
    FOREIGN KEY (id_persona) REFERENCES Persona(id_persona)
        ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_programa) REFERENCES ProgramaAcademico(id_programa)
        ON UPDATE CASCADE ON DELETE CASCADE
);


CREATE TABLE Evento (
    id_evento INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(150) NOT NULL,
    descripcion VARCHAR(300),
    fecha_inicio DATETIME NOT NULL,
    fecha_fin DATETIME,
    lugar VARCHAR(150) DEFAULT 'Centro Cultural “TILSA TSUCHIYA CASTILLO”',
    tipo_evento VARCHAR(50), 
    id_facultad INT,
    FOREIGN KEY (id_facultad) REFERENCES Facultad(id_facultad)
        ON UPDATE CASCADE ON DELETE SET NULL
);



CREATE TABLE Asistencia (
    id_asistencia INT AUTO_INCREMENT PRIMARY KEY,
    id_evento INT NOT NULL,
    id_persona INT NOT NULL,
    fecha_registro DATETIME DEFAULT CURRENT_TIMESTAMP,
    estado ENUM('Asistió','No Asistió') DEFAULT 'Asistió',
    FOREIGN KEY (id_evento) REFERENCES Evento(id_evento)
        ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_persona) REFERENCES Persona(id_persona)
        ON UPDATE CASCADE ON DELETE CASCADE
);


CREATE TABLE UsuarioSistema (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) UNIQUE NOT NULL,
    clave VARCHAR(255) NOT NULL, -- Guardar encriptada (SHA2)
    rol ENUM('Administrador','Registrador','Consulta') DEFAULT 'Consulta',
    estado ENUM('Activo','Inactivo') DEFAULT 'Activo',
    fecha_creacion DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Tipos de persona
INSERT INTO TipoPersona (nombre) VALUES
('Estudiante'),
('Docente'),
('Administrativo'),
('Externo');

-- Facultades
INSERT INTO Facultad (nombre) VALUES
('Facultad de Ingeniería'),
('Facultad de Ciencias de la Salud'),
('Facultad de Ciencias Empresariales'),
('Facultad de Derecho');

-- Programas de pregrado
INSERT INTO ProgramaAcademico (nombre, tipo, nivel, id_facultad) VALUES
('Psicología', 'Pregrado', 'Carrera', 2),
('Contabilidad y Finanzas', 'Pregrado', 'Carrera', 3),
('Administración', 'Pregrado', 'Carrera', 3),
('Derecho y Ciencias Políticas', 'Pregrado', 'Carrera', 4),
('Obstetricia', 'Pregrado', 'Carrera', 2),
('Enfermería', 'Pregrado', 'Carrera', 2),
('Ingeniería Civil', 'Pregrado', 'Carrera', 1),
('Ingeniería Agrónoma', 'Pregrado', 'Carrera', 1),
('Ingeniería en Industrias Alimentarias', 'Pregrado', 'Carrera', 1),
('Ingeniería de Sistemas e Informática', 'Pregrado', 'Carrera', 1);

-- Programas de posgrado
INSERT INTO ProgramaAcademico (nombre, tipo, nivel, id_facultad) VALUES
('Diplomado en Seguridad y Salud en la Construcción', 'Posgrado', 'Diplomado', 1),
('Diplomado en Gestión e Innovación en Salud', 'Posgrado', 'Diplomado', 2),
('Maestría en Gestión Pública', 'Posgrado', 'Maestría', 3),
('Doctorado en Derecho', 'Posgrado', 'Doctorado', 4),
('Doctorado en Ciencias Contables y Empresariales', 'Posgrado', 'Doctorado', 3);

-- Personas
INSERT INTO Persona (nombres, apellidos, documento, correo, telefono, id_tipo_persona) VALUES
('Luis', 'Díaz Herrera', '70123456', 'ldiaz@unab.edu.pe', '987654321', 1),
('Carolay', 'Zamora Ruiz', '71234567', 'czamora@unab.edu.pe', '987654322', 1),
('María', 'Pérez García', '72345678', 'mperez@unab.edu.pe', '987654323', 2),
('Pedro', 'López Torres', '73456789', 'pedro.lopez@gmail.com', '987654324', 3),
('Ana', 'Rojas Medina', '74567890', 'anarojas@gmail.com', '987654325', 4);

-- Relación persona-programa
INSERT INTO PersonaPrograma (id_persona, id_programa, ciclo) VALUES
(1, 10, 4), 
(2, 10, 4),
(3, 7, NULL), 
(4, 8, NULL), 
(5, 3, NULL); 

-- Eventos
INSERT INTO Evento (nombre, descripcion, fecha_inicio, fecha_fin, tipo_evento, id_facultad)
VALUES
('Conferencia de Innovación Digital', 'Charla sobre transformación digital en educación', '2025-11-10 09:00:00', '2025-11-10 12:00:00', 'Conferencia', 1),
('Reunión de Coordinadores Académicos', 'Planificación del semestre 2025-II', '2025-11-15 10:00:00', '2025-11-15 12:00:00', 'Reunión', 2),
('Foro de Emprendimiento Universitario', 'Promoción de proyectos de innovación', '2025-11-20 09:00:00', '2025-11-20 14:00:00', 'Foro', 3);

-- Asistencia
INSERT INTO Asistencia (id_evento, id_persona, estado) VALUES
(1, 1, 'Asistió'),
(1, 2, 'Asistió'),
(2, 3, 'Asistió'),
(3, 4, 'No Asistió'),
(3, 5, 'Asistió');

-- Usuarios del sistema
INSERT INTO UsuarioSistema (usuario, clave, rol)
VALUES
('admin', SHA2('admin123', 256), 'Administrador'),
('registro1', SHA2('registro123', 256), 'Registrador');

'''