-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 21, 2019 at 08:00 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rusunawa`
--

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

CREATE TABLE `booking` (
  `kode_booking` varchar(20) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `unit` varchar(10) NOT NULL,
  `lantai` varchar(20) NOT NULL,
  `no_unit` int(30) NOT NULL,
  `harga` varchar(100) NOT NULL,
  `jumlah_penghuni` varchar(50) NOT NULL,
  `tgl_book` date NOT NULL,
  `tgl_masuk` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `booking`
--

INSERT INTO `booking` (`kode_booking`, `nama`, `unit`, `lantai`, `no_unit`, `harga`, `jumlah_penghuni`, `tgl_book`, `tgl_masuk`) VALUES
('B0001', 'Teguh', 'Unit A', 'Lantai 1', 1, 'Rp.250.000,00', '1 Orang', '2019-02-07', '2019-02-14'),
('B0002', 'Rozi', 'Unit B', 'Lantai 2', 1, 'Rp.250.000,00', '2 Orang', '2019-02-07', '2019-02-14'),
('B0003', 'Madhon', 'Unit B', 'Lantai 2', 10, 'Rp.225.000,00', '3 Orang', '2019-02-07', '2019-02-15'),
('B0004', 'Teguh', 'Unit B', 'Lantai 3', 17, 'Rp.200.000,00', '2 Orang', '2019-02-07', '2019-02-07'),
('B0007', 'yo', 'Unit C', 'Lantai 3', 3, 'Rp.200.000,00', '2 Orang', '2019-02-02', '2019-02-05');

-- --------------------------------------------------------

--
-- Table structure for table `booking_unit`
--

CREATE TABLE `booking_unit` (
  `kode_booking` varchar(16) NOT NULL,
  `tgl_booking` datetime NOT NULL,
  `nama` varchar(100) NOT NULL,
  `no_ktp` varchar(16) NOT NULL,
  `alamat` varchar(150) NOT NULL,
  `no_hp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `booking_unit`
--

INSERT INTO `booking_unit` (`kode_booking`, `tgl_booking`, `nama`, `no_ktp`, `alamat`, `no_hp`) VALUES
('BK20190304001', '2019-03-04 15:08:49', 'Cahyo Teguh Prasetyo', '3276903463728190', 'Jatijajar 1 Rt 003 Rw 002 Kel.jatijajar Kec.Tapos Kota Depok', '0895332345584'),
('BK20190304002', '2019-03-04 15:11:04', 'Zidan Barry Guntara', '3276012348765418', 'Jl.Anggur 1 ', '081324563879'),
('BK20190304003', '2019-03-04 15:12:06', 'M.Fakhrul Rozi', '327954920100201', 'JL.Pekapuran', '089611123331'),
('BK20190304004', '2019-03-04 15:12:55', 'Marcha Yolanda Utomo', '3272261518303037', 'Gg.Kenari 1', '08222435389300'),
('BK20190313005', '2019-03-13 11:05:52', 'Prasetyo dwi cipta', '320001', 'Cilodong', '089675611237'),
('BK20190313006', '2019-03-13 11:07:25', 'Ryzah Sativa', '3276016829302156', 'Pabuaran', '089611123331'),
('BK20190313007', '2019-03-13 11:13:05', 'cacacaca', '32456789', 'Jaktim', '087880918061'),
('BK20190314001', '2019-03-14 10:44:48', 'Prasetya', '32456788', 'Bekasi Timur', '0892335890'),
('BK20190314008', '2019-03-14 09:51:20', 'Ramadhan', '3210003456789', 'Jakarta Selatan', '08130002222'),
('BK20190314009', '2019-03-14 10:17:49', 'Bismillah', '32039367', 'Jakarta', '08952618'),
('BK20190314010', '2019-03-14 11:32:50', 'Barry Guntara', '342526279', 'Hubad', '07839209'),
('BK20190322011', '2019-03-22 09:05:04', 'Jatayu M', '32100673299017', 'Sumedang', '08967342517190'),
('BK20190322012', '2019-03-22 09:16:13', 'Rojang', '3276016829302156', 'Jakarta', '089675611237'),
('BK20190322013', '2019-03-22 10:13:36', 'Prasetyo Teguh', '3276018925678949', 'Jakarta ', '081342567839'),
('BK20190322014', '2019-03-22 11:05:39', 'Rozii', '3276016829302156', 'Tapos, Depok', '0895332345584'),
('BK20190322015', '2019-03-22 14:09:43', 'Teguh', '3276016829302156', 'Jakarta ', '089675611237'),
('BK20190516016', '2019-05-16 19:52:12', 'Ari Ariyanto', '3276100404000002', 'JL. Banjaran Pucung', '081389061742'),
('BK20190516017', '2019-05-16 19:55:56', 'Ari Ariyanto', '3276100404000002', 'JL. Banjaran Pucung', '081389061742'),
('BK20190516018', '2019-05-16 20:07:33', 'Amelia Sari', '317582902831881', 'JL. Pasar Kranggan', '081211697937'),
('BK20190516019', '2019-05-16 20:09:57', 'a', '213', 'aa', '213'),
('BK20190516020', '2019-05-16 20:10:33', 'as', 'a213', '123', '213'),
('BK20190516021', '2019-05-16 20:14:02', 'asda', '3423423', 'asd', '3424'),
('BK20190516022', '2019-05-16 20:16:58', 'sadd', '234234', '24242', '234234');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_gedung`
--

CREATE TABLE `tbl_gedung` (
  `kode_gedung` varchar(16) NOT NULL,
  `gedung` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_gedung`
