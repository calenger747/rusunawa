<?php 
include "connection.php";
$kode =$_POST['kode'];
$lantai =$_POST['lantai'];
$no_unit =$_POST['no_unit'];
$harga =$_POST['harga'];
$status =$_POST['status'];
$query =mysqli_query($conn,"INSERT INTO tower_a (kode,lantai,no_unit,harga,status) Values ('$kode','$lantai','$no_unit','$harga','$status')");
if ($query) {
	echo "<script>alert('Data Berhasil Ditambahkan')
  location.href='index_tower_a.php'</script>";
}else{
	echo "<script>alert('Data Gagal Ditambahkan')
  location.href='index_tower_a.php'</script>";
}

?>