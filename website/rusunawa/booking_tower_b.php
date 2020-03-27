<!DOCTYPE html>
<html lang="en">
  <head>
    <title>Booking Unit</title>
    <script type="text/javascript" src="js/script.js"></script>
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
  <style type="text/css">
    body{
      background: url('images/web.jpg');
    } 

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
background: rgba(0,0,0,.5);
top: 0;
left: 0;
z-index: 9999;
visibility: visible;
}

.window {
width: 500px;
height: 400px;
background: #fff;
border-radius: 10px;
position: relative;
padding: 10px;
box-shadow: 0 0 80px rgba(0,0,0,.90);
text-align: center;
margin: 10% auto;
}

.close-button {
width: 20px;
height: 20px;
border: -1px solid #fff;
display: block;
text-align: center;
color: #fff;
text-decoration: none;
position: absolute;
top: 6px;
right: 5px;
}
  </style>

<body src="../deluxe/images/background_web.jpg" width=1300 height=300 onload="updateDB();">
<?php 
//KONEKSI DATABASE
$servername = "localhost";
$user = "root";
$pass = "";
$dbname = "rusunawa";

$connection = mysqli_connect($servername, $user, $pass, $dbname);

if (!$connection){
  die ("Connection Failed :". mysqli_connect_error());
}
//TIMEZONE
date_default_timezone_set("Asia/Jakarta");
$date= date("Y-m-d");

// NOMOR URUT ORDER
$query =mysqli_query($connection, "SELECT max(kode_booking) as maxKode FROM booking_unit");
$data = mysqli_fetch_array($query);
$noOrder = $data['maxKode'];
$noUrut = (int) substr($noOrder, 10, 3);
$noUrut++;
$char = "BK";
$tahun=($date = date('Y'));
$bulan=($date = date('m'));
$tgl=($date = date('d'));
$kode_booking = $char .$tahun .$bulan .$tgl . sprintf("%03s", $noUrut);

$kode_unit = $_GET['id'];

$sql = mysqli_query($connection, "SELECT * FROM tower_b WHERE kode='$kode_unit'");
  $row = mysqli_fetch_array($sql);

  $id_unit = $row['kode'];
  $no_unit = $row['no_unit'];
  $lantai = $row['lantai'];
  $harga = $row['harga'];
  $status = $row['status'];
 ?>
<form method="post" action="proses_booking.php">
<div class="container">
<h1><center style="color: white; font-size: 60px;">Booking Request</center></h1>

  <div class="form-group col-sm-3">
     <label style="color: white; font-size: 20px;">Kode Booking</label>
     <input style="opacity: 0.8;" type="text" name="kode_booking" class="form-control" value="<?php echo $kode_booking; ?>" readonly>
     <input style="opacity: 0.8;" type="hidden" name="id_unit" value="<?= $id_unit ?>" placeholder="ID Unit" class="form-control" readonly />
  </div>
  <div class="form-group col-sm-7">
     <label style="color: white; font-size: 20px;">No Kartu Keluarga</label>
     <input style="opacity: 0.8;" type="text" name="no_kk" placeholder="No Kartu Keluarga" class="form-control" required="">
  </div>
  <div class="form-group col-sm-7">
     <label style="color: white; font-size: 20px;">Nama Booking</label>
     <input style="opacity: 0.8;" type="text" name="nama" placeholder="Nama Booking" class="form-control" required="">
  </div>
  <div class="form-group col-sm-7">
     <label style="color: white; font-size: 20px;">Unit DiBooking</label>
     <input style="opacity: 0.8;" type="text" name="unit" value="<?= $lantai.$no_unit ?>" readonly placeholder="No Unit" class="form-control">
  </div>
  <div class="form-group col-sm-7">
     <label style="color: white; font-size: 20px;">Harga Unit</label>
     <input style="opacity: 0.8;" type="text" name="harga" value="<?= $harga ?>" placeholder="harga" class="form-control" readonly />
  </div>
  <div class="form-group col-sm-8">
     <label style="color: white; font-size: 20px;">No.Identitas</label>
     <input style ="opacity: 0.8;" type="text" name="no_ktp" placeholder="No.Ktp" class="form-control" required="">
  </div>
  <div class="form-group col-sm">
     <label style="color: white; font-size: 20px;">Alamat</label>
     <input style="opacity: 0.8;" type="text" name="alamat" placeholder="Alamat Sesuai Ktp" class="form-control" required="">
  </div>
  <div class="form-group col-sm-6">
     <label style="color: white; font-size: 20px;">No.Handphone</label>
     <input style="opacity: 0.8;" type="text" name="no_hp" placeholder="No yang Dapat di hubungi" class="form-control" required="">

     <p style="color: black; font-size: 20px;">NOTE :
  Harap Mencatat KODE BOOKING dengan benar!</p>
  </div>

  <div>
     <a href="javascript:history.back();" type="exit" class="btn btn-danger">Batal</a>
     <button data-target="#popup" type="submit" name="tambah" class="btn btn-info" data-dismiss="modal" >Book Now</button>
  </div>
</div>
    
</div>

</table>
</form>

<script type="text/javascript">
      function updateDB(){
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "/rusunawa/proses-reject-booking.php", true);
        xhr.send(null);
        /* ignore result */
      }
    </script>
</html>