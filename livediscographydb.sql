-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.21-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win32
-- HeidiSQL Versión:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para livediscography
CREATE DATABASE IF NOT EXISTS `livediscography` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `livediscography`;

-- Volcando datos para la tabla livediscography.albums: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `albums` DISABLE KEYS */;
INSERT INTO `albums` (`Title`, `ReleaseYear`, `ReleaseMonth`, `ReleaseDay`, `ReleaseCountry`, `RecordLabel`, `Genre`, `TotalMinLength`, `NumberOfTracks`, `AlbumArtist`) VALUES
	('Astroworld', 2018, 'October', 3, 'USA', 'Columbia/Grand Hustle', 'Trap', 58, 17, 'Travis Scott'),
	('Dime Trap', 2018, 'October', 5, 'USA', 'Columbia/Grand Hustle', 'Trap', 60, 15, 'T.I.'),
	('Neva Left ', 2018, 'May', 19, 'USA', 'Doggystyle Records', 'Gangsta Rap', 61, 16, 'Snoop Dogg'),
	('Luv Is Rage 2', 2017, 'August', 25, 'USA', 'Atlantic Records', 'Trap', 69, 16, 'Lil Uzi Vert'),
	('Life\'s a Trip', 2018, 'August', 10, 'USA', 'TenThousand Projects', 'Trap', 46, 14, 'Trippie Redd');
/*!40000 ALTER TABLE `albums` ENABLE KEYS */;

-- Volcando datos para la tabla livediscography.artists: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `artists` DISABLE KEYS */;
INSERT INTO `artists` (`Name`, `Genre`, `Labels`, `RealName`) VALUES
	('Travis Scott', 'Trap', 'Columbia/Grand Hustle', 'Jacques Berman Webster II'),
	('Snoop Dogg', 'Gangsta Rap', 'All The Time Entertainment', 'Calvin Cordozar Broadus Jr.'),
	('T.I.', 'Trap', 'Columbia/Grand Hustle', 'Clifford Joseph Harris Jr.'),
	('Trippie Redd', 'Trap', 'Universal Music Group', 'Michael Lamar White IV'),
	('Lil Uzi Vert', 'Trap', 'Atlantic Records', 'Symere Woods');
/*!40000 ALTER TABLE `artists` ENABLE KEYS */;

-- Volcando datos para la tabla livediscography.songs: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `songs` DISABLE KEYS */;
INSERT INTO `songs` (`Name`, `Album`, `Artist`, `Minlength`, `Seclength`, `Genre`) VALUES
	('We Alright', 'The Rise Of An Empire', 'Young Money', 5, 21, 'Gangsta Rap'),
	('Fukk Sleep ft. FKA twigs', 'Fukk Sleep (Single)', 'A$AP Rocky', NULL, NULL, NULL);
/*!40000 ALTER TABLE `songs` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
