<?php 
include "connection.php";
$kode_sambutan =$_POST['kode_sambutan'];
$kata_sambutan =$_POST['kata_sambutan'];

$nama_file = $_FILES['gambar']['name'];
$source = $_FILES['gambar']['tmp_name'];
$folder ='./images/';

move_uploaded_file($source, $folder.$nama_file);
$query =mysqli_query($conn,"INSERT INTO update_sambutan (kode_sambutan,gambar,kata_sambutan) Values ('$kode_sambutan','$nama_file','$kata_sambutan')");
if ($query) {
	echo "<script>alert('Data Berhasil Ditambahkan')
  location.href='index_sambutan.php'</script>";
}else{
	echo "<script>alert('Data Gagal Ditambahkan')
  location.href='add_sambutan.php'</script>";
}

?>