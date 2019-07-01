<?php
include 'connection.php';
$kode_sambutan=$_GET['id'];
//$username=$_POST['username'];
//$password=$_POST['password'];
//$level =$_POST['level'];

$query="DELETE FROM update_sambutan WHERE kode_sambutan='$kode_sambutan'";
$hasil=mysqli_query($conn,$query);
if ($hasil) {
echo "<script>alert('Data Berhasil Di hapus')
    location.href='/rusunawa/admin/index_sambutan.php'</script>";
}else{
    echo "<script>alert('Gagal Hapus Data! Silahkan Coba Lagi')
    location.href='/rusunawa/admin/index_sambutan.php'</script>";
}

?>