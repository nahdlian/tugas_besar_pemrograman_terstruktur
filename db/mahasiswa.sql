-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 04, 2018 at 06:06 PM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mahasiswa`
--

-- --------------------------------------------------------

--
-- Table structure for table `db_mhs`
--

CREATE TABLE `db_mhs` (
  `nim` varchar(15) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `prodi` varchar(15) NOT NULL,
  `smstr` varchar(5) NOT NULL,
  `angkatan` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `db_mhs`
--

INSERT INTO `db_mhs` (`nim`, `nama`, `prodi`, `smstr`, `angkatan`) VALUES
('5160411', 'Angel', 'Akuntansi', '3', '2017'),
('5160415', 'Bagus', 'Informatika', '7', '2014'),
('5160412', 'Gilang', 'Manajemen', '3', '2017'),
('5160413', 'Danang', 'Informatika', '5', '2016');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