--

INSERT INTO `tbl_gedung` (`kode_gedung`, `gedung`) VALUES
('G001', 'A'),
('G002', 'B'),
('G003', 'C');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_harga`
--

CREATE TABLE `tbl_harga` (
  `kode_harga` varchar(16) NOT NULL,
  `lantai` varchar(16) NOT NULL,
  `harga` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_harga`
--

INSERT INTO `tbl_harga` (`kode_harga`, `lantai`, `harga`) VALUES
('HR001', '01', '275.000'),
('HR002', '02', '250.000'),
('HR003', '03', '225.000'),
('HR004', '04', '200.000');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_kamar`
--

CREATE TABLE `tbl_kamar` (
  `kode_kamar` varchar(16) NOT NULL,
  `no_kamar` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_kamar`
--

INSERT INTO `tbl_kamar` (`kode_kamar`, `no_kamar`) VALUES
('K001', '01'),
('K002', '02'),
('K003', '03'),
('K004', '04'),
('K005', '05'),
('K006', '06'),
('K007', '07'),
('K008', '08'),
('K009', '09'),
('K010', '10'),
('K011', '11'),
('K012', '12'),
('K013', '13'),
('K014', '14'),
('K015', '15'),
('K016', '16'),
('K017', '17'),
('K018', '18'),
('K019', '19'),
('K020', '20'),
('K021', '21'),
('K022', '22'),
('K023', '23'),
('K024', '24');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_unit`
--

CREATE TABLE `tbl_unit` (
  `kode_unit` varchar(16) NOT NULL,
  `kode_gedung` varchar(16) NOT NULL,
  `kode_lantai` varchar(16) NOT NULL,
  `kode_kamar` varchar(16) NOT NULL,
  `status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tower_a`
--

CREATE TABLE `tower_a` (
  `kode` varchar(16) NOT NULL,
  `no_unit` varchar(20) NOT NULL,
  `lantai` varchar(10) NOT NULL,
  `harga` varchar(200) NOT NULL,
  `status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tower_a`
--

INSERT INTO `tower_a` (`kode`, `no_unit`, `lantai`, `harga`, `status`) VALUES
('TA001', '01', 'A1', 'Rp.275.000', 'Isi'),
('TA002', '02', 'A1', 'Rp.275.000', 'Kosong'),
('TA003', '03', 'A1', 'Rp.275.000', 'Booking'),
('TA004', '04', 'A1', 'Rp.275.000', 'Booking'),
('TA005', '05', 'A1', 'Rp.275.000', 'Isi'),
('TA006', '06', 'A1', 'Rp.275.000', 'Isi'),
('TA007', '07', 'A1', 'Rp.275.000', 'Isi'),
('TA008', '08', 'A1', 'Rp.275.000', 'Booking'),
('TA009', '09', 'A1', 'Rp.275.000', 'Isi'),
('TA010', '10', 'A1', 'Rp.275.000', 'Booking'),
('TA011', '11', 'A1', 'Rp.275.000', 'Isi'),
('TA012', '12', 'A1', 'Rp.275.000', 'Isi'),
('TA013', '13', 'A1', 'Rp.275.000', 'Isi'),
('TA014', '14', 'A1', 'Rp.275.000', 'Isi'),
('TA015', '15', 'A1', 'Rp.275.000', 'Isi'),
('TA016', '16', 'A1', 'Rp.275.000', 'Booking'),
('TA017', '17', 'A1', 'Rp.275.000', 'Booking'),
('TA018', '18', 'A1', 'Rp.275.000', 'Booking'),
('TA019', '19', 'A1', 'Rp.275.000', 'Booking'),
('TA020', '20', 'A1', 'Rp.275.000', 'Kosong'),
('TA021', '21', 'A1', 'Rp.275.000', 'Booking'),
('TA022', '22', 'A1', 'Rp.275.000', 'Isi'),
('TA023', '23', 'A1', 'Rp.275.000', 'Isi'),
('TA024', '24', 'A1', 'Rp.275.000', 'Isi'),
('TA025', '01', 'A2', 'Rp.250.000', 'Kosong'),
('TA026', '02', 'A2', 'Rp.250.000', 'Kosong'),
('TA027', '03', 'A2', 'Rp.250.000', 'Kosong'),
('TA028', '04', 'A2', 'Rp.250.000', 'Kosong'),
('TA029', '05', 'A2', 'Rp.250.000', 'Kosong'),
('TA030', '06', 'A2', 'Rp.250.000', 'Kosong'),
('TA031', '07', 'A2', 'Rp.250.000', 'Kosong'),
('TA032', '08', 'A2', 'Rp.250.000', 'Kosong'),
('TA033', '09', 'A2', 'Rp.250.000', 'Kosong'),
('TA034', '10', 'A2', 'Rp.250.000', 'Kosong'),
('TA035', '11', 'A2', 'Rp.250.000', 'Kosong'),
('TA036', '12', 'A2', 'Rp.250.000', 'Kosong'),
('TA037', '13', 'A2', 'Rp.250.000', 'Kosong'),
('TA038', '14', 'A2', 'Rp.250.000', 'Kosong'),
('TA039', '15', 'A2', 'Rp.250.000', 'Kosong'),
('TA040', '16', 'A2', 'Rp.250.000', 'Kosong'),
('TA041', '17', 'A2', 'Rp.250.000', 'Kosong'),
('TA042', '18', 'A2', 'Rp.250.000', 'Booking'),
('TA043', '19', 'A2', 'Rp.250.000', 'Kosong'),
('TA044', '20', 'A2', 'Rp.250.000', 'Booking'),
('TA045', '21', 'A2', 'Rp.250.000', 'Kosong'),
('TA046', '22', 'A2', 'Rp.250.000', 'Kosong'),
('TA047', '23', 'A2', 'Rp.250.000', 'Kosong'),
('TA048', '24', 'A2', 'Rp.250.000', 'Booking'),
('TA049', '01', 'A3', 'Rp.225.000', 'Kosong'),
('TA050', '02', 'A3', 'Rp.225.000', 'Kosong'),
('TA051', '03', 'A3', 'Rp.225.000', 'Kosong'),
('TA052', '04', 'A3', 'Rp.225.000', 'Kosong'),
('TA053', '05', 'A3', 'Rp.225.000', 'Kosong'),
('TA054', '06', 'A3', 'Rp.225.000', 'Kosong'),
('TA055', '07', 'A3', 'Rp.225.000', 'Kosong'),
('TA056', '08', 'A3', 'Rp.225.000', 'Kosong'),
('TA057', '09', 'A3', 'Rp.225.000', 'Kosong'),
('TA058', '10', 'A3', 'Rp.225.000', 'Kosong'),
('TA059', '11', 'A3', 'Rp.225.000', 'Kosong'),
('TA060', '12', 'A3', 'Rp.225.000', 'Kosong'),
('TA061', '13', 'A3', 'Rp.225.000', 'Kosong'),
('TA062', '14', 'A3', 'Rp.225.000', 'Kosong'),
('TA063', '15', 'A3', 'Rp.225.000', 'Kosong'),
('TA064', '16', 'A3', 'Rp.225.000', 'Kosong'),
('TA065', '17', 'A3', 'Rp.225.000', 'Kosong'),
('TA066', '18', 'A3', 'Rp.225.000', 'Kosong'),
('TA067', '19', 'A3', 'Rp.225.000', 'Kosong'),
('TA068', '20', 'A3', 'Rp.225.000', 'Kosong'),
('TA069', '21', 'A3', 'Rp.225.000', 'Kosong'),
('TA070', '22', 'A3', 'Rp.225.000', 'Kosong'),
('TA071', '23', 'A3', 'Rp.225.000', 'Kosong'),
('TA072', '24', 'A3', 'Rp.225.000', 'Kosong'),
('TA073', '01', 'A4', 'Rp.200.000', 'Booking'),
('TA074', '02', 'A4', 'Rp.200.000', 'Booking'),
('TA075', '03', 'A4', 'Rp.200.000', 'Kosong'),
('TA076', '04', 'A4', 'Rp.200.000', 'Kosong'),
('TA077', '05', 'A4', 'Rp.200.000', 'Kosong'),
('TA078', '06', 'A4', 'Rp.200.000', 'Booking'),
('TA079', '07', 'A4', 'Rp.200.000', 'Kosong'),
('TA080', '08', 'A4', 'Rp.200.000', 'Kosong'),
('TA081', '09', 'A4', 'Rp.200.000', 'Kosong'),
('TA082', '10', 'A4', 'Rp.200.000', 'Kosong'),
('TA083', '11', 'A4', 'Rp.200.000', 'Kosong'),
('TA084', '12', 'A4', 'Rp.200.000', 'Kosong'),
('TA085', '13', 'A4', 'Rp.200.000', 'Kosong'),
('TA086', '14', 'A4', 'Rp.200.000', 'Kosong'),
('TA087', '15', 'A4', 'Rp.200.000', 'Kosong'),
('TA088', '16', 'A4', 'Rp.200.000', 'Kosong'),
('TA089', '17', 'A4', 'Rp.200.000', 'Kosong'),
('TA090', '18', 'A4', 'Rp.200.000', 'Kosong'),
('TA091', '19', 'A4', 'Rp.200.000', 'Kosong'),
('TA092', '20', 'A4', 'Rp.200.000', 'Kosong'),
('TA093', '21', 'A4', 'Rp.200.000', 'Kosong'),
('TA094', '22', 'A4', 'Rp.200.000', 'Kosong'),
('TA095', '23', 'A4', 'Rp.200.000', 'Booking'),
('TA096', '24', 'A4', 'Rp.200.000', 'Kosong');

-- --------------------------------------------------------

--
-- Table structure for table `tower_b`
--

CREATE TABLE `tower_b` (
  `kode` varchar(16) NOT NULL,
  `no_unit` varchar(16) NOT NULL,
  `lantai` varchar(16) NOT NULL,
  `harga` varchar(200) NOT NULL,
  `status` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tower_b`
