<?php
  session_start();
  if(!isset($_SESSION['username'])) {
    header('location:/rusunawa/admin/login.php');
  } else {
      $username = $_SESSION['username'];
  }
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Update Sambutan Terkini</title>
    <!-- Bootstrap core CSS-->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <!-- Page level plugin CSS-->
    <link href="vendor/datatables/dataTables.bootstrap4.css" rel="stylesheet">
    <!-- Custom styles for this template-->
    <link href="css/sb-admin.css" rel="stylesheet">
    <script type="text/javascript" src="ckeditor/ckeditor.js"></script>
</head>

<body id="page-top">
    <nav class="navbar navbar-expand navbar-dark bg-dark static-top">
        <a class="navbar-brand" href="index_admin.php">Rusunawa</a>
        <button class="btn btn-link btn-sm text-white order-1 order-sm-0" id="sidebarToggle" href="#">
            <i class="fas fa-bars"></i>
        </button>
        <!-- Navbar Search -->
        <form class="d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0">
            <!-- <div class="input-group">
          <input type="text" class="form-control" placeholder="Search for..." aria-label="Search" aria-describedby="basic-addon2">
          <div class="input-group-append">
            <button class="btn btn-primary" type="button">
              <i class="fas fa-search"></i>
            </button>
          </div>
        </div> -->
        </form>
        <div class="nav-item dropdown no-arrow">
            <a class="nav-link dropdown-toggle" href="#" id="userDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i class="fas fa-user-circle fa-fw"></i>
            </a>
            <div class="dropdown-menu dropdown-menu-right" aria-labelledby="userDropdown">
                <a class="dropdown-item" href="logout.php" data-toggle="modal" data-target="#logoutModal">Logout</a>
            </div>
        </div>
    </nav>
    <div id="wrapper">
        <?php include('sidebar.php'); ?>
        <div id="content-wrapper">
            <div class="container-fluid">
                <!-- Breadcrumbs-->
                <ol class="breadcrumb">
                    <li class="breadcrumb-item">
                        <a></a>
                    </li>
                    <li class="breadcrumb-item active">Selamat Datang Di Rusunawa Depok</li>
                </ol>
                
                <?php include('nav-button.php'); ?>

                <?php
          include 'connection.php';
            $carikode = mysqli_query($conn, "SELECT max(kode_sambutan) FROM update_sambutan")   or die (mysql_error());
            $datakode = mysqli_fetch_array($carikode);
              if ($datakode) {
                $nilaikode = substr($datakode[0],2);
                $kode_sambutan = (int) $nilaikode;
                $kode_sambutan = $kode_sambutan +1;
                $hasilkode = "BS" .str_pad($kode_sambutan, 3, "0", STR_PAD_LEFT);
              } else {
                $hasilkode = "BS001";
              }
          ?>
                <!-- DataTables Example -->
                <div class="card mb-3">
                    <div class="card-header">
                        <i class="fas fa-list"></i>
                        Sambutan Kepala UPT Rusunawa </div>
                    <form action="proses_sambutan.php" method="post" enctype="multipart/form-data">
                        <div class="container">
                            <h1>
                                <center style=" font-size: 30px;">Form Update Sambutan Terkini</center>
                            </h1>
                            <div class="form-group col-sm-3">
                                <label style=" font-size: 20px;">Kode Sambutan</label>
                                <input type="text" name="kode_sambutan" class="form-control" value="<?php echo $hasilkode; ?>" readonly>
                            </div>
                            <div class="col-sm-3">
                                <label style=" font-size: 20px;">Foto Kepala UPT.Rusunawa </label>
                                <input type="file" name="gambar" id="gambar">
                            </div><br />
                            <div class="form-group col-sm-12">
                                <label style=" font-size: 20px;">Kata Sambutan</label>
                                <textarea class="ckeditor" rows="5" id="ckedtor" name="kata_sambutan" placeholder="Kata Sambutan"></textarea>
                            </div>
                            <div class="form-group col-sm-7">
                                <a href="" type="exit" class="btn btn-danger">Batal</a>
                                <button type="submit" name="tambah" class="btn btn-info">Simpan</button>
                            </div>
                        </div>
                        </table>
                    </form>
                    <div class="card-footer small text-muted">Updated yesterday at 11:59 PM</div>
                </div>
            </div>
            <!-- /.container-fluid -->
            <!-- Sticky Footer -->
            <footer class="sticky-footer">
                <div class="container my-auto">
                    <div class="copyright text-center my-auto">
                        <span>Copyright © by Admin Rusunawa 2019</span>
                    </div>
                </div>
            </footer>
        </div>
        <!-- /.content-wrapper -->
    </div>
    <!-- /#wrapper -->
    <!-- Scroll to Top Button-->
    <a class="scroll-to-top rounded" href="#page-top">
        <i class="fas fa-angle-up"></i>
    </a>
    <!-- Logout Modal-->
    <div class="modal fade" id="logoutModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Ready to Leave?</h5>
                    <button class="close" type="button" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">×</span>
                    </button>
                </div>
                <div class="modal-body">Select "Logout" below if you are ready to end your current session.</div>
                <div class="modal-footer">
                    <button class="btn btn-secondary" type="button" data-dismiss="modal">Cancel</button>
                    <a class="btn btn-primary" href="logout.php">Logout</a>
                </div>
            </div>
        </div>
    </div>
    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>
    <!-- Page level plugin JavaScript-->
    <script src="vendor/chart.js/Chart.min.js"></script>
    <script src="vendor/datatables/jquery.dataTables.js"></script>
    <script src="vendor/datatables/dataTables.bootstrap4.js"></script>
    <!-- Custom scripts for all pages-->
    <script src="js/sb-admin.min.js"></script>
    <!-- Demo scripts for this page-->
    <script src="js/demo/datatables-demo.js"></script>
    <script src="js/demo/chart-area-demo.js"></script>
</body>

</html>