<?php

include("connection.php");

// kalau tidak ada id di query string
if( !isset($_GET['id']) ){
    header('Location: form_update_booking.php');
}

//ambil id dari query string
$kode_booking = $_GET['id'];

// buat query untuk ambil data dari database
$sql = "SELECT * FROM booking_unit WHERE kode_booking='$kode_booking'";
$query = mysqli_query($conn, $sql);
$data = mysqli_fetch_assoc($query);

?>


<!DOCTYPE html>
<html>
<head>
    <title>Form Edit Booking</title>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"></script>
</head>

<body>
    <form action="proses_update.php" method="POST">
    <div class="container">
    <h2><center>Form Update Booking</center></h2>

           <div class="form-group">
            <label class="control-label">Kode Booking</label>
            <input type="text" name="kode_booking"  value="<?php echo $data['kode_booking'] ?>" readonly class="form-control" />
           </div>

           <div class="form-group">
            <label class="control-label">Tanggal Booking</label>
            <input type="text" name="tgl_booking"  value="<?php echo $data['tgl_booking'] ?>" readonly
            class="form-control" />
           </div>


           <div class="form-group">
            <label class="control-label">Nama</label>
            <input type="text" name="nama"  value="<?php echo $data['nama'] ?>" 
            class="form-control"/>
           </div>
        

           <div class="form-group">
            <label class="control-label">No Identitas</label>
            <input type="text" name="no_ktp"  value="<?php echo $data['no_ktp'] ?>" 
            class="form-control" />
           </div>


           <div class="form-group">
            <label class="control-label">Alamat</label>
            <textarea name="alamat" class="form-control"><?php echo $data['alamat'] ?></textarea>
           </div>


           <div class="form-group">
            <label class="control-label">No Handphone</label>
            <input type="text" name="no_hp"  value="<?php echo $data['no_hp'] ?>"
            class="form-control" />
           </div>

           <div>
            <a href="/rusunawa/admin/index_booking.php" class="btn btn-danger" title="Batal edit data">Exit</a>
            <button type="submit" class="btn btn-primary" name="simpan" title="Update data">Update</button>
           </div>

        </fieldset>


    </form>
    <script type="text/javascript">
      function updateDB(){
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "/rusunawa/proses-reject-booking.php", true);
        xhr.send(null);
        /* ignore result */
      }
    </script>

    </body>

</html>