<?php
include 'connection.php';
$kode=$_GET['id'];
//$username=$_POST['username'];
//$password=$_POST['password'];
//$level =$_POST['level'];

$query="DELETE FROM tower_a WHERE kode='$kode'";
$hasil=mysqli_query($conn,$query);
if ($hasil) {
echo "<script>alert('Data Berhasil Di hapus')
    location.href='/rusunawa/admin/index_tower_a.php'</script>";
}else{
    echo "<script>alert('Gagal Hapus Data! Silahkan Coba Lagi')
    location.href='/rusunawa/admin/index_tower_a.php'</script>";
}

?>