<?php 
// mengaktifkan session pada php
session_start();

// menghubungkan php dengan koneksi database
if (isset($_POST['login'])) {
  include 'connection.php';

  // menangkap data yang dikirim dari form login
  $username = $_POST['username'];
  $password = $_POST['password'];


  // menyeleksi data user dengan username dan password yang sesuai
  $login = mysqli_query($conn,"SELECT * FROM user where username='$username' and password='$password'");
  // menghitung jumlah data yang ditemukan
  $cek = mysqli_num_rows($login);
  $data = mysqli_fetch_array($login);

  // cek apakah username dan password di temukan pada database
  if($cek > 0){

    $_SESSION['username'] = $data['username'];
    $_SESSION['level'] = $data['level'];

    // cek jika user login sebagai admin
    if($_SESSION['level'] == "admin"){
      // alihkan ke halaman dashboard admin
      header("location:index_admin.php");

    // cek jika user login sebagai pegawai
    } else {

      // alihkan ke halaman login kembali
      header("location:login.php?pesan=gagal");
    } 
  } else {
    header("location:login.php?pesan=gagal");
  }
}

?>