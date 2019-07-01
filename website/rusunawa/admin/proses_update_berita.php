<?php

include("connection.php");

// cek apakah tombol simpan sudah diklik atau blum?
if(isset($_POST['simpan'])){

    // ambil data dari formulir
    $kode_berita = $_POST['kode_berita'];
    $judul_berita = $_POST['judul_berita'];
    $gambar = $_POST['gambar'];
    $deskripsi = $_POST['deskripsi'];
    // $tanggal = $_POST['tanggal'];

    // buat query update
    $sql = "UPDATE update_berita SET judul_berita='$judul_berita', gambar='$gambar', deskripsi='$deskripsi', tanggal=NOW() WHERE kode_berita='$kode_berita'";
    $query = mysqli_query($conn, $sql);

    // apakah query update berhasil?
    if( $query ) {
        // kalau berhasil alihkan ke halaman list-siswa.php
        echo "<script>alert('Data berhasil di update')
            location.href='/rusunawa/admin/index_berita.php'</script>";
    } else {
        echo "<script>alert('Gagal mengubah data')
            location.href='/rusunawa/admin/index_berita.php'</script>";
    }

}

?>