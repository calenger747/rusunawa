<?php 
date_default_timezone_set('Asia/Jakarta');
include "connection.php";
$kode_berita =$_POST['kode_berita'];
$judul_berita =$_POST['judul_berita'];
$deskripsi =$_POST['deskripsi'];
$tanggal = date ("Y-m-d H:i:s");

$nama_file = $_FILES['gambar']['name'];
$source = $_FILES['gambar']['tmp_name'];
$folder ='./images/';

move_uploaded_file($source, $folder.$nama_file);
$query =mysqli_query($conn,"INSERT INTO update_berita (kode_berita,judul_berita,gambar,deskripsi,tanggal) Values ('$kode_berita',,'$judul_berita',$nama_file','$deskripsi','$tanggal')");
if ($query) {
	echo "<script>alert('Data Berhasil Ditambahkan')
  location.href='index_berita.php'</script>";
}else{
	echo "<script>alert('Data Gagal Ditambahkan')
  location.href='add_berita.php'</script>";
}

?>