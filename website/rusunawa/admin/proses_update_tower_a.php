<?php

include("connection.php");

// cek apakah tombol simpan sudah diklik atau blum?
if(isset($_POST['simpan'])){

    // ambil data dari formulir
    $kode = $_POST['kode'];
    $no_unit = $_POST['no_unit'];
    $lantai = $_POST['lantai'];
    $harga = $_POST['harga'];
    $status = $_POST['status'];

    // buat query update
    $sql = "UPDATE tower_a SET no_unit='$no_unit', lantai='$lantai', harga='$harga', status='$status' WHERE kode='$kode'";
    $query = mysqli_query($conn, $sql);

    // apakah query update berhasil?
    if( $query ) {
        // kalau berhasil alihkan ke halaman list-siswa.php
        echo "<script>alert('Data berhasil di update')
            location.href='/rusunawa/admin/index_tower_a.php'</script>";
    } else {
        echo "<script>alert('Gagal mengubah data')
            location.href='/rusunawa/admin/index_tower_a.php'</script>";
    }

}

?>