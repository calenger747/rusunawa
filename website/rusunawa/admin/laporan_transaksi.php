<?php
    $start_date = strtotime(date('Y-m-d H:i:s'));
    $end_date = strtotime('+7 days', strtotime($start_date));
    $todays_date = strtotime(date('Y-m-d H:i:s'));
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

    <title> laporan transaksi </title>
    <!-- Bootstrap core CSS-->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">

    <!-- Page level plugin CSS-->
    <link href="vendor/datatables/dataTables.bootstrap4.css" rel="stylesheet">

    <!-- Custom styles for this template-->
    <link href="css/sb-admin.css" rel="stylesheet">

    <link href="https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css" rel="stylesheet">
    <link href="https://cdn.datatables.net/buttons/1.5.6/css/buttons.dataTables.min.css" rel="stylesheet">


    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/css/bootstrap-datepicker3.css"/>

    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
  <script type="text/javascript" src="js/jquery.js"></script>
  <script type="text/javascript" src="js/bootstrap.js"></script>

  </head>

  <body id="page-top">

    <nav class="navbar navbar-expand navbar-dark bg-dark static-top">

      <a class="navbar-brand mr-1" href="index_admin.php">Rusunawa</a>

      <button class="btn btn-link btn-sm text-white order-1 order-sm-0" id="sidebarToggle" href="#">
        <i class="fas fa-bars"></i>
      </button>

      <!-- Navbar Search -->
      <form class="d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0">
        <div class="input-group">
          <!-- <input type="text" class="form-control" placeholder="Search for..." aria-label="Search" aria-describedby="basic-addon2">
          <div class="input-group-append">
            <button class="btn btn-primary" type="button">
              <i class="fas fa-search"></i>
            </button> -->
          </div>
        </div>
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

                  <div id="content-wrapper">
  
  
        <div class="container-fluid">

          <!-- Breadcrumbs-->
          <ol class="breadcrumb">
            <li class="breadcrumb-item">
              <a href="#">Dashboard</a>
            </li>
            <li class="breadcrumb-item active">Data Transaksi Pembayaran Unit</li>
          </ol>