--

INSERT INTO `tower_b` (`kode`, `no_unit`, `lantai`, `harga`, `status`) VALUES
('TB001', '01', 'B1', 'Rp.275.000', 'Isi'),
('TB002', '02', 'B1', 'Rp.275.000', 'Kosong'),
('TB003', '03', 'B1', 'Rp.275.000', 'Kosong'),
('TB004', '04', 'B1', 'Rp.275.000', 'Kosong'),
('TB005', '05', 'B1', 'Rp.275.000', 'Kosong'),
('TB006', '06', 'B1', 'Rp.275.000', 'Kosong'),
('TB007', '07', 'B1', 'Rp.275.000', 'Kosong'),
('TB008', '08', 'B1', 'Rp.275.000', 'Kosong'),
('TB009', '09', 'B1', 'Rp.275.000', 'Kosong'),
('TB010', '10', 'B1', 'Rp.275.000', 'Kosong'),
('TB011', '11', 'B1', 'Rp.275.000', 'Kosong'),
('TB012', '12', 'B1', 'Rp.275.000', 'Kosong'),
('TB013', '13', 'B1', 'Rp.275.000', 'Kosong'),
('TB014', '14', 'B1', 'Rp.275.000', 'Kosong'),
('TB015', '15', 'B1', 'Rp.275.000', 'Kosong'),
('TB016', '16', 'B1', 'Rp.275.000', 'Kosong'),
('TB017', '17', 'B1', 'Rp.275.000', 'Kosong'),
('TB018', '18', 'B1', 'Rp.275.000', 'Kosong'),
('TB019', '19', 'B1', 'Rp.275.000', 'Kosong'),
('TB020', '20', 'B1', 'Rp.275.000', 'Kosong'),
('TB021', '21', 'B1', 'Rp.275.000', 'Kosong'),
('TB022', '22', 'B1', 'Rp.275.000', 'Kosong'),
('TB023', '23', 'B1', 'Rp.275.000', 'Kosong'),
('TB024', '24', 'B1', 'Rp.275.000', 'Kosong'),
('TB025', '01', 'B2', 'Rp.250.000', 'Kosong'),
('TB026', '02', 'B2', 'Rp.250.000', 'Kosong'),
('TB027', '03', 'B2', 'Rp.250.000', 'Kosong'),
('TB028', '04', 'B2', 'Rp.250.000', 'Kosong'),
('TB029', '05', 'B2', 'Rp.250.000', 'Kosong'),
('TB030', '06', 'B2', 'Rp.250.000', 'Kosong'),
('TB031', '07', 'B2', 'Rp.250.000', 'Kosong'),
('TB032', '08', 'B2', 'Rp.250.000', 'Kosong'),
('TB033', '09', 'B2', 'Rp.250.000', 'Kosong'),
('TB034', '10', 'B2', 'Rp.250.000', 'Kosong'),
('TB035', '11', 'B2', 'Rp.250.000', 'Kosong'),
('TB036', '12', 'B2', 'Rp.250.000', 'Kosong'),
('TB037', '13', 'B2', 'Rp.250.000', 'Kosong'),
('TB038', '14', 'B2', 'Rp.250.000', 'Kosong'),
('TB039', '15', 'B2', 'Rp.250.000', 'Kosong'),
('TB040', '16', 'B2', 'Rp.250.000', 'Kosong'),
('TB041', '17', 'B2', 'Rp.250.000', 'Kosong'),
('TB042', '18', 'B2', 'Rp.250.000', 'Kosong'),
('TB043', '19', 'B2', 'Rp.250.000', 'Kosong'),
('TB044', '20', 'B2', 'Rp.250.000', 'Kosong'),
('TB045', '21', 'B2', 'Rp.250.000', 'Kosong'),
('TB046', '22', 'B2', 'Rp.250.000', 'Kosong'),
('TB047', '23', 'B2', 'Rp.250.000', 'Kosong'),
('TB048', '24', 'B2', 'Rp.250.000', 'Kosong'),
('TB049', '01', 'B3', 'Rp.225.000', 'Kosong'),
('TB050', '02', 'B3', 'Rp.225.000', 'Kosong'),
('TB051', '03', 'B3', 'Rp.225.000', 'Kosong'),
('TB052', '04', 'B3', 'Rp.225.000', 'Kosong'),
('TB053', '04', 'B3', 'Rp.225.000', 'Kosong'),
('TB054', '06', 'B3', 'Rp.225.000', 'Kosong'),
('TB055', '07', 'B3', 'Rp.225.000', 'Kosong'),
('TB056', '08', 'B3', 'Rp.225.000', 'Kosong'),
('TB057', '09', 'B3', 'Rp.225.000', 'Kosong'),
('TB058', '10', 'B3', 'Rp.225.000', 'Kosong'),
('TB059', '11', 'B3', 'Rp.225.000', 'Kosong'),
('TB060', '12', 'B3', 'Rp.225.000', 'Kosong'),
('TB061', '13', 'B3', 'Rp.225.000', 'Kosong'),
('TB062', '14', 'B3', 'Rp.225.000', 'Kosong'),
('TB063', '15', 'B3', 'Rp.225.000', 'Kosong'),
('TB064', '16', 'B3', 'Rp.225.000', 'Kosong'),
('TB065', '17', 'B3', 'Rp.225.000', 'Kosong'),
('TB066', '18', 'B3', 'Rp.225.000', 'Kosong'),
('TB067', '19', 'B3', 'Rp.225.000', 'Kosong'),
('TB068', '20', 'B3', 'Rp.225.000', 'Kosong'),
('TB069', '21', 'B3', 'Rp.225.000', 'Kosong'),
('TB070', '22', 'B3', 'Rp.225.000', 'Kosong'),
('TB071', '23', 'B3', 'Rp.225.000', 'Kosong'),
('TB072', '24', 'B3', 'Rp.225.000', 'Kosong'),
('TB073', '01', 'B4', 'Rp.200.000', 'Kosong'),
('TB074', '02', 'B4', 'Rp.200.000', 'Kosong'),
('TB075', '03', 'B4', 'Rp.200.000', 'Kosong'),
('TB076', '04', 'B4', 'Rp.200.000', 'Kosong'),
('TB077', '05', 'B4', 'Rp.200.000', 'Kosong'),
('TB078', '06', 'B4', 'Rp.200.000', 'Kosong'),
('TB079', '07', 'B4', 'Rp.200.000', 'Kosong'),
('TB080', '08', 'B4', 'Rp.200.000', 'Kosong'),
('TB081', '09', 'B4', 'Rp.200.000', 'Kosong'),
('TB082', '10', 'B4', 'Rp.200.000', 'Kosong'),
('TB083', '11', 'B4', 'Rp.200.000', 'Kosong'),
('TB084', '12', 'B4', 'Rp.200.000', 'Kosong'),
('TB085', '13', 'B4', 'Rp.200.000', 'Kosong'),
('TB086', '14', 'B4', 'Rp.200.000', 'Kosong'),
('TB087', '15', 'B4', 'Rp.200.000', 'Kosong'),
('TB088', '16', 'B4', 'Rp.200.000', 'Kosong'),
('TB089', '17', 'B4', 'Rp.200.000', 'Kosong'),
('TB090', '18', 'B4', 'Rp.200.000', 'Kosong'),
('TB091', '19', 'B4', 'Rp.200.000', 'Kosong'),
('TB092', '20', 'B4', 'Rp.200.000', 'Kosong'),
('TB093', '21', 'B4', 'Rp.200.000', 'Kosong'),
('TB094', '22', 'B4', 'Rp.200.000', 'Kosong'),
('TB095', '23', 'B4', 'Rp.200.000', 'Kosong'),
('TB096', '24', 'B4', 'Rp.200.000', 'Kosong');

