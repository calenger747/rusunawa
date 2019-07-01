-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 27, 2018 at 07:48 AM
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
-- Table structure for table `sarana_kesehatan`
--

CREATE TABLE `sarana_kesehatan` (
  `id_kesehatan` int(10) NOT NULL,
  `puskesmas` int(20) NOT NULL,
  `posyandu` int(20) NOT NULL,
  `praktek_bidan` int(20) NOT NULL,
  `rt` varchar(5) NOT NULL,
  `rw` varchar(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sarana_olahraga`
--

CREATE TABLE `sarana_olahraga` (
  `id_olahraga` int(5) NOT NULL,
  `lapangan_bola` int(20) NOT NULL,
  `lapangan_basket` int(20) NOT NULL,
  `lapangan_volly` int(20) NOT NULL,
  `lapangan_badminton` int(20) NOT NULL,
  `lapangan_futsal` int(20) NOT NULL,
  `rt` varchar(5) NOT NULL,
  `rw` varchar(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sarana_pemerintah`
--

CREATE TABLE `sarana_pemerintah` (
  `id_pemerintah` int(5) NOT NULL,
  `kantor_lurah` int(20) NOT NULL,
  `balai_pertemuan` int(20) NOT NULL,
  `pos_rw` int(20) NOT NULL,
  `rt` varchar(5) NOT NULL,
  `rw` varchar(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sarana_pendidikan`
--

CREATE TABLE `sarana_pendidikan` (
  `id_pendidikan` int(5) NOT NULL,
  `paud` int(20) NOT NULL,
  `sd_negeri` int(20) NOT NULL,
  `sd_swasta` int(20) NOT NULL,
  `madrasah_ibridaiyah` int(20) NOT NULL,
  `sltp_negeri` int(20) NOT NULL,
  `sltp_swasta` int(20) NOT NULL,
  `madrasah_tsanawiyah` int(20) NOT NULL,
  `slta_negeri` int(20) NOT NULL,
  `slta_swasta` int(20) NOT NULL,
  `madrasah_aliyah` int(20) NOT NULL,
  `pt_negeri` int(20) NOT NULL,
  `pt_swasta` int(20) NOT NULL,
  `pesantren` int(20) NOT NULL,
  `rt` varchar(5) NOT NULL,
  `rw` varchar(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sarana_perekonomian`
--

CREATE TABLE `sarana_perekonomian` (
  `id_perekonomian` int(5) NOT NULL,
  `pasar` int(20) NOT NULL,
  `wartel_warnet` int(20) NOT NULL,
  `warung_kelontong` int(20) NOT NULL,
  `toko_material` int(20) NOT NULL,
  `indomart` int(20) NOT NULL,
  `rumah_kost` int(20) NOT NULL,
  `rumah_makan` int(20) NOT NULL,
  `rt` varchar(5) NOT NULL,
  `rw` varchar(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sarana_peribadatan`
--

CREATE TABLE `sarana_peribadatan` (
  `id_peribadatan` int(5) NOT NULL,
  `masjid` int(20) NOT NULL,
  `mushollah` int(20) NOT NULL,
  `gereja` int(20) NOT NULL,
  `vihara` int(20) NOT NULL,
  `pure` int(20) NOT NULL,
  `rt` varchar(5) NOT NULL,
  `rw` varchar(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sarana_sosial`
--

CREATE TABLE `sarana_sosial` (
  `id_sosial` int(5) NOT NULL,
  `pkk` int(20) NOT NULL,
  `karang_taruna` int(20) NOT NULL,
  `lsm` int(20) NOT NULL,
  `satgas_rt` int(20) NOT NULL,
  `pos_kamling` int(20) NOT NULL,
  `gerobak_sampah` int(20) NOT NULL,
  `rt` varchar(5) NOT NULL,
  `rw` varchar(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_alamat`
--

CREATE TABLE `tbl_alamat` (
  `id_alamat` int(11) NOT NULL,
  `id_kk` text NOT NULL,
  `jalan` text NOT NULL,
  `rt` text NOT NULL,
  `rw` text NOT NULL,
  `no` text NOT NULL,
  `kelurahan` text NOT NULL,
  `kecamatan` text NOT NULL,
  `kota` text NOT NULL,
  `provinsi` text NOT NULL,
  `kode_pos` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_alamat`
--

INSERT INTO `tbl_alamat` (`id_alamat`, `id_kk`, `jalan`, `rt`, `rw`, `no`, `kelurahan`, `kecamatan`, `kota`, `provinsi`, `kode_pos`) VALUES
(1, '3276102805140002', 'poncol', '05', '07', '42', 'cilangkap', 'tapos', 'depok', 'jawa barat', '16465');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_foto`
--

CREATE TABLE `tbl_foto` (
  `id_foto` int(11) NOT NULL,
  `no_penduduk` varchar(100) NOT NULL,
  `foto_ktp` varchar(100) NOT NULL,
  `foto_akta` varchar(100) NOT NULL,
  `foto_kk` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_keluarga`
--

CREATE TABLE `tbl_keluarga` (
  `id_kk` varchar(30) NOT NULL,
  `nama_kk` text NOT NULL,
  `id_penghuni` text NOT NULL,
  `tempo_pertama` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_keluarga`
--

INSERT INTO `tbl_keluarga` (`id_kk`, `nama_kk`, `id_penghuni`, `tempo_pertama`) VALUES
('3276102805140002', 'ari', '111', '2018-09-10');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_keluarga_get_modal`
--

CREATE TABLE `tbl_keluarga_get_modal` (
  `id_modal` int(11) NOT NULL,
  `id_kk` text NOT NULL,
  `dapat_modal` text NOT NULL,
  `ikut_uppks` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_keluarga_get_modal`
--

INSERT INTO `tbl_keluarga_get_modal` (`id_modal`, `id_kk`, `dapat_modal`, `ikut_uppks`) VALUES
(1, '3276102805140002', 'TIDAK', 'TIDAK');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_keluarga_meninggal`
--

CREATE TABLE `tbl_keluarga_meninggal` (
  `id_meninggal` int(11) NOT NULL,
  `id_kk` text NOT NULL,
  `ada_meninggal` text NOT NULL,
  `umur_meninggal` text NOT NULL,
  `jk` text NOT NULL,
  `ibu_meninggal` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_keluarga_meninggal`
--

INSERT INTO `tbl_keluarga_meninggal` (`id_meninggal`, `id_kk`, `ada_meninggal`, `umur_meninggal`, `jk`, `ibu_meninggal`) VALUES
(1, '3276102805140002', 'TIDAK', '', '', 'TIDAK');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_keluarga_sejahtera`
--

CREATE TABLE `tbl_keluarga_sejahtera` (
  `id_sejahtera` int(11) NOT NULL,
  `id_kk` text NOT NULL,
  `status_tahapan` text NOT NULL,
  `alasan` text NOT NULL,
  `fasilitas_kakus` text NOT NULL,
  `fasilitas_listrik` text NOT NULL,
  `fasilitas_airminum` text NOT NULL,
  `fasilitas_memasak` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_keluarga_sejahtera`
--

INSERT INTO `tbl_keluarga_sejahtera` (`id_sejahtera`, `id_kk`, `status_tahapan`, `alasan`, `fasilitas_kakus`, `fasilitas_listrik`, `fasilitas_airminum`, `fasilitas_memasak`) VALUES
(1, '3276102805140002', '-', 'ALASAN BUKAN EKONOMI', 'YA', 'YA', 'YA', 'YA');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_keluarga_status_dan_kb`
--

CREATE TABLE `tbl_keluarga_status_dan_kb` (
  `id_sdk` int(11) NOT NULL,
  `id_kk` text NOT NULL,
  `jamkesnas` text NOT NULL,
  `metode_kb` text NOT NULL,
  `sebab_non_kb` text NOT NULL,
  `kapan_kb` date NOT NULL,
  `tempat_kb` text NOT NULL,
  `ikut_posyandu` text NOT NULL,
  `ikut_bkb` text NOT NULL,
  `remaja_bkr` text NOT NULL,
  `remaja_pik` text NOT NULL,
  `lansia_bkl` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_keluarga_status_dan_kb`
--

INSERT INTO `tbl_keluarga_status_dan_kb` (`id_sdk`, `id_kk`, `jamkesnas`, `metode_kb`, `sebab_non_kb`, `kapan_kb`, `tempat_kb`, `ikut_posyandu`, `ikut_bkb`, `remaja_bkr`, `remaja_pik`, `lansia_bkl`) VALUES
(1, '3276102805140002', 'NON JKN', 'TIDAK', '-', '0000-00-00', '-', 'TIDAK', 'TIDAK', 'TIDAK', 'TIDAK', 'TIDAK');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_lembaga`
--

CREATE TABLE `tbl_lembaga` (
  `id_lembaga` int(11) NOT NULL,
  `nama_lembaga` text NOT NULL,
  `alamat` text NOT NULL,
  `telp` text NOT NULL,
  `fax` text NOT NULL,
  `email` text NOT NULL,
  `website` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_lembaga`
--

INSERT INTO `tbl_lembaga` (`id_lembaga`, `nama_lembaga`, `alamat`, `telp`, `fax`, `email`, `website`) VALUES
(1, 'Rusunawa Depok', 'Jl. Banjaran Pucung No.66, Cilangkap, Tapos, Kota Depok, Jawa Barat 16451', 'Telp -', 'Fax -', 'Email -', 'Website -');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_agama`
--

CREATE TABLE `tbl_m_agama` (
  `id_agama` int(11) NOT NULL,
  `nama_agama` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_agama`
--

INSERT INTO `tbl_m_agama` (`id_agama`, `nama_agama`) VALUES
(1, 'ISLAM'),
(2, 'KRISTEN'),
(3, 'BUDDHA'),
(4, 'HINDU'),
(5, 'KONGHUCU');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_golongan_darah`
--

CREATE TABLE `tbl_m_golongan_darah` (
  `id_gol_darah` int(11) NOT NULL,
  `jenis_gol_darah` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_golongan_darah`
--

INSERT INTO `tbl_m_golongan_darah` (`id_gol_darah`, `jenis_gol_darah`) VALUES
(1, 'O'),
(2, 'A'),
(3, 'B'),
(4, 'AB');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_imunisasi`
--

CREATE TABLE `tbl_m_imunisasi` (
  `id_imunisasi` int(11) NOT NULL,
  `nm_imunisasi` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_imunisasi`
--

INSERT INTO `tbl_m_imunisasi` (`id_imunisasi`, `nm_imunisasi`) VALUES
(1, 'BCG'),
(2, 'HEPATITIS B'),
(3, 'POLIO'),
(4, 'DTP'),
(5, 'CAMPAK'),
(6, 'BELUM'),
(7, 'TIDAK');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_jenis_kelamin`
--

CREATE TABLE `tbl_m_jenis_kelamin` (
  `id_jenis_kelamin` int(11) NOT NULL,
  `jenis_kelamin` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_jenis_kelamin`
--

INSERT INTO `tbl_m_jenis_kelamin` (`id_jenis_kelamin`, `jenis_kelamin`) VALUES
(1, 'LK'),
(2, 'P');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_kontrasepsi`
--

CREATE TABLE `tbl_m_kontrasepsi` (
  `id_kontrasepsi` int(11) NOT NULL,
  `nm_kontrasepsi` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_kontrasepsi`
--

INSERT INTO `tbl_m_kontrasepsi` (`id_kontrasepsi`, `nm_kontrasepsi`) VALUES
(1, 'IUD'),
(2, 'MOW'),
(3, 'MOP'),
(4, 'KONDOM'),
(5, 'IMPLANT'),
(6, 'SUNTIKAN'),
(7, 'PIL'),
(8, 'BELUM'),
(9, 'TIDAK');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_pendidikan`
--

CREATE TABLE `tbl_m_pendidikan` (
  `id_nama_pendidikan` int(11) NOT NULL,
  `jenis_pendidikan` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_pendidikan`
--

INSERT INTO `tbl_m_pendidikan` (`id_nama_pendidikan`, `jenis_pendidikan`) VALUES
(1, 'SD'),
(2, 'SMP'),
(3, 'SMA'),
(4, 'SMU'),
(5, 'STM'),
(6, 'SMK'),
(7, 'D3'),
(8, 'S1'),
(9, 'S2'),
(10, 'S3');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_status_keluarga`
--

CREATE TABLE `tbl_m_status_keluarga` (
  `id_status` int(11) NOT NULL,
  `nama_status` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_status_keluarga`
--

INSERT INTO `tbl_m_status_keluarga` (`id_status`, `nama_status`) VALUES
(1, 'KK'),
(2, 'ISTRI'),
(3, 'ANAK'),
(4, 'LL');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_status_pernikahan`
--

CREATE TABLE `tbl_m_status_pernikahan` (
  `id_status_pernikahan` int(11) NOT NULL,
  `status_pernikahan` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_status_pernikahan`
--

INSERT INTO `tbl_m_status_pernikahan` (`id_status_pernikahan`, `status_pernikahan`) VALUES
(1, 'BK'),
(2, 'K'),
(3, 'D/J/C');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_status_sosial`
--

CREATE TABLE `tbl_m_status_sosial` (
  `id_status_sosial` int(11) NOT NULL,
  `status_sosial` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_status_sosial`
--

INSERT INTO `tbl_m_status_sosial` (`id_status_sosial`, `status_sosial`) VALUES
(1, 'KURANG'),
(2, 'MAMPU'),
(3, 'SANGAT');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_user`
--

CREATE TABLE `tbl_m_user` (
  `user_id` int(11) NOT NULL,
  `user_name` text NOT NULL,
  `user_password` text CHARACTER SET macce COLLATE macce_bin NOT NULL,
  `user_role` int(11) NOT NULL,
  `user_nama` text NOT NULL,
  `Jabatan` text,
  `Alamat` text,
  `no_telpon` text,
  `rt` text NOT NULL,
  `rw` text NOT NULL,
  `tanggal_input` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_user`
--

INSERT INTO `tbl_m_user` (`user_id`, `user_name`, `user_password`, `user_role`, `user_nama`, `Jabatan`, `Alamat`, `no_telpon`, `rt`, `rw`, `tanggal_input`) VALUES
(175, 'superadmin', 'superadmin', 3, 'Super Admin', NULL, NULL, NULL, '', '', '0000-00-00'),
(176, 'admin', 'admin123', 2, 'Administrator', NULL, NULL, NULL, '', '', '0000-00-00'),
(177, 'operator', 'operator123', 1, 'Operator', NULL, NULL, NULL, 'B', '1', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_m_warga_negara`
--

CREATE TABLE `tbl_m_warga_negara` (
  `id_warga_negara` int(11) NOT NULL,
  `warga_negara` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_m_warga_negara`
--

INSERT INTO `tbl_m_warga_negara` (`id_warga_negara`, `warga_negara`) VALUES
(1, 'WNI'),
(2, 'WNA');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pembayaran`
--

CREATE TABLE `tbl_pembayaran` (
  `no_transaksi` varchar(30) NOT NULL,
  `tgl_transaksi` date NOT NULL,
  `jatuh_tempo` date NOT NULL,
  `id_pelanggan` text NOT NULL,
  `bulan` text NOT NULL,
  `jumlah` text NOT NULL,
  `keterangan` enum('LUNAS','BELUM BAYAR','MENUNGGAK') NOT NULL,
  `id_user` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pembayaran`
--

INSERT INTO `tbl_pembayaran` (`no_transaksi`, `tgl_transaksi`, `jatuh_tempo`, `id_pelanggan`, `bulan`, `jumlah`, `keterangan`, `id_user`) VALUES
('2018-08-27', '2018-08-27', '2019-01-10', '111', 'Desember 2018', '175000', 'MENUNGGAK', 'Panel 1'),
('TRIB0000116082018', '2017-08-16', '2018-10-10', '111', 'September 2018', '175000', 'LUNAS', 'Panel 1'),
('TRIB0000316082018', '2018-08-16', '2018-11-10', '111', 'Oktober 2018', '175000', 'LUNAS', 'Panel 1'),
('TRIB0000427082018', '2018-08-27', '2018-12-10', '111', 'Nopember 2018', '175000', 'LUNAS', 'Panel 1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penduduk`
--

CREATE TABLE `tbl_penduduk` (
  `id_pend` int(11) NOT NULL,
  `id_kk` text NOT NULL,
  `nik` text NOT NULL,
  `nama` text NOT NULL,
  `status_kk` text NOT NULL,
  `jenis_kelamin` text NOT NULL,
  `tmpt_lahir` text NOT NULL,
  `tgl_lahir` date NOT NULL,
  `agama` text NOT NULL,
  `akte` text NOT NULL,
  `pendidikan` text NOT NULL,
  `pekerjaan` text NOT NULL,
  `status_kawin` text NOT NULL,
  `usia_kawin_pertama` text NOT NULL,
  `status_hidup` enum('Masih Hidup','Sudah Meninggal') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_penduduk`
--

INSERT INTO `tbl_penduduk` (`id_pend`, `id_kk`, `nik`, `nama`, `status_kk`, `jenis_kelamin`, `tmpt_lahir`, `tgl_lahir`, `agama`, `akte`, `pendidikan`, `pekerjaan`, `status_kawin`, `usia_kawin_pertama`, `status_hidup`) VALUES
(1, '3276102805140002', '3276100404000002', 'ari ariyanto', 'KK', 'LK', 'bogor', '2000-04-04', 'ISLAM', 'YA', 'SMA/Sederajat', 'peg swasta', 'BK', '0', 'Masih Hidup'),
(2, '3276102805140002', '671', 'sa', 'LL', 'P', 'as', '2011-08-16', 'ISLAM', 'YA', 'SD/Sederajat', 'aaa', 'BK', '0', 'Masih Hidup'),
(3, '3276102805140002', '7838', 'da', 'LL', 'P', 'as', '1990-08-16', 'ISLAM', 'YA', 'DIPLOMA', 'sa', 'K', '0', 'Masih Hidup');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_t_keluarga`
--

CREATE TABLE `tbl_t_keluarga` (
  `id_kk` int(11) NOT NULL,
  `id_status_penduduk` int(11) NOT NULL DEFAULT '1',
  `kk_nama` text NOT NULL,
  `kki` text NOT NULL,
  `kk_provinsi` text NOT NULL,
  `kk_kab` text NOT NULL,
  `kk_kec` text NOT NULL,
  `kk_kel` text NOT NULL,
  `kk_rw` text NOT NULL,
  `kk_rt` text NOT NULL,
  `kk_jalan` longtext NOT NULL,
  `kk_komplek` text NOT NULL,
  `kk_kamar` enum('1','2','3','4','5','6','7','8','9','10','11','12','13','14','15','16','17','18','19','20','21','22','23','24') NOT NULL,
  `kk_gedung` enum('A','B','C') NOT NULL,
  `kk_lantai` enum('1','2','3','4') NOT NULL,
  `id_penghuni` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_t_keluarga`
--

INSERT INTO `tbl_t_keluarga` (`id_kk`, `id_status_penduduk`, `kk_nama`, `kki`, `kk_provinsi`, `kk_kab`, `kk_kec`, `kk_kel`, `kk_rw`, `kk_rt`, `kk_jalan`, `kk_komplek`, `kk_kamar`, `kk_gedung`, `kk_lantai`, `id_penghuni`) VALUES
(169, 1, 'Soderi', '3302032205120002', 'Jawa Tengah', 'Banyumas', 'Jatilawang', 'Kedungwringin', '1', '1', 'Jl. Masjid', '21', '1', 'B', '1', '111'),
(168, 1, 'Abdul Sukur', '3171031701099310', 'DKI Jakarta', 'Jakarta Pusat', 'Kemayoran', 'Harapan Mulia', '1', '3', 'Jl. Cempaka Wangi I', '-', '2', 'B', '1', ''),
(167, 1, 'Bedy Agus Firmansyah', '3', 'Jawa Barat', 'Depok', 'Tapos', 'Jatijajar', '1', '2', 'Jl. Jatijajar', '-', '3', 'B', '1', ''),
(166, 1, 'Eka Wahyudi', '2', 'DKI Jakarta', 'Jakarta Pusat', 'Kemayoran', 'Utan Panjang', '1', '5', 'Jl. Utan Panjang III', '-', '4', 'B', '1', '');

--
-- Triggers `tbl_t_keluarga`
--
DELIMITER $$
CREATE TRIGGER `after_delete_kk` AFTER DELETE ON `tbl_t_keluarga` FOR EACH ROW BEGIN
DELETE FROM tbl_t_penduduk WHERE id_kk = OLD.id_kk;
DELETE FROM tbl_t_keluarga_get_modal WHERE id_kk = OLD.id_kk;
DELETE FROM tbl_t_keluarga_meninggal WHERE id_kk = OLD.id_kk;
DELETE FROM tbl_t_keluarga_sejahtera WHERE id_kk = OLD.id_kk;
DELETE FROM tbl_t_keluarga_status_dan_kb WHERE id_kk = OLD.id_kk;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_t_keluarga_get_modal`
--

CREATE TABLE `tbl_t_keluarga_get_modal` (
  `id_kgm` int(11) NOT NULL,
  `id_kk` int(11) NOT NULL,
  `dapat_modal` text NOT NULL,
  `ikut_uppks` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_t_keluarga_get_modal`
--

INSERT INTO `tbl_t_keluarga_get_modal` (`id_kgm`, `id_kk`, `dapat_modal`, `ikut_uppks`) VALUES
(188, 174, '', ''),
(185, 173, '0', '0'),
(184, 172, '', ''),
(183, 171, '', ''),
(182, 170, '', ''),
(181, 169, '', ''),
(180, 168, '', ''),
(179, 167, '', ''),
(178, 166, '', ''),
(177, 165, '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_t_keluarga_meninggal`
--

CREATE TABLE `tbl_t_keluarga_meninggal` (
  `id_km` int(11) NOT NULL,
  `id_kk` int(11) NOT NULL,
  `ada_meninggal` text NOT NULL,
  `umur_saat_meninggal` text NOT NULL,
  `jk` text NOT NULL,
  `ibu_meninggal` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_t_keluarga_meninggal`
--

INSERT INTO `tbl_t_keluarga_meninggal` (`id_km`, `id_kk`, `ada_meninggal`, `umur_saat_meninggal`, `jk`, `ibu_meninggal`) VALUES
(188, 174, '', '', '-', ''),
(185, 173, '0', '0', '0', '0'),
(184, 172, '', '', '-', ''),
(183, 171, '', '', '-', ''),
(182, 170, '', '', '-', ''),
(181, 169, '', '', '-', ''),
(180, 168, '', '', '-', ''),
(179, 167, '', '', '-', ''),
(178, 166, '', '', '-', ''),
(177, 165, '', '', '-', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_t_keluarga_sejahtera`
--

CREATE TABLE `tbl_t_keluarga_sejahtera` (
  `id_ks` int(11) NOT NULL,
  `id_kk` int(11) NOT NULL,
  `status_tahapan` text NOT NULL,
  `alasan` text NOT NULL,
  `fasilitas_kakus` text NOT NULL,
  `fasilitas_listrik` text NOT NULL,
  `fasilitas_airminum` text NOT NULL,
  `fasilitas_memasak` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_t_keluarga_sejahtera`
--

INSERT INTO `tbl_t_keluarga_sejahtera` (`id_ks`, `id_kk`, `status_tahapan`, `alasan`, `fasilitas_kakus`, `fasilitas_listrik`, `fasilitas_airminum`, `fasilitas_memasak`) VALUES
(188, 174, '', '-', '', '', '', ''),
(185, 173, '0', '0', '0', '0', '0', '0'),
(184, 172, '', '-', '', '', '', ''),
(183, 171, '', '-', '', '', '', ''),
(182, 170, '', '-', '', '', '', ''),
(181, 169, '', '-', '', '', '', ''),
(180, 168, '', '-', '', '', '', ''),
(179, 167, '', '-', '', '', '', ''),
(178, 166, '', '-', '', '', '', ''),
(177, 165, '', '-', '', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_t_keluarga_status_dan_kb`
--

CREATE TABLE `tbl_t_keluarga_status_dan_kb` (
  `id_ksb` int(11) NOT NULL,
  `id_kk` int(11) NOT NULL,
  `jamkesnas` text NOT NULL,
  `metode_kb` text NOT NULL,
  `sebab_non_kb` text NOT NULL,
  `kapan_kb` date NOT NULL,
  `tempat_kb` text NOT NULL,
  `ikut_posyandu` text NOT NULL,
  `ikut_bkb` text NOT NULL,
  `remaja_bkr` text NOT NULL,
  `remaja_pik` text NOT NULL,
  `lansia_bkl` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_t_keluarga_status_dan_kb`
--

INSERT INTO `tbl_t_keluarga_status_dan_kb` (`id_ksb`, `id_kk`, `jamkesnas`, `metode_kb`, `sebab_non_kb`, `kapan_kb`, `tempat_kb`, `ikut_posyandu`, `ikut_bkb`, `remaja_bkr`, `remaja_pik`, `lansia_bkl`) VALUES
(188, 174, '', '', '-', '0000-00-00', '', '-', '-', '-', '-', '-'),
(185, 173, '0', '0', '0', '0000-00-00', '0', '0', '0', '0', '0', '0'),
(184, 172, '', '', '-', '0000-00-00', '', '-', '-', '-', '-', '-'),
(183, 171, '', '', '-', '0000-00-00', '', '-', '-', '-', '-', '-'),
(182, 170, '', '', '-', '0000-00-00', '', '-', '-', '-', '-', '-'),
(181, 169, '', '', '-', '0000-00-00', '', '-', '-', '-', '-', '-'),
(180, 168, '', '', '-', '0000-00-00', '', '-', '-', '-', '-', '-'),
(179, 167, '', '', '-', '0000-00-00', '', '-', '-', '-', '-', '-'),
(178, 166, '', '', '-', '0000-00-00', '', '-', '-', '-', '-', '-'),
(177, 165, '', '', '-', '0000-00-00', '', '-', '-', '-', '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_t_penduduk`
--

CREATE TABLE `tbl_t_penduduk` (
  `id_penduduk` int(11) NOT NULL,
  `id_kk` int(11) NOT NULL,
  `id_status_penduduk` int(11) DEFAULT NULL,
  `nama` text NOT NULL,
  `no_penduduk` text NOT NULL,
  `agama` text NOT NULL,
  `tmpt_lahir` text NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jenis_kelamin` text NOT NULL,
  `pendidikan` enum('SD','SMP','SMA','D3','S1','S2','S3') NOT NULL,
  `status_pernikahan` text NOT NULL,
  `pekerjaan` text NOT NULL,
  `status_dalam_keluarga` text NOT NULL,
  `tanggal_input` date NOT NULL,
  `akte` text NOT NULL,
  `usia_kawin_pertama` int(11) NOT NULL,
  `tgl_kematian` date NOT NULL,
  `gedung` enum('A','B','C') NOT NULL,
  `lantai` enum('1','2','3','4') NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_t_penduduk`
--

INSERT INTO `tbl_t_penduduk` (`id_penduduk`, `id_kk`, `id_status_penduduk`, `nama`, `no_penduduk`, `agama`, `tmpt_lahir`, `tgl_lahir`, `jenis_kelamin`, `pendidikan`, `status_pernikahan`, `pekerjaan`, `status_dalam_keluarga`, `tanggal_input`, `akte`, `usia_kawin_pertama`, `tgl_kematian`, `gedung`, `lantai`) VALUES
(3, 166, 1, 'Eka Wahyudi', '1571030501820181', 'ISLAM', 'Jakarta', '1982-01-05', 'LK', 'SMA', 'K', 'Karyawan Swasta', 'KK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(4, 166, 1, 'Ria Hudaya Hutagalung', '1571036710880101', 'ISLAM', 'Jambi', '1988-10-27', 'PR', 'SMA', 'K', 'IRT', 'ISTRI', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(5, 166, 1, 'Muhammad Ghalib Akbar', '1571031402120021', 'ISLAM', 'Jambi', '2012-02-14', 'LK', '', 'BK', '-', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(6, 166, 1, 'Galang Kurnia', '3171031311141008', 'ISLAM', 'Jakarta', '2014-11-13', 'LK', '', 'BK', '-', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(7, 166, 1, 'Gilang Kurnia', '3171031311141009', 'ISLAM', 'Jakarta', '2014-11-13', 'LK', '', 'BK', '-', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(8, 167, 1, 'Bedy Agus Firmansyah', '3276102508800007', 'ISLAM', 'Jember', '1980-08-25', 'LK', 'SMA', 'K', 'Karyawan Swasta', 'KK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(9, 167, 1, 'Febri Konya Nindira', '3276105202790005', 'ISLAM', 'Salahtiga', '1979-02-12', 'PR', 'SMA', 'K', 'Karyawan Swasta', 'ISTRI', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(10, 167, 1, 'Prince Ababiel Riansyah', '3276100204050003', 'ISLAM', 'Salagtiga', '2005-04-02', 'LK', 'SD', 'BK', 'Pelajar', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(11, 167, 1, 'Princess Naylla Febriansyah', '3276104908120003', 'ISLAM', 'Depok', '2012-08-09', 'PR', '', 'BK', '-', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(12, 168, 1, 'Abdul Sukur', '3171031401710001', 'ISLAM', 'Jakarta', '1971-01-14', 'LK', 'SD', 'K', 'Buruh Harian', 'KK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(13, 168, 1, 'Sunarsih', '3171034509700010', 'ISLAM', 'Jakarta', '1970-09-05', 'PR', 'SMA', 'K', 'IRT', 'ISTRI', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(14, 168, 1, 'Randy Destian', '3171030212970001', 'ISLAM', 'Jakarta', '1997-12-02', 'LK', 'SMA', 'BK', '-', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(15, 168, 1, 'Putri Rahmawati', '3171035605000002', 'ISLAM', 'Jakarta', '2000-05-16', 'PR', 'SMA', 'BK', '-', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(16, 168, 1, 'Resa Adittian', '3171032503030001', 'ISLAM', 'Jakarta', '2003-03-25', 'LK', 'SMP', 'BK', 'Pelajar', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(17, 168, 1, 'Adit Novian', '3171030411040001', 'ISLAM', 'Jakarta', '2004-11-04', 'LK', 'SMP', 'BK', 'Pelajar', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(18, 169, 1, 'Soderi', '3302031105770004', 'ISLAM', 'Banyumas', '1977-05-11', 'LK', 'SMA', 'K', 'Karyawan Swasta', 'KK', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(19, 169, 1, 'Umi Habibah', '3302036010870005', 'ISLAM', 'Banyumas', '1987-10-20', 'PR', 'SMP', 'K', 'Buruh Harian', 'ISTRI', '2018-07-20', 'YA', 0, '0000-00-00', 'B', '1'),
(20, 169, 1, 'Iqbal Dzulfaqor', '3302032503100003', 'ISLAM', 'Banyumas', '2010-03-25', 'LK', 'SD', 'BK', 'Pelajar', 'ANAK', '2018-07-20', 'YA', 0, '0000-00-00', 'A', '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_unit`
--

CREATE TABLE `tbl_unit` (
  `id_unit` varchar(20) NOT NULL,
  `no_kwh` text NOT NULL,
  `unit` text NOT NULL,
  `gedung` text NOT NULL,
  `lantai` text NOT NULL,
  `kamar` text NOT NULL,
  `harga` text NOT NULL,
  `status` enum('Isi','Kosong') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_unit`
--

INSERT INTO `tbl_unit` (`id_unit`, `no_kwh`, `unit`, `gedung`, `lantai`, `kamar`, `harga`, `status`) VALUES
('111', '111', 'B310', 'B', '3', '10', '175000', 'Isi'),
('112', '212', 'A18', 'A', '1', '8', '220000', 'Kosong'),
('113', '993737', 'A14', 'A', '1', '4', '220000', 'Kosong');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_upload`
--

CREATE TABLE `tbl_upload` (
  `no_penduduk` int(25) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `foto_ktp` varchar(100) NOT NULL,
  `foto_akta` varchar(100) NOT NULL,
  `foto_kk` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Stand-in structure for view `umur_p`
--
CREATE TABLE `umur_p` (
`nik` text
,`id_kk` varchar(30)
,`gedung` text
,`lantai` text
,`nama` text
,`jenis_kelamin` text
,`status` text
,`tgl_lahir` date
,`t_lahir` int(5)
);

-- --------------------------------------------------------

--
-- Structure for view `umur_p`
--
DROP TABLE IF EXISTS `umur_p`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `umur_p`  AS  select `tbl_penduduk`.`nik` AS `nik`,`tbl_keluarga`.`id_kk` AS `id_kk`,`tbl_unit`.`gedung` AS `gedung`,`tbl_unit`.`lantai` AS `lantai`,`tbl_penduduk`.`nama` AS `nama`,`tbl_penduduk`.`jenis_kelamin` AS `jenis_kelamin`,`tbl_penduduk`.`status_kawin` AS `status`,`tbl_penduduk`.`tgl_lahir` AS `tgl_lahir`,(year(curdate()) - year(`tbl_penduduk`.`tgl_lahir`)) AS `t_lahir` from ((`tbl_penduduk` join `tbl_unit`) join `tbl_keluarga`) where ((`tbl_penduduk`.`id_kk` = `tbl_keluarga`.`id_kk`) and (`tbl_keluarga`.`id_penghuni` = `tbl_unit`.`id_unit`) and (year(curdate()) - year(`tbl_penduduk`.`tgl_lahir`))) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `sarana_kesehatan`
--
ALTER TABLE `sarana_kesehatan`
  ADD PRIMARY KEY (`id_kesehatan`);

--
-- Indexes for table `sarana_olahraga`
--
ALTER TABLE `sarana_olahraga`
  ADD PRIMARY KEY (`id_olahraga`);

--
-- Indexes for table `sarana_pemerintah`
--
ALTER TABLE `sarana_pemerintah`
  ADD PRIMARY KEY (`id_pemerintah`);

--
-- Indexes for table `sarana_pendidikan`
--
ALTER TABLE `sarana_pendidikan`
  ADD PRIMARY KEY (`id_pendidikan`);

--
-- Indexes for table `sarana_perekonomian`
--
ALTER TABLE `sarana_perekonomian`
  ADD PRIMARY KEY (`id_perekonomian`);

--
-- Indexes for table `sarana_peribadatan`
--
ALTER TABLE `sarana_peribadatan`
  ADD PRIMARY KEY (`id_peribadatan`);

--
-- Indexes for table `sarana_sosial`
--
ALTER TABLE `sarana_sosial`
  ADD PRIMARY KEY (`id_sosial`);

--
-- Indexes for table `tbl_alamat`
--
ALTER TABLE `tbl_alamat`
  ADD PRIMARY KEY (`id_alamat`);

--
-- Indexes for table `tbl_foto`
--
ALTER TABLE `tbl_foto`
  ADD PRIMARY KEY (`id_foto`);

--
-- Indexes for table `tbl_keluarga`
--
ALTER TABLE `tbl_keluarga`
  ADD PRIMARY KEY (`id_kk`);

--
-- Indexes for table `tbl_keluarga_get_modal`
--
ALTER TABLE `tbl_keluarga_get_modal`
  ADD PRIMARY KEY (`id_modal`);

--
-- Indexes for table `tbl_keluarga_meninggal`
--
ALTER TABLE `tbl_keluarga_meninggal`
  ADD PRIMARY KEY (`id_meninggal`);

--
-- Indexes for table `tbl_keluarga_sejahtera`
--
ALTER TABLE `tbl_keluarga_sejahtera`
  ADD PRIMARY KEY (`id_sejahtera`);

--
-- Indexes for table `tbl_keluarga_status_dan_kb`
--
ALTER TABLE `tbl_keluarga_status_dan_kb`
  ADD PRIMARY KEY (`id_sdk`);

--
-- Indexes for table `tbl_lembaga`
--
ALTER TABLE `tbl_lembaga`
  ADD PRIMARY KEY (`id_lembaga`);

--
-- Indexes for table `tbl_m_agama`
--
ALTER TABLE `tbl_m_agama`
  ADD PRIMARY KEY (`id_agama`);

--
-- Indexes for table `tbl_m_golongan_darah`
--
ALTER TABLE `tbl_m_golongan_darah`
  ADD PRIMARY KEY (`id_gol_darah`);

--
-- Indexes for table `tbl_m_imunisasi`
--
ALTER TABLE `tbl_m_imunisasi`
  ADD PRIMARY KEY (`id_imunisasi`);

--
-- Indexes for table `tbl_m_jenis_kelamin`
--
ALTER TABLE `tbl_m_jenis_kelamin`
  ADD PRIMARY KEY (`id_jenis_kelamin`);

--
-- Indexes for table `tbl_m_kontrasepsi`
--
ALTER TABLE `tbl_m_kontrasepsi`
  ADD PRIMARY KEY (`id_kontrasepsi`);

--
-- Indexes for table `tbl_m_pendidikan`
--
ALTER TABLE `tbl_m_pendidikan`
  ADD PRIMARY KEY (`id_nama_pendidikan`);

--
-- Indexes for table `tbl_m_status_keluarga`
--
ALTER TABLE `tbl_m_status_keluarga`
  ADD PRIMARY KEY (`id_status`);

--
-- Indexes for table `tbl_m_status_pernikahan`
--
ALTER TABLE `tbl_m_status_pernikahan`
  ADD PRIMARY KEY (`id_status_pernikahan`);

--
-- Indexes for table `tbl_m_status_sosial`
--
ALTER TABLE `tbl_m_status_sosial`
  ADD PRIMARY KEY (`id_status_sosial`);

--
-- Indexes for table `tbl_m_user`
--
ALTER TABLE `tbl_m_user`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `tbl_m_warga_negara`
--
ALTER TABLE `tbl_m_warga_negara`
  ADD PRIMARY KEY (`id_warga_negara`);

--
-- Indexes for table `tbl_pembayaran`
--
ALTER TABLE `tbl_pembayaran`
  ADD PRIMARY KEY (`no_transaksi`);

--
-- Indexes for table `tbl_penduduk`
--
ALTER TABLE `tbl_penduduk`
  ADD PRIMARY KEY (`id_pend`);

--
-- Indexes for table `tbl_t_keluarga`
--
ALTER TABLE `tbl_t_keluarga`
  ADD PRIMARY KEY (`id_kk`);

--
-- Indexes for table `tbl_t_keluarga_get_modal`
--
ALTER TABLE `tbl_t_keluarga_get_modal`
  ADD PRIMARY KEY (`id_kgm`);

--
-- Indexes for table `tbl_t_keluarga_meninggal`
--
ALTER TABLE `tbl_t_keluarga_meninggal`
  ADD PRIMARY KEY (`id_km`);

--
-- Indexes for table `tbl_t_keluarga_sejahtera`
--
ALTER TABLE `tbl_t_keluarga_sejahtera`
  ADD PRIMARY KEY (`id_ks`);

--
-- Indexes for table `tbl_t_keluarga_status_dan_kb`
--
ALTER TABLE `tbl_t_keluarga_status_dan_kb`
  ADD PRIMARY KEY (`id_ksb`);

--
-- Indexes for table `tbl_t_penduduk`
--
ALTER TABLE `tbl_t_penduduk`
  ADD PRIMARY KEY (`id_penduduk`);

--
-- Indexes for table `tbl_unit`
--
ALTER TABLE `tbl_unit`
  ADD PRIMARY KEY (`id_unit`);

--
-- Indexes for table `tbl_upload`
--
ALTER TABLE `tbl_upload`
  ADD PRIMARY KEY (`no_penduduk`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `sarana_kesehatan`
--
ALTER TABLE `sarana_kesehatan`
  MODIFY `id_kesehatan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `sarana_olahraga`
--
ALTER TABLE `sarana_olahraga`
  MODIFY `id_olahraga` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;
--
-- AUTO_INCREMENT for table `sarana_pemerintah`
--
ALTER TABLE `sarana_pemerintah`
  MODIFY `id_pemerintah` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `sarana_pendidikan`
--
ALTER TABLE `sarana_pendidikan`
  MODIFY `id_pendidikan` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `sarana_perekonomian`
--
ALTER TABLE `sarana_perekonomian`
  MODIFY `id_perekonomian` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `sarana_peribadatan`
--
ALTER TABLE `sarana_peribadatan`
  MODIFY `id_peribadatan` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `sarana_sosial`
--
ALTER TABLE `sarana_sosial`
  MODIFY `id_sosial` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;
--
-- AUTO_INCREMENT for table `tbl_alamat`
--
ALTER TABLE `tbl_alamat`
  MODIFY `id_alamat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_foto`
--
ALTER TABLE `tbl_foto`
  MODIFY `id_foto` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_keluarga_get_modal`
--
ALTER TABLE `tbl_keluarga_get_modal`
  MODIFY `id_modal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_keluarga_meninggal`
--
ALTER TABLE `tbl_keluarga_meninggal`
  MODIFY `id_meninggal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_keluarga_sejahtera`
--
ALTER TABLE `tbl_keluarga_sejahtera`
  MODIFY `id_sejahtera` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_keluarga_status_dan_kb`
--
ALTER TABLE `tbl_keluarga_status_dan_kb`
  MODIFY `id_sdk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_lembaga`
--
ALTER TABLE `tbl_lembaga`
  MODIFY `id_lembaga` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_m_agama`
--
ALTER TABLE `tbl_m_agama`
  MODIFY `id_agama` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `tbl_m_golongan_darah`
--
ALTER TABLE `tbl_m_golongan_darah`
  MODIFY `id_gol_darah` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_m_imunisasi`
--
ALTER TABLE `tbl_m_imunisasi`
  MODIFY `id_imunisasi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tbl_m_jenis_kelamin`
--
ALTER TABLE `tbl_m_jenis_kelamin`
  MODIFY `id_jenis_kelamin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_m_kontrasepsi`
--
ALTER TABLE `tbl_m_kontrasepsi`
  MODIFY `id_kontrasepsi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `tbl_m_status_keluarga`
--
ALTER TABLE `tbl_m_status_keluarga`
  MODIFY `id_status` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_m_status_pernikahan`
--
ALTER TABLE `tbl_m_status_pernikahan`
  MODIFY `id_status_pernikahan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_m_status_sosial`
--
ALTER TABLE `tbl_m_status_sosial`
  MODIFY `id_status_sosial` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_m_user`
--
ALTER TABLE `tbl_m_user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=179;
--
-- AUTO_INCREMENT for table `tbl_m_warga_negara`
--
ALTER TABLE `tbl_m_warga_negara`
  MODIFY `id_warga_negara` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_penduduk`
--
ALTER TABLE `tbl_penduduk`
  MODIFY `id_pend` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_t_keluarga`
--
ALTER TABLE `tbl_t_keluarga`
  MODIFY `id_kk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=177;
--
-- AUTO_INCREMENT for table `tbl_t_keluarga_get_modal`
--
ALTER TABLE `tbl_t_keluarga_get_modal`
  MODIFY `id_kgm` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=190;
--
-- AUTO_INCREMENT for table `tbl_t_keluarga_meninggal`
--
ALTER TABLE `tbl_t_keluarga_meninggal`
  MODIFY `id_km` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=190;
--
-- AUTO_INCREMENT for table `tbl_t_keluarga_sejahtera`
--
ALTER TABLE `tbl_t_keluarga_sejahtera`
  MODIFY `id_ks` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=190;
--
-- AUTO_INCREMENT for table `tbl_t_keluarga_status_dan_kb`
--
ALTER TABLE `tbl_t_keluarga_status_dan_kb`
  MODIFY `id_ksb` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=190;
--
-- AUTO_INCREMENT for table `tbl_t_penduduk`
--
ALTER TABLE `tbl_t_penduduk`
  MODIFY `id_penduduk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
DELIMITER $$
--
-- Events
--
CREATE DEFINER=`root`@`localhost` EVENT `pembayaran` ON SCHEDULE EVERY 1 MONTH STARTS '2018-08-27 10:30:00' ON COMPLETION NOT PRESERVE ENABLE COMMENT 'menunggak pembayaran' DO UPDATE tbl_pembayaran SET keterangan = 'MENUNGGAK' WHERE keterangan = 'BELUM BAYAR'$$

DELIMITER ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
