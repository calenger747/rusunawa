<?php

include("connection.php");

// kalau tidak ada id di query string
if( !isset($_GET['id']) ){
    header('Location: form_update_tower_a.php');
}

//ambil id dari query string
$kode = $_GET['id'];

// buat query untuk ambil data dari database
$sql = "SELECT * FROM tower_a WHERE kode='$kode'";
$query = mysqli_query($conn, $sql);
$data = mysqli_fetch_assoc($query);

?>


<!DOCTYPE html>
<html>
<head>
    <title>Form Edit Tower A</title>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"></script>
</head>

<body>
    <form action="proses_update_tower_a.php" method="POST">
    <div class="container">
    <h2><center>Form Update Tower A</center></h2>

           <div class="form-group">
            <label class="control-label">Kode Tower</label>
            <input type="text" name="kode"  value="<?php echo $data['kode'] ?>" readonly class="form-control" />
           </div>

           <div class="form-group">
            <label class="control-label">No Unit</label>
            <input type="text" name="no_unit"  value="<?php echo $data['no_unit'] ?>" readonly
            class="form-control" />
           </div>


           <div class="form-group">
            <label class="control-label">Lantai</label>
            <input type="text" name="lantai"  value="<?php echo $data['lantai'] ?>" 
            class="form-control"/>
           </div>
        

           <div class="form-group">
            <label class="control-label">Harga</label>
            <input type="text" name="harga"  value="<?php echo $data['harga'] ?>" 
            class="form-control" />
           </div>


           <div class="form-group">
            <label class="control-label">Status Unit</label>
            <textarea name="status" class="form-control"><?php echo $data['status'] ?></textarea>
           </div>



           <div>
            <a href="javascript:history.back();" type="exit" class="btn btn-danger" title="Batal edit data">Batal</a>
            <button type="submit" class="btn btn-primary" name="simpan" title="Update data">Simpan</button>
           </div>

        </fieldset>


    </form>

    </body>
</html>