-- --------------------------------------------------------

--
-- Table structure for table `tower_c`
--

CREATE TABLE `tower_c` (
  `kode` varchar(16) NOT NULL,
  `no_unit` varchar(16) NOT NULL,
  `lantai` varchar(16) NOT NULL,
  `harga` varchar(200) NOT NULL,
  `status` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tower_c`
--

INSERT INTO `tower_c` (`kode`, `no_unit`, `lantai`, `harga`, `status`) VALUES
('TC001', '01', 'C1', 'Rp.275.000', 'Isi'),
('TC002', '02', 'C1', 'Rp.275.000', 'Kosong'),
('TC003', '03', 'C1', 'Rp.275.000', 'Kosong'),
('TC004', '04', 'C1', 'Rp.275.000', 'Kosong'),
('TC005', '05', 'C1', 'Rp.275.000', 'Kosong'),
('TC006', '06', 'C1', 'Rp.275.000', 'Kosong'),
('TC007', '07', 'C1', 'Rp.275.000', 'Kosong'),
('TC008', '08', 'C1', 'Rp.275.000', 'Kosong'),
('TC009', '09', 'C1', 'Rp.275.000', 'Kosong'),
('TC010', '10', 'C1', 'Rp.275.000', 'Kosong'),
('TC011', '11', 'C1', 'Rp.275.000', 'Kosong'),
('TC012', '12', 'C1', 'Rp.275.000', 'Kosong'),
('TC013', '13', 'C1', 'Rp.275.000', 'Kosong'),
('TC014', '14', 'C1', 'Rp.275.000', 'Kosong'),
('TC015', '15', 'C1', 'Rp.275.000', 'Kosong'),
('TC016', '16', 'C1', 'Rp.275.000', 'Kosong'),
('TC017', '17', 'C1', 'Rp.275.000', 'Kosong'),
('TC018', '18', 'C1', 'Rp.275.000', 'Kosong'),
('TC019', '19', 'C1', 'Rp.275.000', 'Kosong'),
('TC020', '20', 'C1', 'Rp.275.000', 'Kosong'),
('TC021', '21', 'C1', 'Rp.275.000', 'Kosong'),
('TC022', '22', 'C1', 'Rp.275.000', 'Kosong'),
('TC023', '23', 'C1', 'Rp.275.000', 'Kosong'),
('TC024', '24', 'C1', 'Rp.275.000', 'Kosong'),
('TC025', '01', 'C2', 'Rp.250.000', 'Kosong'),
('TC026', '02', 'C2', 'Rp.250.000', 'Kosong'),
('TC027', '03', 'C2', 'Rp.250.000', 'Kosong'),
('TC028', '04', 'C2', 'Rp.250.000', 'Kosong'),
('TC029', '05', 'C2', 'Rp.250.000', 'Kosong'),
('TC030', '06', 'C2', 'Rp.250.000', 'Kosong'),
('TC031', '07', 'C2', 'Rp.250.000', 'Kosong'),
('TC032', '08', 'C2', 'Rp.250.000', 'Kosong'),
('TC033', '09', 'C2', 'Rp.250.000', 'Kosong'),
('TC034', '10', 'C2', 'Rp.250.000', 'Kosong'),
('TC035', '11', 'C2', 'Rp.250.000', 'Kosong'),
('TC036', '12', 'C2', 'Rp.250.000', 'Kosong'),
('TC037', '13', 'C2', 'Rp.250.000', 'Kosong'),
('TC038', '14', 'C2', 'Rp.250.000', 'Kosong'),
('TC039', '15', 'C2', 'Rp.250.000', 'Kosong'),
('TC040', '16', 'C2', 'Rp.250.000', 'Kosong'),
('TC041', '17', 'C2', 'Rp.250.000', 'Kosong'),
('TC042', '18', 'C2', 'Rp.250.000', 'Kosong'),
('TC043', '19', 'C2', 'Rp.250.000', 'Kosong'),
('TC044', '20', 'C2', 'Rp.250.000', 'Kosong'),
('TC045', '21', 'C2', 'Rp.250.000', 'Kosong'),
('TC046', '22', 'C2', 'Rp.250.000', 'Kosong'),
('TC047', '23', 'C2', 'Rp.250.000', 'Kosong'),
('TC048', '24', 'C2', 'Rp.250.000', 'Kosong'),
('TC049', '01', 'C3', 'Rp.225.000', 'Kosong'),
('TC050', '02', 'C3', 'Rp.225.000', 'Kosong'),
('TC051', '03', 'C3', 'Rp.225.000', 'Kosong'),
('TC052', '04', 'C3', 'Rp.225.000', 'Kosong'),
('TC053', '05', 'C3', 'Rp.225.000', 'Kosong'),
('TC054', '06', 'C3', 'Rp.225.000', 'Kosong'),
('TC055', '07', 'C3', 'Rp.225.000', 'Kosong'),
('TC056', '08', 'C3', 'Rp.225.000', 'Kosong'),
('TC057', '09', 'C3', 'Rp.225.000', 'Kosong'),
('TC058', '10', 'C3', 'Rp.225.000', 'Kosong'),
('TC059', '11', 'C3', 'Rp.225.000', 'Kosong'),
('TC060', '12', 'C3', 'Rp.225.000', 'Kosong'),
('TC061', '13', 'C3', 'Rp.225.000', 'Kosong'),
('TC062', '14', 'C3', 'Rp.225.000', 'Kosong'),
('TC063', '15', 'C3', 'Rp.225.000', 'Kosong'),
('TC064', '16', 'C3', 'Rp.225.000', 'Kosong'),
('TC065', '17', 'C3', 'Rp.225.000', 'Kosong'),
('TC066', '18', 'C3', 'Rp.225.000', 'Kosong'),
('TC067', '19', 'C3', 'Rp.225.000', 'Kosong'),
('TC068', '20', 'C3', 'Rp.225.000', 'Kosong'),
('TC069', '21', 'C3', 'Rp.225.000', 'Kosong'),
('TC070', '22', 'C3', 'Rp.225.000', 'Kosong'),
('TC071', '23', 'C3', 'Rp.225.000', 'Kosong'),
('TC072', '24', 'C3', 'Rp.225.000', 'Kosong'),
('TC073', '01', 'C4', 'Rp.200.000', 'Kosong'),
('TC074', '02', 'C4', 'Rp.200.000', 'Kosong'),
('TC075', '03', 'C4', 'Rp.200.000', 'Kosong'),
('TC076', '04', 'C4', 'Rp.200.000', 'Kosong'),
('TC077', '05', 'C4', 'Rp.200.000', 'Kosong'),
('TC078', '06', 'C4', 'Rp.200.000', 'Kosong'),
('TC079', '07', 'C4', 'Rp.200.000', 'Kosong'),
('TC080', '08', 'C4', 'Rp.200.000', 'Kosong'),
('TC081', '09', 'C4', 'Rp.200.000', 'Kosong'),
('TC082', '10', 'C4', 'Rp.200.000', 'Kosong'),
('TC083', '11', 'C4', 'Rp.200.000', 'Kosong'),
('TC084', '12', 'C4', 'Rp.200.000', 'Kosong'),
('TC085', '13', 'C4', 'Rp.200.000', 'Kosong'),
('TC086', '14', 'C4', 'Rp.200.000', 'Kosong'),
('TC087', '15', 'C4', 'Rp.200.000', 'Kosong'),
('TC088', '16', 'C4', 'Rp.200.000', 'Kosong'),
('TC089', '17', 'C4', 'Rp.200.000', 'Kosong'),
('TC090', '18', 'C4', 'Rp.200.000', 'Kosong'),
('TC091', '19', 'C4', 'Rp.200.000', 'Kosong'),
('TC092', '20', 'C4', 'Rp.200.000', 'Kosong'),
('TC093', '21', 'C4', 'Rp.200.000', 'Kosong'),
('TC094', '22', 'C4', 'Rp.200.000', 'Kosong'),
('TC095', '23', 'C4', 'Rp.200.000', 'Kosong'),
('TC096', '24', 'C4', 'Rp.200.000', 'Kosong');

-- --------------------------------------------------------

--
-- Table structure for table `update_berita`
--

CREATE TABLE `update_berita` (
  `kode_berita` varchar(10) NOT NULL,
  `judul_berita` text NOT NULL,
  `gambar` text NOT NULL,
  `deskripsi` varchar(400) NOT NULL,
  `tanggal` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `update_berita`
--

INSERT INTO `update_berita` (`kode_berita`, `judul_berita`, `gambar`, `deskripsi`, `tanggal`) VALUES
('BR001', 'Berita Pertama', 'i.jpg', '<p>asdad</p>\r\n', '2019-05-16 22:08:19'),
('BR002', '', 'h.jpg', 'Pos Satpam Rusunawa Depok', '2019-03-14 05:49:43'),
('BR003', '', 'k.jpg', 'Masjid Rusunawa Depok', '2019-03-14 05:50:24'),
('BR004', '', 'm.jpg', 'Taman Rusunawa Depok', '2019-03-14 05:50:51'),
('BR005', '', 'kotadepok.png', 'UPT Rusunawa Kota Depok', '2019-03-26 10:33:49'),
('BR006', '', '7be013b4-51d9-46e5-a662-9c43720c16e7.jpg', 'sadadas', '2019-05-16 21:55:28');

-- --------------------------------------------------------

--
-- Table structure for table `update_galery`
--

CREATE TABLE `update_galery` (
  `kode` varchar(16) NOT NULL,
  `gambar` text NOT NULL,
  `tanggal` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `update_galery`
--

INSERT INTO `update_galery` (`kode`, `gambar`, `tanggal`) VALUES
('GR001', 'h.jpg', '2019-03-12 10:11:20'),
('GR002', 'e.jpg', '2019-03-12 10:13:01'),
('GR003', 'i.jpg', '2019-03-12 10:13:27'),
('GR004', 'g.jpg', '2019-03-12 10:15:21'),
('GR005', 'm.jpg', '2019-03-12 10:15:42'),
('GR006', 'j.jpg', '2019-03-12 10:16:28'),
('GR007', 'k.jpg', '2019-03-12 10:16:49'),
('GR008', 'l.jpg', '2019-03-12 10:33:07');

-- --------------------------------------------------------

--
-- Table structure for table `update_sambutan`
--

CREATE TABLE `update_sambutan` (
  `kode_sambutan` varchar(16) NOT NULL,
  `gambar` text NOT NULL,
  `kata_sambutan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `update_sambutan`
--

INSERT INTO `update_sambutan` (`kode_sambutan`, `gambar`, `kata_sambutan`) VALUES
('BS001', 'pa_tedy.jpg', '<p style=\"text-align:justify\"><span style=\"font-family:Comic Sans MS,cursive\">Assalamu&rsquo;alaikum Wr. Wb.</span></p>\r\n\r\n<p style=\"text-align:justify\"><span style=\"font-family:Comic Sans MS,cursive\">Hadirin yang berbahagia, Pada kesempatan yang sangat baik ini marilah kita panjatkan puji syukur kehadirat Allah SWT yang telah memberi rahmat dan hidayahnya kepada kita semua serta tiada henti-hentinya memberikan nikmat yang tidak mungkin dapat kita hitung semua. Baik itu berupa nikmat kesehatan, nikmat iman Islam, nikmat panjang umur hingga saat ini sehingga kita dapat berkumpul dalam acara menyambut datangnya bulan suci ramadhan.</span></p>\r\n\r\n<p style=\"text-align:justify\"><span style=\"font-family:Comic Sans MS,cursive\">Selanjutnya sholawat serta salam semoga tetap tercurahkan kepada junjungan kita, Nabi Muhammad SAW, Keluarganya, Sahabatnya dan para pengikutnya hingga akhir zaman. Hadirin yang dirahmati Allah SWT, Kita semua tahu bawa diwajibkan bagi setiap orang beriman untuk berpuasa di bulan suci Ramadhan seperti juga telah diwajibkan kepada orang-orang yang sebelum kita.</span></p>\r\n\r\n<p style=\"text-align:justify\"><span style=\"font-family:Comic Sans MS,cursive\">Sebagaimana firman Allah dalam surat Al-Baqarah ayat 183 yang artinya sebagai berikut: &ldquo;Wahai orang-orang yang beriman! Diwajibkan berpuasa atas kalian sebagaimana telah diwajibkan atas orang-orang sebelum kalian, supaya kalian menjadi orang yang bertaqwa&rdquo; ( QS. Al-Baqarah : 183 ). Melalui ayat tersebut, Allah memberikan perintah kepada manusia untuk melaksanakan puasa. Dengan berpuasa, seseorang akan diuji ketaqwaannya dalam melawan hawa nafsu, menahan rasa lapar dan dahaga. Sebentar lagi kita akan bertemu dengan bulan suci Ramadhan, dimana seluruh umat Islam dimana saja berada diwajibkan untuk mengerjakan ibadah puasa.</span></p>\r\n\r\n<p style=\"text-align:justify\"><span style=\"font-family:Comic Sans MS,cursive\">Bulan Ramadhan adalah bulan yang mulia, bulan yang suci yang penuh dengan rahmat dan ampunan Allah SWT. Untuk itu marilah kita sambut bulan Ramadhan ini dengan hati yang ikhlas, dan rasa gembira, Jadikan bulan Ramadhan ini sebagai bulan panen amal kebajikan untuk bekal hidup di akhirat kelak. Hadirin yang berbahagia, Marilah kita sambut kedatangan bulan Ramadhan ini dengan mempersiapkan diri dengan sebaik-baiknya, dengan niat yang tulus, riang gembira agar menjadi momentum yang berkesan dalam membersihkan hati dan pikiran kita.</span></p>\r\n\r\n<p style=\"text-align:justify\"><span style=\"font-family:Comic Sans MS,cursive\">Kita sambut kedatangan bulan Ramadhan ini dengan ikhlas hati. Karena puasa Ramadhan itu adalah merupakan panggilan Illahi yang ditujukan kepada orang-orang yang beriman. Sampai di sini saja pidato sambutan ini, Bila ada kata-kata yang kurang berkenan di hati mohon dibukakan pintu maaf yang sebesar-besarnya.</span></p>\r\n\r\n<p style=\"text-align:justify\"><span style=\"font-family:Comic Sans MS,cursive\">Akhirul kalam, uushikum wanafsii wa-iyyaaya bitaqwallohi,</span></p>\r\n\r\n<p style=\"text-align:justify\"><span style=\"font-family:Comic Sans MS,cursive\">wassalamu &lsquo;alaikum warohmatullohi wabarokaatuhu.</span></p>\r\n');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `kode_user` varchar(16) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(16) NOT NULL,
  `level` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`kode_user`, `username`, `password`, `level`) VALUES
