-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 29, 2017 at 02:25 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `blood_bank`
--

-- --------------------------------------------------------

--
-- Table structure for table `blood_inventory`
--

CREATE TABLE `blood_inventory` (
  `Blood_Group` varchar(20) NOT NULL,
  `Quantity` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `blood_inventory`
--

INSERT INTO `blood_inventory` (`Blood_Group`, `Quantity`) VALUES
('A+', 0),
('A-', 0),
('B+', 0),
('B-', 0),
('AB+', 0),
('AB-', 0),
('O+', 0),
('O-', 0);

-- --------------------------------------------------------

--
-- Table structure for table `donors`
--

CREATE TABLE `donors` (
  `ID` int(20) NOT NULL,
  `Name` varchar(70) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Age` int(20) NOT NULL,
  `Gender` varchar(70) NOT NULL,
  `Phone` varchar(70) NOT NULL,
  `Email` varchar(70) NOT NULL,
  `Blood_Group` varchar(70) NOT NULL,
  `Weight` int(70) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `donors`
--

INSERT INTO `donors` (`ID`, `Name`, `Address`, `Age`, `Gender`, `Phone`, `Email`, `Blood_Group`, `Weight`) VALUES
(1, 'Arefin', 'Dhaka', 21, 'Male', '01764431859', 'arefin@live.com', 'O+', 65),
(2, 'Asif', 'Dhaka', 21, 'Male', '0178234238', 'asif@gmail.com', 'B+', 57),
(3, 'Siam', 'Dhaka', 22, 'Male', '01674372382', 'siam@gmail.com', 'B+', 58);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `ID` int(20) NOT NULL,
  `Name` varchar(70) NOT NULL,
  `Password` varchar(70) NOT NULL,
  `Designation` varchar(100) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Phone` varchar(70) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Gender` varchar(70) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`ID`, `Name`, `Password`, `Designation`, `Address`, `Phone`, `Email`, `Gender`) VALUES
(101, 'Fahim', 'fahimAhmed', 'Admin', '', '', '', ''),
(102, 'Arefin', 'arefin', 'Admin', '', '', '', ''),
(1001, 'Alex', 'alex', 'Pathologist', '', '', '', ''),
(2001, 'Alice', 'alice', 'Nurse', '', '', '', ''),
(1002, 'Alif', 'alif', 'Pathologist', 'Dhaka', '01733223422', 'alif@gmail.com', 'Male'),
(8, 'Malek', 'malek', 'Pathologist', 'Noakhali', '0189217812', 'malek@gmail.com', 'Male'),
(7, 'Nasir', 'nasir', 'Nurse', 'Dhaka', '0193282213', 'nasir@gmail.com', 'Male');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
