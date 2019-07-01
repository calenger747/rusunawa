<?php

$host ="localhost";
$user="root";
$pass="";
$db="db_siap";
$conn= mysqli_connect($host,$user,$pass,$db);
if(mysqli_connect_error()){

	echo "Gagal Connect";
}
?>