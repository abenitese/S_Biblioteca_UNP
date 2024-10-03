-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-10-2024 a las 17:04:01
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bibliotecaunp`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estudiantes`
--

CREATE TABLE `estudiantes` (
  `Cod_Estudiante` int(11) NOT NULL,
  `Nombre` varchar(100) DEFAULT NULL,
  `Carrera` varchar(50) DEFAULT NULL,
  `Año` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `estudiantes`
--

INSERT INTO `estudiantes` (`Cod_Estudiante`, `Nombre`, `Carrera`, `Año`) VALUES
(1, 'BENITES ESPINOZA', 'ING. INFORMATICA', 2020),
(2, 'JOSE CANSECO', 'ADMINISTRACION', 2024),
(3, 'PETER PARKER', 'FISICA', 2020),
(4, 'MARCO GARCIA', 'INDUSTRIAL', 2022),
(5, 'LUISA MERINO', 'EDUCACIÓN', 2021),
(8, 'MORAN ROSALES', 'FISICA', 2024);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `libros`
--

CREATE TABLE `libros` (
  `Cod_Libro` int(11) NOT NULL,
  `Titulo` varchar(100) DEFAULT NULL,
  `Autor` varchar(100) DEFAULT NULL,
  `ISBN` varchar(13) DEFAULT NULL,
  `Genero` varchar(50) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `libros`
--

INSERT INTO `libros` (`Cod_Libro`, `Titulo`, `Autor`, `ISBN`, `Genero`, `Estado`) VALUES
(1, 'La Metamorfosis', 'Franz Kafka', '1000000001086', 'Ficcion/Misterio', 1),
(2, 'Relatos', 'Jose Maria Arguedas', '9788490073988', 'Ficcion/Clasico', 0),
(4, 'Iniciación a la informática', 'Quinqueton, R', '842670320B', 'Informatica', 1),
(5, 'estructura de datos', 'Franz Kafka', '1000000001086', 'Ficcion/Misterio', 1),
(6, 'DERECHOS FUNDAMENTALES', 'GARCÍA TOMA, VICTOR AUTOR', '9786124049835', 'Derecho', 1),
(7, 'Manual de Seguridad Industrial en Plantas Químicas y Petroleras: fundamentos, Evaluación de Riesgo y', 'Storch de Gracia, J.M', '844812054X', 'Ingenieria', 1),
(8, 'Antes de nacer : fundamentos de embriología y anomalías congénitas', 'Moore, Keith L', '9788491100324', 'Embriologia humana', 1),
(9, 'Manual de investigación Clínica', 'Gordillo Moscoso, Antonio Augusto', '9786074482751', 'Medicina humana', 1),
(10, 'Introducción a la Econometría', 'Guillermina, Martín', '8489660190', 'Economia', 1),
(11, 'Psicología del aprendizaje : aplicaciones en la educación', 'Royer, James M', '9681809793', 'Psicologia', 1),
(12, 'METODOLOGÍA DE LA INVESTIGACIÓN', 'Hernández sampieri, Roberto', '9701036328', 'Diseño de investigación', 1),
(13, 'LA CALIDAD DE VIDA', 'Nussbaum, Martha C', '9681648986', 'Politica', 1),
(14, 'POLÍTICAS SOCIALES EN EL PERÚ: NUEVOS APORTES', 'Portocarrero S. Felipe', '9972603253', 'Politicas sociales', 1),
(15, 'Fundamentos de Informática: lógica, resolución de problemas, programas y computadoras', 'Tucker, Allen', '8448118758', 'Informatica', 1),
(16, 'Técnicas de la auditoría informática', 'Derren, Yann', '970150030X', 'Auditoria', 1),
(19, '100 años de soledad', 'mario vargas llosa', '10040677845', 'literatura peruana', 1),
(20, 'el principito', 'Anthony Sanit', '100234345', 'Fantasia', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `niveles`
--

CREATE TABLE `niveles` (
  `cod_nivel` int(11) NOT NULL,
  `nivel` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `niveles`
--

INSERT INTO `niveles` (`cod_nivel`, `nivel`) VALUES
(1, 'admin'),
(2, 'empleado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamos`
--

CREATE TABLE `prestamos` (
  `Cod_Prestamo` int(11) NOT NULL,
  `Cod_Estudiante` int(11) DEFAULT NULL,
  `Cod_Libro` int(11) DEFAULT NULL,
  `FechaPrestamo` datetime DEFAULT NULL,
  `FechaDevolucion` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `prestamos`
--

INSERT INTO `prestamos` (`Cod_Prestamo`, `Cod_Estudiante`, `Cod_Libro`, `FechaPrestamo`, `FechaDevolucion`) VALUES
(5, 1, 2, '2024-09-06 14:01:40', '2024-09-13 00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `cod_usuario` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `cod_nivel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`cod_usuario`, `usuario`, `password`, `cod_nivel`) VALUES
(1, 'alex', '1111', 1),
(2, 'pepito', '123', 2),
(5, 'marco', 'password01', 2);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `ver_libros`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `ver_libros` (
`Cod_Libro` int(11)
,`Titulo` varchar(100)
,`Autor` varchar(100)
,`ISBN` varchar(13)
,`Genero` varchar(50)
);

-- --------------------------------------------------------

--
-- Estructura para la vista `ver_libros`
--
DROP TABLE IF EXISTS `ver_libros`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ver_libros`  AS SELECT `libros`.`Cod_Libro` AS `Cod_Libro`, `libros`.`Titulo` AS `Titulo`, `libros`.`Autor` AS `Autor`, `libros`.`ISBN` AS `ISBN`, `libros`.`Genero` AS `Genero` FROM `libros` ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `estudiantes`
--
ALTER TABLE `estudiantes`
  ADD PRIMARY KEY (`Cod_Estudiante`);

--
-- Indices de la tabla `libros`
--
ALTER TABLE `libros`
  ADD PRIMARY KEY (`Cod_Libro`);

--
-- Indices de la tabla `niveles`
--
ALTER TABLE `niveles`
  ADD PRIMARY KEY (`cod_nivel`);

--
-- Indices de la tabla `prestamos`
--
ALTER TABLE `prestamos`
  ADD PRIMARY KEY (`Cod_Prestamo`),
  ADD KEY `Cod_Estudiante` (`Cod_Estudiante`),
  ADD KEY `Cod_Libro` (`Cod_Libro`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`cod_usuario`),
  ADD KEY `cod_nivel` (`cod_nivel`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `estudiantes`
--
ALTER TABLE `estudiantes`
  MODIFY `Cod_Estudiante` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `libros`
--
ALTER TABLE `libros`
  MODIFY `Cod_Libro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `niveles`
--
ALTER TABLE `niveles`
  MODIFY `cod_nivel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `prestamos`
--
ALTER TABLE `prestamos`
  MODIFY `Cod_Prestamo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `cod_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `prestamos`
--
ALTER TABLE `prestamos`
  ADD CONSTRAINT `prestamos_ibfk_1` FOREIGN KEY (`Cod_Estudiante`) REFERENCES `estudiantes` (`Cod_Estudiante`),
  ADD CONSTRAINT `prestamos_ibfk_2` FOREIGN KEY (`Cod_Libro`) REFERENCES `libros` (`Cod_Libro`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `fk_nivel` FOREIGN KEY (`cod_nivel`) REFERENCES `niveles` (`cod_nivel`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
