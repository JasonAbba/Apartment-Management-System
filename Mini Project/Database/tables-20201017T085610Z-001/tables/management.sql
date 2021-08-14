-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 15, 2020 at 05:56 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `apartmentdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `management`
--

CREATE TABLE `management` (
  `M_ID` int(2) NOT NULL,
  `FIRST_NAME` varchar(50) NOT NULL,
  `LAST_NAME` varchar(50) NOT NULL,
  `GENDER` varchar(50) NOT NULL,
  `DESIGNATION` varchar(50) NOT NULL,
  `MOBILE_NO` varchar(50) NOT NULL,
  `EMAIL` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `management`
--

INSERT INTO `management` (`M_ID`, `FIRST_NAME`, `LAST_NAME`, `GENDER`, `DESIGNATION`, `MOBILE_NO`, `EMAIL`) VALUES
(1, 'DEEPAK', 'HARIDAS', 'MALE', 'ADMIN', '7204437728', 'dpk992000@gmail.com'),
(2, 'JASON', 'ABBA', 'MALE', 'SECRETARY', '6300516201', 'jasonabba1234@gmail.com'),
(3, 'KEERTHAN', 'K', 'MALE', 'TREASURER', '9980544505', 'samjabezkeerthan@gmail.com'),
(4, 'SIRI', 'IYER', 'FEMALE', 'MAINTENANCE', '9945574109', 'siri.iyer@gmail.com'),
(5, 'VISHAL', 'RAJPUT', 'MALE', 'SECURITY', '6785553009', 'vishalboss@gmail.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `management`
--
ALTER TABLE `management`
  ADD PRIMARY KEY (`M_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