('US001', 'admin', 'admin123', 'admin'),
('US002', 'user', '123', 'user'),
('US003', 'hrd', '321', 'hrd'),
('US004', 'Cahyo', '2002', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `booking`
--
ALTER TABLE `booking`
  ADD PRIMARY KEY (`kode_booking`);

--
-- Indexes for table `booking_unit`
--
ALTER TABLE `booking_unit`
  ADD PRIMARY KEY (`kode_booking`);

--
-- Indexes for table `tbl_harga`
--
ALTER TABLE `tbl_harga`
  ADD PRIMARY KEY (`kode_harga`);

--
-- Indexes for table `tbl_kamar`
--
ALTER TABLE `tbl_kamar`
  ADD PRIMARY KEY (`kode_kamar`);

--
-- Indexes for table `tower_a`
--
ALTER TABLE `tower_a`
  ADD PRIMARY KEY (`kode`);

--
-- Indexes for table `tower_b`
--
ALTER TABLE `tower_b`
  ADD PRIMARY KEY (`kode`);

--
-- Indexes for table `update_berita`
--
ALTER TABLE `update_berita`
  ADD PRIMARY KEY (`kode_berita`);

--
-- Indexes for table `update_galery`
--
ALTER TABLE `update_galery`
  ADD PRIMARY KEY (`kode`);

--
-- Indexes for table `update_sambutan`
--
ALTER TABLE `update_sambutan`
  ADD PRIMARY KEY (`kode_sambutan`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`kode_user`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
