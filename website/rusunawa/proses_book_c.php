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
	
$query =mysqli_query($conn," INSERT INTO booking_unit (kode_booking,tgl_booking,kode_unit,no_kk,nama,no_ktp,alamat,no_hp) VALUES ('$kode_booking','$tgl_booking','$id_unit','$no_kk','$nama','$no_ktp','$alamat','$no_hp')");// $next7day  =  mktime(0,0,0,0,0,0,0,date("n"),date("j")  +7  ,date("Y"));	        

// $expired    =  date("Y-m-d H:i:s",$next7day);

if ($query) {
	$update = mysqli_query($conn, "UPDATE tower_c SET status = 'Booking' WHERE kode='$id_unit'");
	echo "<script>alert('Terima Kasih Anda Sudah Booking Di Rusunawa Depok, Catat Nomor Booking Anda! Di Mohon Membawa KK dan KTP ke Rusunawa Depok Maksimal 1 Minggu dari sekarang')
	location.href='/deluxe/deluxe/hasil_booking_c.php'</script>";
}else{
	echo "<script>alert('Gagal Booking! Silahkan Coba Lagi')
	location.href='/deluxe/deluxe/booking_tower_c.php'</script>";
}

?>