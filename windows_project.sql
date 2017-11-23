-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 23, 2017 at 05:13 AM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `windows_project`
--

-- --------------------------------------------------------

--
-- Table structure for table `actors`
--

DROP TABLE IF EXISTS `actors`;
CREATE TABLE IF NOT EXISTS `actors` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `fullname` varchar(100) DEFAULT NULL,
  `address` varchar(50) NOT NULL,
  `postal_code` varchar(50) NOT NULL,
  `city` varchar(50) NOT NULL,
  `nationality` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `actors`
--

INSERT INTO `actors` (`id`, `firstname`, `lastname`, `fullname`, `address`, `postal_code`, `city`, `nationality`) VALUES
(2, 'Jane', 'Smith', 'Jane Smith', '22. Jump Street', '10300', 'Washington DC', 'English'),
(3, 'John', 'Snow', 'John Snow', 'Test Street 2', '12300', 'Kansas', 'English'),
(4, 'Emmi', 'Snow', 'Emmi Snow', 'Test Street', '7050', 'Kuopio', 'Finnish');

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

DROP TABLE IF EXISTS `genres`;
CREATE TABLE IF NOT EXISTS `genres` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `genre` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `genres`
--

INSERT INTO `genres` (`id`, `genre`) VALUES
(1, 'Action'),
(2, 'Horror'),
(3, 'Comedy'),
(4, 'Documentary'),
(5, 'Drama'),
(6, 'XXX'),
(7, 'Musical'),
(11, 'Sci-Fi'),
(13, 'Jännitys'),
(15, 'Kids'),
(16, 'Comedy / Horror');

-- --------------------------------------------------------

--
-- Table structure for table `movies`
--

DROP TABLE IF EXISTS `movies`;
CREATE TABLE IF NOT EXISTS `movies` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `length` int(5) NOT NULL,
  `rating` int(5) NOT NULL,
  `budget` int(10) NOT NULL,
  `producer_id` int(10) UNSIGNED DEFAULT NULL,
  `genre_id` int(10) UNSIGNED DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `producer_id` (`producer_id`),
  KEY `genre_id` (`genre_id`),
  KEY `actor_id` (`producer_id`,`genre_id`)
) ENGINE=InnoDB AUTO_INCREMENT=112 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `movies`
--

INSERT INTO `movies` (`id`, `name`, `length`, `rating`, `budget`, `producer_id`, `genre_id`) VALUES
(2, 'Sinister 3', 145, 5, 800, 2, 1),
(3, 'Rescue John Snow', 102, 3, 200, 2, 6),
(4, 'Too funny movie', 120, 4, 50, 3, 3),
(107, 'Warcraft Movie', 100, 4, 100, 3, 11),
(109, 'Taru sormusten herrasta', 100, 4, 100, 2, 11),
(110, 'Test movie', 100, 2, 2, 2, 1),
(111, 'Another test movie', 100, 4, 2, 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `movies_actor`
--

DROP TABLE IF EXISTS `movies_actor`;
CREATE TABLE IF NOT EXISTS `movies_actor` (
  `actor_id` int(10) UNSIGNED NOT NULL,
  `movie_id` int(10) UNSIGNED NOT NULL,
  KEY `actor_id` (`actor_id`),
  KEY `movie_id` (`movie_id`),
  KEY `actor_id_2` (`actor_id`),
  KEY `movie_id_2` (`movie_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `movies_actor`
--

INSERT INTO `movies_actor` (`actor_id`, `movie_id`) VALUES
(2, 4),
(4, 4),
(3, 4),
(2, 107),
(3, 107),
(4, 107),
(2, 109),
(4, 109),
(2, 2),
(2, 111),
(3, 111),
(4, 111);

-- --------------------------------------------------------

--
-- Table structure for table `producers`
--

DROP TABLE IF EXISTS `producers`;
CREATE TABLE IF NOT EXISTS `producers` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `fullname` varchar(100) DEFAULT NULL,
  `address` varchar(50) NOT NULL,
  `postal_code` varchar(50) NOT NULL,
  `city` varchar(50) NOT NULL,
  `nationality` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `producers`
--

INSERT INTO `producers` (`id`, `firstname`, `lastname`, `fullname`, `address`, `postal_code`, `city`, `nationality`) VALUES
(2, 'Steven', 'Spilberg', 'Steven Spilberg', '33. Left Street', '30400', 'Las Vegas', 'Swedish'),
(3, 'Jason', 'Blum', 'Jason Blum', 'Diagon Alley', '12300', 'Los Angeles', 'English');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `movies`
--
ALTER TABLE `movies`
  ADD CONSTRAINT `movies_ibfk_2` FOREIGN KEY (`producer_id`) REFERENCES `producers` (`id`) ON DELETE SET NULL,
  ADD CONSTRAINT `movies_ibfk_3` FOREIGN KEY (`genre_id`) REFERENCES `genres` (`id`) ON DELETE SET NULL;

--
-- Constraints for table `movies_actor`
--
ALTER TABLE `movies_actor`
  ADD CONSTRAINT `movies_actor_ibfk_1` FOREIGN KEY (`actor_id`) REFERENCES `actors` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `movies_actor_ibfk_2` FOREIGN KEY (`movie_id`) REFERENCES `movies` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
