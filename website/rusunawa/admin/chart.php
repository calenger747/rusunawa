<?php

 include('connection.php');

 $date = date ("F Y");
 // $date = "Februari 2019";

 //cart unit
 $kapasitas = mysqli_query($conn, "SELECT * from tbl_unit");
 $jum_kps = mysqli_num_rows($kapasitas);

 $unit_rs = mysqli_query($conn, "SELECT * from tbl_unit where status = 'Rusak Ringan'");
 $jum_urs = mysqli_num_rows($unit_rs);

 $unit_rb = mysqli_query($conn, "SELECT * from tbl_unit where status = 'Rusak Ringan'");
 $jum_urb = mysqli_num_rows($unit_rb);

 $unit_isi = mysqli_query($conn, "SELECT * from tbl_unit where status = 'Isi'");
 $jum_isi = mysqli_num_rows($unit_isi);

 $unit_ksg = mysqli_query($conn, "SELECT * from tbl_unit where status = 'Kosong' OR status = 'Booking'");
 $jum_ksg = mysqli_num_rows($unit_ksg);

 $persentase = round($jum_isi/$jum_kps * 100,2);


 $max = mysqli_query($conn, "SELECT SUM(harga) from tbl_unit") or die(mysqli_error($conn));
 while ($row = mysqli_fetch_array($max)) {
  $total_max = $row['SUM(harga)'];
 }

 $opt = mysqli_query($conn, "SELECT SUM(harga) from tbl_unit WHERE status != 'Rusak Ringan' AND status != 'Rusak Berat'") or die (mysqli_error($conn));
 while ($row2 = mysqli_fetch_array($opt)) {
  $total_opt = $row2['SUM(harga)'];
 }

 $rep = mysqli_query($conn, "SELECT SUM(harga) from tbl_unit WHERE status = 'isi'") or die (mysqli_error($conn));
 while ($row3 = mysqli_fetch_array($rep)) {
  $total_rep = $row3['SUM(harga)'];
 }

 $pre = mysqli_query($conn, "SELECT SUM(tbl_pembayaran.jumlah) from tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan WHERE tbl_pembayaran.bulan = '$date' AND tbl_pembayaran.keterangan = 'LUNAS'") or die (mysqli_error($conn));
 while ($row4 = mysqli_fetch_array($pre)) {
  $total_pre = $row4['SUM(tbl_pembayaran.jumlah)'];
 }

 $mng = mysqli_query($conn, "SELECT SUM(tbl_pembayaran.jumlah) from tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan WHERE tbl_pembayaran.bulan = '$date' AND tbl_pembayaran.keterangan != 'LUNAS'") or die (mysqli_error($conn));
 while ($row5 = mysqli_fetch_array($mng)) {
  $total_mng = $row5['SUM(tbl_pembayaran.jumlah)'];
 }
?>	