<?php 

//TIMEZONE
date_default_timezone_set("Asia/Jakarta");
$date= date("Y-m-d");
include "connection.php";
$kode =$_POST['kode'];
$tanggal = date("Y-m-d H:i:s");

$nama_file = $_FILES['gambar']['name'];
$source = $_FILES['gambar']['tmp_name'];
$folder ='./images/';

move_uploaded_file($source, $folder.$nama_file);
$query =mysqli_query($conn,"INSERT INTO update_galery (kode,gambar,tanggal) Values ('$kode','$nama_file','$tanggal')");
if ($query) {
	echo "<script>alert('Data Berhasil Ditambahkan')
  location.href='index_galery.php'</script>";
}else{
	echo "<script>alert('Data Gagal Ditambahkan')
  location.href='add_galery.php'</script>";
}

?>