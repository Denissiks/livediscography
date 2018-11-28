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

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla livediscography.artists
CREATE TABLE IF NOT EXISTS `artists` (
  `Name` varchar(50) NOT NULL DEFAULT 'empty',
  `Genre` varchar(50) NOT NULL DEFAULT 'empty',
  `Labels` varchar(50) NOT NULL DEFAULT 'empty',
  `RealName` varchar(50) NOT NULL DEFAULT 'empty',
  PRIMARY KEY (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='\r\n';

-- La exportación de datos fue deseleccionada.
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

-- La exportación de datos fue deseleccionada.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
