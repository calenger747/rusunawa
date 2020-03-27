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

    <title>booking rusunawa </title>
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

  </head>

  <body id="page-top" onload="updateDB();">

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
            <li class="breadcrumb-item active">Data Booking Rusunawa</li>
          </ol>


          <br/>
          <!-- DataTables Example -->
          <form acion="update_booking.php" method="post">
          <div class="card mb-3">
            <div class="card-header">
              <i class="fas fa-table"></i>
              Data Booking Unit</div>
            <div class="card-body">
              <div class="table-responsive">
                <table class="table table-bordered" id="example" width="100%" cellspacing="0">
                  <thead>
                    <tr>
                      <th>Kode Booking</th>
                      <th>Tangggal Booking</th>
                      <th>Unit</th>
                      <th>Nama</th>
                      <th>No.Identitas</th>
                      <th>Alamat</th>
                      <th>No.Handphone</th>
                      <th>Status</th>
                      <th cols="2">Action</th>
                    </tr>
                  </thead>
                    <?php
                    include 'connection.php';

                    $query="SELECT * FROM booking_unit";
                    $result=mysqli_query($conn,$query);
                    while ($data=mysqli_fetch_array($result)) { ?>
                    <tr>
                      <td><?= $data['kode_booking'] ?></td>
                      <td><?= $data['tgl_booking'] ?></td>
                      <td><?= $data['kode_unit'] ?></td>
                      <td><?= $data['nama'] ?></td>
                      <td><?= $data['no_ktp'] ?></td>
                      <td><?= $data['alamat'] ?></td>
                      <td><?= $data['no_hp'] ?></td>
                      <td><?= $data['status'] ?></td>
                      <td>
                          <li name="delete" class="btn btn btn-sm" value="delete" title="Hapus Data">
                            <a href="hapus_booking.php?id=<?php echo $data['kode_booking'];?>&kode=<?php echo $data['kode_unit'];?>" onClick="return confirm('Anda Yakin Ingin Menghapus Data <?php echo $data['kode_booking'];?> ?')">
                              <i class="fas fa-trash"></i>
                            </a>
                          </li>
                          <li name="update" class="btn btn btn-sm" value="update" title="Edit Data">
                            <a href="form_update_booking.php?id=<?php echo $data['kode_booking'];?>">
                              <i class="fas fa-paperclip"></i>
                            </a>
                          </li>
                          <?php if ($data['status'] == 'Done'){ ?>
                              <li name="reject" class="btn btn btn-sm" value="Reject" title="Reject Data">
                                <a href="reject_booking.php?id=<?php echo $data['kode_booking'];?>&kode=<?php echo $data['kode_unit'];?>" onClick="return confirm('Anda Yakin Ingin Mereject Data <?php echo $data['kode_booking'];?> ?')">
                                  <i class="fas fa-times"></i>
                                </a>
                              </li>
                          <?php } else if($data['status'] == 'Pending'){ ?>
                              <li name="approve" class="btn btn btn-sm" value="approve" title="diterima">
                                <a href="check.php?id=<?php echo $data['kode_booking'];?>&kode=<?php echo $data['kode_unit'];?>">
                                  <i class="fas fa-check"></i>
                                </a>
                              </li>
                              <li name="reject" class="btn btn btn-sm" value="Reject" title="Reject Data">
                                <a href="reject_booking.php?id=<?php echo $data['kode_booking'];?>&kode=<?php echo $data['kode_unit'];?>" onClick="return confirm('Anda Yakin Ingin Mereject Data <?php echo $data['kode_booking'];?> ?')">
                                  <i class="fas fa-times"></i>
                                </a>
                              </li>
                          <?php } else { ?>
                              <li name="approve" class="btn btn btn-sm" value="approve" title="diterima">
                                <a href="check.php?id=<?php echo $data['kode_booking'];?>&kode=<?php echo $data['kode_unit'];?>">
                                  <i class="fas fa-check"></i>
                                </a>
                              </li>
                          <?php } ?>
                      </td>
                    </tr>
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

    <script type="text/javascript">
      function updateDB(){
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "/rusunawa/proses-reject-booking.php", true);
        xhr.send(null);
        /* ignore result */
      }
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

  </body>
</form>
</html>