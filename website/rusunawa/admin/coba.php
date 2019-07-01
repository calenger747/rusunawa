<?php

include("connection.php");

// kalau tidak ada id di query string
if( !isset($_GET['id']) ){
    header('Location: form_update.php');
}

//ambil id dari query string
$kode_booking = $_GET['id'];

// buat query untuk ambil data dari database
$sql = "SELECT * FROM booking_unit WHERE kode_booking='$kode_booking'";
$query = mysqli_query($conn, $sql);
$data = mysqli_fetch_assoc($query);

?>



<html>
    <head>
    <title>Pop up</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    
    <link href="https://fonts.googleapis.com/css?family=Poppins:200,300,400,500,600,700" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Playfair+Display:400,400i,700,700i" rel="stylesheet">

    <link rel="stylesheet" href="css/open-iconic-bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
    
    <link rel="stylesheet" href="css/owl.carousel.min.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">
    <link rel="stylesheet" href="css/magnific-popup.css">

    <link rel="stylesheet" href="css/aos.css">

    <link rel="stylesheet" href="css/ionicons.min.css">

    <link rel="stylesheet" href="css/bootstrap-datepicker.css">
    <link rel="stylesheet" href="css/jquery.timepicker.css">

    
    <link rel="stylesheet" href="css/flaticon.css">
    <link rel="stylesheet" href="css/icomoon.css">
    <link rel="stylesheet" href="css/style.css">
  </head>


  <style>
    * {
  margin: 0;
  padding: 0;
  }

  body, html {
  font-family: Calibri, "times new roman", sans-serif;
  }

  #button {
  margin: 5% auto;
  width: 100px;
  text-align: center;
  }

  #button a {
  background-image: linear-gradient(to bottom,#2a95c5,#21759b);
  background-image: -o-linear-gradient(to bottom,#2a95c5,#21759b);
  background-image: -ms-linear-gradient(to bottom,#2a95c5,#21759b);
  background-image: -moz-linear-gradient(to bottom,#2a95c5,#21759b);
  background-image: -webkit-linear-gradient(to bottom,#2a95c5,#21759b);
  background-color: #2e9fd2;
  width: 86px;
  height: 30px;
  vertical-align: middle;
  padding: 10px;
  color: #fff;
  text-decoration: none;
  border: 1px solid transparent;
  border-radius: 5px;
  }

  #popup {
width: 100%;
height: 100%;
position: fixed;
background: rgba(0,0,0,.7);
top: 0;
left: 0;
z-index: 9999;
visibility: visible;
}

.window {
width: 500px;
height: 300px;
background: #fff;
border-radius: 10px;
position: relative;
padding: 10px;
box-shadow: 0 0 5px rgba(0,0,0,.4);
text-align: center;
margin: 15% auto;
}

.close-button {
width: 20px;
height: 20px;
background: #000;
border-radius: 50%;
border: 3px solid #fff;
display: block;
text-align: center;
color: #fff;
text-decoration: none;
position: absolute;
top: -10px;
right: -10px;
}
  </style>

  <body>

<div id="popup">
    <div class="window">
        <a href="#" class="close-button" title="Close">X</a>
        <p>
            <label for="nama">Kode Booking: </label>
            <input type="text" name="kode_booking"  value="<?php echo $data['kode_booking'] ?>" readonly />
        </p>

       <p>
            <label for="nama">Tanggal Booking: </label>
            <input type="text" name="tgl_booking"  value="<?php echo $data['tgl_booking'] ?>" readonly />
        </p>


        <p>
            <label for="nama">Nama: </label>
            <input type="text" name="nama"  value="<?php echo $data['nama'] ?>" />
        </p>
        <p>
            <label for="nama">No Identitas: </label>
            <input type="text" name="no_ktp"  value="<?php echo $data['no_ktp'] ?>" />
        </p>
        <p>
            <label for="alamat">Alamat: </label>
            <textarea name="alamat"><?php echo $data['alamat'] ?></textarea>
        </p>
        <p>
            <label for="sekolah_asal">No Handphone: </label>
            <input type="text" name="no_hp"  value="<?php echo $data['no_hp'] ?>" />
        </p>
        <p>
            <input type="submit" value="Simpan" name="simpan" />
        </p>

    </div>
</div>
</body>
</html>