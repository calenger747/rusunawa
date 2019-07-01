<?php
include 'connection.php';
$kode_user=$_GET['id'];
//$username=$_POST['username'];
//$password=$_POST['password'];
//$level =$_POST['level'];

$query="DELETE FROM user WHERE kode_user='$kode_user'";
$hasil=mysqli_query($conn,$query);
if ($hasil) {
echo "<script>alert('Data Berhasil Di hapus')
    location.href='/Admin_rusun/index_user.php'</script>";
}else{
    echo "<script>alert('Gagal Hapus Data! Silahkan Coba Lagi')
    location.href='/Admin_rusun/index_user.php'</script>";
}

?>