<?php

include("connection.php");

// cek apakah tombol simpan sudah diklik atau blum?
if(isset($_POST['simpan'])){

    // ambil data dari formulir
    $kode_booking = $_POST['kode_booking'];
    $tgl_booking = $_POST['tgl_booking'];
    $nama = $_POST['nama'];
    $no_ktp = $_POST['no_ktp'];
    $alamat = $_POST['alamat'];
    $no_hp = $_POST['no_hp'];

    // buat query update
    $sql = "UPDATE booking_unit SET tgl_booking='$tgl_booking', nama='$nama', no_ktp='$no_ktp', alamat='$alamat', no_hp='$no_hp' WHERE kode_booking=$kode_booking";
    $query = mysqli_query($db, $sql);

    // apakah query update berhasil?
    if( $query ) {
    echo "<script>alert('Data Berhasil Diupdate')
  location.href='index_booking.php'</script>";
}else{
    echo "<script>alert('Data Gagal Ditambahkan')
  location.href='form_update_booking.php'</script>";
}

?>