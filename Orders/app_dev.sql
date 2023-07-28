-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 27, 2023 at 03:58 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `app_dev`
--

-- --------------------------------------------------------

--
-- Table structure for table `tborder`
--

CREATE TABLE `tborder` (
  `order_id` int(11) NOT NULL,
  `customer_name` varchar(120) NOT NULL,
  `product_name` varchar(120) NOT NULL,
  `qty` varchar(200) NOT NULL,
  `total` varchar(9) NOT NULL,
  `CreateAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tborder`
--

INSERT INTO `tborder` (`order_id`, `customer_name`, `product_name`, `qty`, `total`, `CreateAt`) VALUES
(7, 'Gwen Go', 'iPhone s3', '1', '35,000', '2023-07-27 13:56:22'),
(8, 'Dindi', 'Samsung', '2', '25,000', '2023-07-27 13:56:43');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tborder`
--
ALTER TABLE `tborder`
  ADD PRIMARY KEY (`order_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tborder`
--
ALTER TABLE `tborder`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
