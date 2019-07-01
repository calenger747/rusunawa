<?php 
include "connection.php";
$kode_user =$_POST['kode_user'];
$username =$_POST['username'];
$password =$_POST['password'];
$level =$_POST['level'];
$query =mysqli_query($conn,"INSERT INTO user (kode_user,username,password,level) Values ('$kode_user','$username','$password','$level')");
if ($query) {
	echo "<script>alert('Data Berhasil Ditambahkan')
  location.href='index_user_super.php'</script>";
}else{
	echo "<script>alert('Data Gagal Ditambahkan')
  location.href='index_user_super.php'</script>";
}

?>