<?php 
include "connection.php"; 
$kode_booking =$_POST['kode_booking'];
$nama =$_POST['nama'];
$unit =$_POST['unit'];
$lantai =$_POST['lantai'];
$no_unit =$_POST['no_unit'];
$harga =$_POST['harga'];
$jumlah_penghuni =$_POST['jumlah_penghuni'];
$tgl_book =$_POST['tgl_book'];
$tgl_masuk =$_POST['tgl_masuk'];
$query =mysqli_query($conn,"INSERT INTO booking (kode_booking,nama,unit,lantai,no_unit,harga,jumlah_penghuni,tgl_book,tgl_masuk) Values ('$kode_booking','$nama','$unit','$lantai','$no_unit','$harga','$jumlah_penghuni','$tgl_book','$tgl_masuk')");
if ($query) {
	echo "<script>alert('Data Sukses')
	location.href='header_booking.php'</script>";
}else{
	echo "Data Gagal";
}

?>