<!-- Tombol untuk menampilkan modal-->
  <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">export</button>
 
     <!-- Modal -->
      <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
          <!-- konten modal-->
          <div class="modal-content">
            <!-- heading modal -->
            <div class="modal-header">
              <h4 class="modal-title text-left">Menu</h4>
              <button type="button" class="close" data-dismiss="modal">&times;</button>
            </div>
            <!-- body modal -->
            <form class="form-horizontal" method="POST" action="excel_transaksi.php">
              <div class="modal-body">
                <div class="form-group row">
                  <label for="fname" class="col-sm-3 text-left control-label
                 col-form-label">All Bulan</label>
                  <div class="col-sm-9">
                    <div class="form-check-inline form-check">
                      <label class="form-check-label" for="all"> <input type="radio" name="first" value="Ya" class="form-check-input" required=""> Yes  </label> &nbsp
                      <label class="form-check-label" for="no"> <input type="radio" name="first" value="Tidak" class="form-check-input" required=""> No  </label>
                    </div>
                    <input type="hidden" name="bulan" value="All" id="yes" class="all" readonly="">
                  </div>
                </div>
                <div class="form-group row">
                  <label for="fname" class="col-sm-3 text-left control-label
                 col-form-label">Bulan</label>
                  <div class="col-sm-9">
                    <div class="input-group">
                      <input class="form-control no" id="date" name="bulan" type="text" required="" />
                    </div>
                  </div>
                </div>
                <div class="form-group row">
                  <label for="fname" class="col-sm-3 text-left control-label
                 col-form-label">Status</label>
                  <div class="col-sm-9">
                      <select name="status" class="form-control" id="type" required="">
                        <option value="">Status</option>
                        <option value="All">All</option>
                        <option value="LUNAS">Lunas</option>
                        <option value="BELUM BAYAR">Belum Bayar</option>
                        <option value="MENUNGGAK">Menunggak</option>
                      </select>
                    </div>
                </div>
              </div>
            <!-- footer modal -->
              <div class="modal-footer">
                <input type="submit" name="export" class="btn btn-primary pull-right" id="submit" value="EXPORT">
              </div>
            </form>
          </div>
        </div>
      </div>
       </div>
          <br/>
          <!-- DataTables Example -->
          <form acion="update_booking.php" method="post">
          <div class="card mb-3">
            <div class="card-header">
              <i class="fas fa-table"></i>
              Data Transaksi Pembayaran Unit</div>
            <div class="card-body">
              <div class="table-responsive">
                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                  <thead>
                    <tr>
                      <th>no. transaksi</th>
                      <th>tanggal transaksi</th>
                      <th>Jatuh tempo</th>
                      <th>Id pelanggan</th>
                      <th>Nama</th>
                      <th>Bulan</th>
                      <th>jumlah</th>
                      <th>Keterangan</th>
                    </tr>
                  </thead>
                    <?php
                    include 'connection.php';
                    $query="SELECT * FROM tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan JOIN tbl_keluarga ON tbl_keluarga.id_penghuni = tbl_pembayaran.id_pelanggan";
                    $result=mysqli_query($conn,$query);
                    while ($data=mysqli_fetch_array($result)) {
                    echo "<tr align='center'>
                    <td>".$data['no_transaksi']."</td>
                    <td>".$data['tgl_transaksi']."</td>
                    <td>".$data['jatuh_tempo']."</td>
                    <td>".$data['id_pelanggan']."</td>
                    <td>".$data['nama_kk']."</td>
                    <td>".$data['bulan']."</td>
                    <td>".$data['jumlah']."</td>
                    <td>".$data['keterangan']."</td>"; ?>
                    
                <?php
              }
              ?>
   
                </table>
              </div>
            </div>




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

    <?php 
      include 'connection.php';

      $waktu=7;
      $query= "DELETE FROM booking_unit WHERE DATEDIFF(CURDATE,tanggal) > $waktu";
      $hasil=mysqli_query($conn, $query);


    ?>


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

    <script src="https://code.jquery.com/jquery-3.3.1.js"></script>
    <script src="https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js"></script>
    <script src="https://cdn.datatables.net/buttons/1.5.6/js/dataTables.buttons.min.js"></script>
    <script src="https://cdn.datatables.net/buttons/1.5.6/js/buttons.flash.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js"></script>
    <script src="https://cdn.datatables.net/buttons/1.5.6/js/buttons.html5.min.js"></script>
    <script src="https://cdn.datatables.net/buttons/1.5.6/js/buttons.print.min.js"></script>  

    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/js/bootstrap-datepicker.min.js"></script>
    <script>
    $(document).ready(function(){
    var date_input=$('input[name="bulan"]'); //our date input has the name "date"
    var container=$('.bootstrap-iso form').lenght>0 ? $('.bootstrap-iso-form').parent() : "body";
      date_input.datepicker({
        format: 'MM yyyy',
        container: container,
        viewMode: "months",
        minViewMode: "months",
        autoclose: true,
      })
    })
    </script>

    <script type="text/javascript">
    $(document).ready(function() {
        $('#example').DataTable( {
            dom: 'Bfrtip',
            buttons: [
                'excel', 'pdf'
            ]
        } );
    } );
    </script>

    <script type="text/javascript">
      function updateDB(){
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "/rusunawa/proses-reject-booking.php", true);
        xhr.send(null);
        /* ignore result */
      }
    </script>

    <script type="text/javascript">
      $(document).ready(function(){
        $('$date').change(function(){
          var bulan = documentGetElementById('date').value;
          
        });
      });
      $(document).ready(function(){
        $(".all").attr('disabled', true);
        $(".no").attr('disabled', true);

        $("form input:radio").change(function() {
          if ($(this).val() == "Ya") {
            $(".all").attr('disabled', false);
            $(".no").attr('disabled', true);

          } else if ($(this).val() == "Tidak"){
            $(".all").attr('disabled', true);
            $(".no").attr('disabled', false);
          }
        });
      });
    </script>


  </body>
</form>
</html>