<?php
error_reporting(0);
include 'connection.php';
$id=$_GET['id'];
$unit=$_GET['kode'];
//$nama=$_POST['nama'];
//$alamat=$_POST['alamat'];

$query="DELETE FROM booking_unit WHERE kode_booking='$id'";
$hasil=mysqli_query($conn,$query);
if ($hasil) {
	$update1 = mysqli_query($conn, "UPDATE tbl_unit SET status = 'Kosong' WHERE id_unit='$unit'");
	echo "<script>alert('Data Berhasil Di hapus')
    location.href='/rusunawa/admin/index_booking.php'</script>";
}else{
    echo "<script>alert('Gagal Hapus Data! Silahkan Coba Lagi')
    location.href='/rusunawa/admin/index_booking.php'</script>";
}

?>