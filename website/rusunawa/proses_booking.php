<?php 

date_default_timezone_set('Asia/Jakarta');
include 'connection.php';   
	$kode_booking = $_POST['kode_booking'];
	$id_unit =$_POST['id_unit'];
	$tgl_booking = date ("Y-m-d H:i:s");
	$no_kk =$_POST['no_kk'];
	$nama =$_POST['nama'];
	$no_ktp =$_POST['no_ktp'];
	$alamat =$_POST['alamat'];
	$no_hp =$_POST['no_hp'];
	
$query =mysqli_query($conn," INSERT INTO booking_unit (kode_booking,tgl_booking,kode_unit,no_kk,nama,no_ktp,alamat,no_hp) VALUES ('$kode_booking','$tgl_booking','$id_unit','$no_kk','$nama','$no_ktp','$alamat','$no_hp')");

if ($query) {
	$update = mysqli_query($conn, "UPDATE tbl_unit SET status = 'Booking' WHERE id_unit='$id_unit'");
	echo "<script>alert('Terima Kasih Anda Sudah Booking Di Rusunawa Depok, Catat Nomor Booking Anda! Di Mohon Membawa KK dan KTP ke Rusunawa Depok Maksimal 2 Minggu dari sekarang')
	window.open(
	  '/rusunawa/hasil_booking.php?id=".$kode_booking."',
	  '_blank'
	);
	location.href='/rusunawa/unit.php'</script>";
}else{
	echo "<script>alert('Gagal Booking! Silahkan Coba Lagi')
	location.href='/rusunawa/unit.php'</script>";
}

?>