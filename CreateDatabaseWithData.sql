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

-- Volcando estructura para tabla livediscography.albums
CREATE TABLE IF NOT EXISTS `albums` (
  `Title` varchar(50) NOT NULL DEFAULT 'empty',
  `ReleaseYear` int(11) NOT NULL DEFAULT '0',
  `ReleaseMonth` varchar(50) NOT NULL DEFAULT 'empty',
  `ReleaseDay` int(11) NOT NULL DEFAULT '0',
  `ReleaseCountry` varchar(50) NOT NULL DEFAULT 'empty',
  `RecordLabel` varchar(50) NOT NULL DEFAULT 'empty',
  `Genre` varchar(50) NOT NULL DEFAULT 'empty',
  `TotalMinLength` int(11) NOT NULL DEFAULT '0',
  `NumberOfTracks` int(11) NOT NULL DEFAULT '0',
  `AlbumArtist` varchar(50) NOT NULL DEFAULT 'empty',
  PRIMARY KEY (`Title`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla livediscography.albums: ~7 rows (aproximadamente)
/*!40000 ALTER TABLE `albums` DISABLE KEYS */;
INSERT INTO `albums` (`Title`, `ReleaseYear`, `ReleaseMonth`, `ReleaseDay`, `ReleaseCountry`, `RecordLabel`, `Genre`, `TotalMinLength`, `NumberOfTracks`, `AlbumArtist`) VALUES
	('Astroworld', 2018, 'October', 3, 'USA', 'Columbia/Grand Hustle', 'Trap', 58, 17, 'Travis Scott'),
	('Dime Trap', 2018, 'October', 5, 'USA', 'Columbia/Grand Hustle', 'Trap', 60, 15, 'T.I.'),
	('Have A Nice Day', 2005, 'September', 20, 'USA', 'Universal', 'Hard Rock', 54, 15, 'Bon Jovi'),
	('Hybrid Theory', 2003, 'January', 12, 'USA', 'Warner', 'Nu Metal', 126, 13, 'Linkin Park'),
	('Life´s a Trip', 2018, 'August', 10, 'USA', 'TenThousand Projects', 'Trap', 46, 14, 'Trippie Redd'),
	('Luv Is Rage 2', 2017, 'August', 25, 'USA', 'Atlantic Records', 'Trap', 69, 16, 'Lil Uzi Vert'),
	('Neva Left ', 2018, 'May', 19, 'USA', 'Doggystyle Records', 'Gangsta Rap', 61, 16, 'Snoop Dogg');
/*!40000 ALTER TABLE `albums` ENABLE KEYS */;

-- Volcando estructura para tabla livediscography.artists
CREATE TABLE IF NOT EXISTS `artists` (
  `Name` varchar(50) NOT NULL DEFAULT 'empty',
  `Genre` varchar(50) NOT NULL DEFAULT 'empty',
  `Labels` varchar(50) NOT NULL DEFAULT 'empty',
  `RealName` varchar(50) NOT NULL DEFAULT 'empty',
  PRIMARY KEY (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='\r\n';

-- Volcando datos para la tabla livediscography.artists: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `artists` DISABLE KEYS */;
INSERT INTO `artists` (`Name`, `Genre`, `Labels`, `RealName`) VALUES
	('21 Savage', 'Trap', 'Epic Records', 'Shyjah Joseph'),
	('Bon Jovi', 'Hard Rock', 'Universal Music Group', 'Jon Bon Jovi'),
	('Cardi B', 'Trap', 'Atlantic Records', 'Belcalis Almánzar'),
	('Lil Uzi Vert', 'Trap', 'Atlantic Records', 'Symere Woods'),
	('Trippie Redd', 'Trap', 'Universal Music Group', 'Michael Lamar White IV');
/*!40000 ALTER TABLE `artists` ENABLE KEYS */;

-- Volcando estructura para tabla livediscography.songs
CREATE TABLE IF NOT EXISTS `songs` (
  `Name` varchar(50) NOT NULL DEFAULT 'empty',
  `Album` varchar(50) NOT NULL DEFAULT 'empty',
  `Artist` varchar(50) NOT NULL DEFAULT 'empty',
  `Minlength` int(11) NOT NULL DEFAULT '0',
  `Seclength` int(11) NOT NULL DEFAULT '0',
  `Genre` varchar(50) NOT NULL DEFAULT 'empty',
  PRIMARY KEY (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla livediscography.songs: ~7 rows (aproximadamente)
/*!40000 ALTER TABLE `songs` DISABLE KEYS */;
INSERT INTO `songs` (`Name`, `Album`, `Artist`, `Minlength`, `Seclength`, `Genre`) VALUES
	('Bartier Cardi (feat. 21 Savage)', 'Invasion Of Privacy', 'Cardi B', 3, 46, 'Trap'),
	('Black & Chinese', 'Huncho Jack', 'Huncho Jack', 2, 53, 'Trap'),
	('Bodak Yellow', 'Invasion Of Privacy', 'Cardi B', 3, 53, 'Trap'),
	('Fukk Sleep ft. FKA twigs', 'Fukk Sleep (Single)', 'A$AP Rocky', 3, 2, 'Trap'),
	('Houstonfornication', 'Astroworld', 'Travis Scott', 4, 23, 'Trap'),
	('Ric Flair Drip', 'Ric Flair Drip', '21 Savage, Offset, Metro Boomin', 3, 8, 'Trap'),
	('Rip Screw', 'Astroworld', 'Travis Scott', 2, 22, 'Trap'),
	('STARGAZING', 'Astroworld', 'Travis Scott', 4, 22, 'Trap'),
	('Stop Trying To Be God', 'Astroworld', 'Travis Scott', 3, 23, 'Trap'),
	('Upper Echelon', 'Upper Echelon', 'Travis Scott', 5, 20, 'Trap'),
	('We Alright', 'The Rise Of An Empire', 'Young Money', 5, 21, 'Gangsta Rap');
/*!40000 ALTER TABLE `songs` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
