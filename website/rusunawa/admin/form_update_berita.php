<?php

include("connection.php");

// kalau tidak ada id di query string
if( !isset($_GET['id']) ){
    header('Location: form_update_berita.php');
}

//ambil id dari query string
$kode_berita = $_GET['id'];

// buat query untuk ambil data dari database
$sql = "SELECT * FROM update_berita WHERE kode_berita='$kode_berita'";
$query = mysqli_query($conn, $sql);
$data = mysqli_fetch_assoc($query);

?>


<!DOCTYPE html>
<html>
<head>
    <title>Form Edit Berita</title>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"></script>
  <script type="text/javascript" src="ckeditor/ckeditor.js"></script>
</head>

<body>
    <form action="proses_update_berita.php" method="POST">
    <div class="container">
    <h2><center>Form Update Berita</center></h2>

        <div class="container">
           <div class="form-group">
            <label class="control-label">Kode Berita</label>
            <input type="text" name="kode_berita"  value="<?php echo $data['kode_berita'] ?>" readonly class="form-control" />
           </div>

           <div class="form-group">
            <label class="control-label">Judul Berita</label>
            <input type="text" name="judul_berita"  value="<?php echo $data['judul_berita'] ?>" class="form-control" />
           </div>

           <div class="form-group">
            <label class="control-label">Gambar Berita</label>
            <input type="text" name="gambar"  value="<?php echo $data['gambar'] ?>" readonly
            class="form-control" />
           </div>

           <div class="form-group">
            <label class="control-label">Deskripsi Berita</label>
            <textarea class="ckeditor" name="deskripsi" id="ckedtor" ><?php echo $data['deskripsi']; ?>
            </textarea>
           </div>
           <br>

           <div>
            <a href="javascript:history.back();" type="exit" class="btn btn-danger" title="Batal edit data">Batal</a>
            <button type="submit" class="btn btn-primary" name="simpan" title="Update data">Update</button>
           </div>
        </div>   

    </form>
    </div>
    </body>
</html>