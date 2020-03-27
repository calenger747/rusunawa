<?php

$host ="localhost";
$user="root";
$pass="";
$db="db_siap";

// $host ="localhost";
// $user="k0762615_rusun1";
// $pass="Rusun123!@#";
// $db="k0762615_rusun";
$conn= mysqli_connect($host,$user,$pass,$db);
if(mysqli_connect_error()){

	echo "Gagal Connect";
}
?>