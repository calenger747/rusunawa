<?php 
 	include('connection.php');

 	date_default_timezone_set('Asia/Jakarta');
 	$tgl1 = date ("Y-m-d H:i:s");
 	$tgl2= date ('Y-m-d H:i:s', strtotime('+2 days', strtotime($tgl1)));
 	$tgl3= date ('Y-m-d H:i:s', strtotime('-2 days', strtotime($tgl1)));

 	$sql	= "SELECT * FROM booking_unit WHERE status = 'pending' AND tgl_booking NOT BETWEEN '$tgl3' AND '$tgl2'";
 	$process 	= mysqli_query($conn, $sql);
 	$num		= mysqli_num_rows($process);

 	if ($num > 0) {
		while ($rows = mysqli_fetch_array($process)) {
			$reject = mysqli_query($conn ,"UPDATE booking_unit SET status = 'REJECT' WHERE kode_booking = '".$rows['kode_booking']."'");
			// $unit = mysqli_query($conn, "UPDATE tbl_unit SET status = 'kosong' Where id_unit = '".$rows ['kode_unit']."'");
		}

 	}

 ?>