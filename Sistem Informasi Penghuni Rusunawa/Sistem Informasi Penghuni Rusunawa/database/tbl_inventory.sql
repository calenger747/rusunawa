-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 24, 2018 at 11:31 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_siap`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_inventory`
--

CREATE TABLE `tbl_inventory` (
  `id` int(11) NOT NULL,
  `nama_barang` text NOT NULL,
  `merk` text NOT NULL,
  `no_seri` text NOT NULL,
  `no_inventory` varchar(20) NOT NULL,
  `ukuran` text NOT NULL,
  `bahan` text NOT NULL,
  `tahun_pembuatan` year(4) NOT NULL,
  `jumlah_barang` varchar(10) NOT NULL,
  `kategori` text NOT NULL,
  `perolehan` text NOT NULL,
  `keadaan` text NOT NULL,
  `ruangan` text NOT NULL,
  `ket` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_inventory`
--

INSERT INTO `tbl_inventory` (`id`, `nama_barang`, `merk`, `no_seri`, `no_inventory`, `ukuran`, `bahan`, `tahun_pembuatan`, `jumlah_barang`, `kategori`, `perolehan`, `keadaan`, `ruangan`, `ket`) VALUES
(2, 'a', 'a', 'a', 'NE00002', 'a', 'a', 2011, '1', 'Non Elektronik', 'a', 'Kurang Baik', 'Ruang Kesekretariatan', 'a');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
