<?php

include("connection.php");

// kalau tidak ada id di query string
if( !isset($_GET['id']) ){
    header('Location: form_update_gallery.php');
}

//ambil id dari query string
$kode = $_GET['id'];

// buat query untuk ambil data dari database
$sql = "SELECT * FROM update_galery WHERE kode='$kode'";
$query = mysqli_query($conn, $sql);
$data = mysqli_fetch_assoc($query);

?>


<!DOCTYPE html>
<html>
<head>
    <title>Form Edit Gallery</title>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"></script>
</head>

<body>
    <form action="proses_update_galery.php" method="POST">
    <div class="container">
    <h2><center>Form Update Gallery</center></h2>

           <div class="form-group">
            <label class="control-label">Kode Gallery</label>
            <input type="text" name="kode"  value="<?php echo $data['kode'] ?>" readonly class="form-control" />
           </div>

           <div class="form-group">
            <label class="control-label">Gallery Kegiatan</label>
            <input type="text" name="gambar"  value="<?php echo $data['gambar'] ?>" readonly
            class="form-control" />
           </div>


           <div class="form-group">
            <label class="control-label">Tanggal</label>
            <input type="text" name="tanggal"  value="<?php echo $data['tanggal'] ?>" 
            class="form-control"/>
           </div>
        

           <div>
            <a href="javascript:history.back();" type="exit" class="btn btn-danger" title="Batal edit data">Batal</a>
            <button type="submit" class="btn btn-primary" name="simpan" title="Update data">Update</button>
           </div>

        </fieldset>


    </form>

    </body>
</html>