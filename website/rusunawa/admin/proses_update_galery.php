<?php

include("connection.php");

// cek apakah tombol simpan sudah diklik atau blum?
if(isset($_POST['simpan'])){

    // ambil data dari formulir
    $kode = $_POST['kode'];
    $gambar = $_POST['gambar'];
    $tanggal = $_POST['tanggal'];

    // buat query update
    $sql = "UPDATE update_galery SET gambar='$gambar', tanggal='$tanggal' WHERE kode='$kode'";
    $query = mysqli_query($conn, $sql);

    // apakah query update berhasil?
    if( $query ) {
        // kalau berhasil alihkan ke halaman list-siswa.php
        echo "<script>alert('Data berhasil di update')
            location.href='/rusunawa/admin/index_galery.php'</script>";
    } else {
        echo "<script>alert('Gagal mengubah data')
            location.href='/rusunawa/admin/index_galery.php'</script>";
    }

}

?>