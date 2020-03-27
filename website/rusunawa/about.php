<!DOCTYPE html>
<html lang="en">
  <head>
    <title>Tentang Kami</title>
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
  <body>

    <?php include('navigation.php'); ?>
    <!-- END nav -->

    <div class="hero-wrap" style="background-image: url('images/f.jpg');">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text d-flex align-itemd-end justify-content-center">
          <div class="col-md-9 ftco-animate text-center d-flex align-items-end justify-content-center">
          	<div class="text">
	            <h1 class="mb-4 bread">Tentang Kami</h1>
            </div>
          </div>
        </div>
      </div>
    </div>

    <section class="ftco-section ftco-counter img" id="section-counter" style="background-image: url(images/bg_1.jpg);">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-10">
                    <div class="row">
                        <div class="col-md-3 d-flex justify-content-center counter-wrap ftco-animate">
                            <div class="block-18 text-center">
                                <div class="text">
                                    <?php
                                        include('connection.php');
                                        $result = mysqli_query($conn, "SELECT * FROM tbl_unit");
                                        $num_rows = mysqli_num_rows($result);
                                    ?>
                                    <strong class="number" data-number="<?=$num_rows ?>">0</strong>
                                    <span>Total Unit Tower</span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3 d-flex justify-content-center counter-wrap ftco-animate">
                            <div class="block-18 text-center">
                                <div class="text">
                                    <?php
                                        include('connection.php');
                                        $result = mysqli_query($conn, "SELECT * FROM tbl_unit WHERE gedung='A' AND status='Kosong'");
                                        $num_rows = mysqli_num_rows($result);
                                    ?>
                                    <strong class="number" data-number="<?=$num_rows ?>">0</strong>
                                    <span>Tower A Tersedia</span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3 d-flex justify-content-center counter-wrap ftco-animate">
                            <div class="block-18 text-center">
                                <div class="text">
                                    <?php
                                        include('connection.php');
                                        $result = mysqli_query($conn, "SELECT * FROM tbl_unit WHERE gedung='B' AND status='Kosong'");
                                        $num_rows = mysqli_num_rows($result);
                                    ?>
                                    <strong class="number" data-number="<?=$num_rows ?>">0</strong>
                                    <span>Tower B Tersedia</span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3 d-flex justify-content-center counter-wrap ftco-animate">
                            <div class="block-18 text-center">
                                <div class="text">
                                    <?php
                                        include('connection.php');
                                        $result = mysqli_query($conn, "SELECT * FROM tbl_unit WHERE gedung='C' AND status='Kosong'");
                                        $num_rows = mysqli_num_rows($result);
                                    ?>
                                    <strong class="number" data-number="<?=$num_rows ?>">0</strong>
                                    <span>Tower C Tersedia</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>


     <?php
  
        include 'connection.php';
          $tampil=mysqli_query($conn, "SELECT * FROM update_sambutan WHERE kode_sambutan");
          $row=mysqli_fetch_array($tampil);
          // Menampilkan input dari form
      $sql = mysqli_query($conn,"SELECT * FROM update_sambutan WHERE kode_sambutan IN(SELECT MAX(kode_sambutan)FROM update_sambutan)");
    $row = mysqli_fetch_array($sql);
    $kode_sambutan = $row['kode_sambutan'];
    $gambar = $row['gambar'];
    $kata_sambutan = $row['kata_sambutan'];
    ?>


    <section class="ftco-section ftc-no-pb ftc-no-pt">
      <div class="container">
				<div class="row">
        <div style="margin-top: 30px;">
            <span class="subheading">Welcome to Rusunawa </span>
                <h2 class="mb-4">Sambutan Kepala UPT Rusunawa Depok</h2>
          </div>
          <div style=" text-align: justify;">
      <img style="height: 350px; width: 400px; margin-right: 15px; float: left;" src="images/pa_tedy.jpg" value="<?php echo $gambar;?>">
			
	           
	          <div class="pb-md-5"><?php echo $kata_sambutan;?>
							<ul class="ftco-social d-flex">
                <li class="ftco-animate"><a href="#"><span class="icon-twitter"></span></a></li>
                <li class="ftco-animate"><a href="#"><span class="icon-facebook"></span></a></li>
                <li class="ftco-animate"><a href="#"><span class="icon-google-plus"></span></a></li>
                <li class="ftco-animate"><a href="#"><span class="icon-instagram"></span></a></li>
              </ul>
						</div>
            </div>
					</div>
				</div>
			</div>
		</section>
		
		<section class="ftco-section">
      <div class="container">
        <div class="row d-flex">
          <div class="col-md-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services py-4 d-block text-center">
              <div class="d-flex justify-content-center">
              	<div><img src="images/masjid.png" style=" width: 85px; height: 85px; border-radius: 10px;">
              	</div>
              </div>
              <div class="media-body p-2 mt-2">
                <h3 class="heading mb-3">Masjid Rusunawa</h3>
              </div>
            </div>      
          </div>
          <div class="col-md-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services py-4 d-block text-center">
              <div class="d-flex justify-content-center">
              	<div><img src="images/olahraga.png" style=" width: 85px; height: 85px; border-radius: 10px;">
              	</div>
              </div>
              <div class="media-body p-2 mt-2">
                <h3 class="heading mb-3">Sarana Olahraga</h3>
              </div>
            </div>    
          </div>
          <div class="col-md-3 d-flex align-sel Searchf-stretch ftco-animate">
            <div class="media block-6 services py-4 d-block text-center">
              <div class="d-flex justify-content-center">
              	<div><img src="images/taman.png" style=" width: 85px; height: 85px; border-radius: 10px;">
              	</div>
              </div>
              <div class="media-body p-2 mt-2">
                <h3 class="heading mb-3">Taman Bermain</h3>
              </div>
            </div>      
          </div>
          <div class="col-md-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services py-4 d-block text-center">
              <div class="d-flex justify-content-center">
              	<div><img src="images/parkir.png" style=" width: 85px; height: 85px; border-radius: 10px;">
              	</div>
              </div>
              <div class="media-body p-2 mt-2">
                <h3 class="heading mb-3">Parkir</h3>
              </div>
            </div>      
          </div>
        </div>
      </div>
    </section>

<!--     <section class="instagram">
      <div class="container-fluid">
        <div class="row no-gutters justify-content-center pb-5">
          <div class="col-md-7 text-center heading-section ftco-animate">
            <h2><span>Instagram</span></h2>
          </div>
        </div>
        <div class="row no-gutters">
          <div class="col-sm-12 col-md ftco-animate">
            <a href="images/h.jpg" class="insta-img image-popup" style="background-image: url(images/h.jpg);">
              <div class="icon d-flex justify-content-center">
                <span class="icon-instagram align-self-center"></span>
              </div>
            </a>
          </div>
          <div class="col-sm-12 col-md ftco-animate">
            <a href="images/i.jpg" class="insta-img image-popup" style="background-image: url(images/i.jpg);">
              <div class="icon d-flex justify-content-center">
                <span class="icon-instagram align-self-center"></span>
              </div>
            </a>
          </div>
          <div class="col-sm-12 col-md ftco-animate">
            <a href="images/k.jpg" class="insta-img image-popup" style="background-image: url(images/k.jpg);">
              <div class="icon d-flex justify-content-center">
                <span class="icon-instagram align-self-center"></span>
              </div>
            </a>
          </div>
          <div class="col-sm-12 col-md ftco-animate">
            <a href="images/l.jpg" class="insta-img image-popup" style="background-image: url(images/l.jpg);">
              <div class="icon d-flex justify-content-center">
                <span class="icon-instagram align-self-center"></span>
              </div>
            </a>
          </div>
          <div class="col-sm-12 col-md ftco-animate">
            <a href="images/m.jpg" class="insta-img image-popup" style="background-image: url(images/m.jpg);">
              <div class="icon d-flex justify-content-center">
                <span class="icon-instagram align-self-center"></span>
              </div>
            </a>
          </div>
        </div>
      </div>
    </section> -->
    <footer class="ftco-footer ftco-bg-dark ftco-section">
      <div class="container">
        <div class="row mb-5">
          <div class="col-md">
            <div class="ftco-footer-widget mb-4">
              <h2 class="ftco-heading-2">Rusunawa Depok</h2>
              <p>Hunian Penduduk Kota Depok </p>
              <ul class="ftco-footer-social list-unstyled float-md-left float-lft mt-5">
                <li class="ftco-animate"><a href="#"><span class="icon-twitter"></span></a></li>
                <li class="ftco-animate"><a href="#"><span class="icon-facebook"></span></a></li>
                <li class="ftco-animate"><a href="#"><span class="icon-instagram"></span></a></li>
              </ul>
            </div>
          </div>
          <!-- <div class="col-md">
            <div class="ftco-footer-widget mb-4 ml-md-5">
              <h2 class="ftco-heading-2">Useful Links</h2>
              <ul class="list-unstyled">
                <li><a href="#" class="py-2 d-block">Tentang Kami</a></li>
                <li><a href="#" class="py-2 d-block">Unit</a></li>
                <li><a href="#" class="py-2 d-block">Booking Unit</a></li>
                <li><a href="#" class="py-2 d-block">Informasi</a></li>
              </ul>
            </div>
          </div>
          <div class="col-md">
             <div class="ftco-footer-widget mb-4">
              <h2 class="ftco-heading-2">Privacy</h2>
              <ul class="list-unstyled">
                <li><a href="#" class="py-2 d-block">Career</a></li>
                <li><a href="#" class="py-2 d-block">About Us</a></li>
                <li><a href="#" class="py-2 d-block">Contact Us</a></li>
                <li><a href="#" class="py-2 d-block">Services</a></li>
              </ul>
            </div>
          </div> -->
          <div class="col-md">
            <div class="ftco-footer-widget mb-4">
            	<h2 class="ftco-heading-2">Kontak Kami</h2>
            	<div class="block-23 mb-3">
	              <ul>
	                <li><span class="icon icon-map-marker"></span><span class="text">"Rusunawa Depok" Jl. Banjaran Pucung No.66, Cilangkap, Tapos, Kota Depok, Jawa Barat 16451</span></li>
	                <li><a href="#"><span class="icon icon-phone"></span><span class="text">+21 88888</span></a></li>
	                <li><a href="#"><span class="icon icon-envelope"></span><span class="text">rusunawa@depok.com</span></a></li>
	              </ul>
	            </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-12 text-center">

            <p><!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
  Copyright &copy; <script>document.write(new Date().getFullYear());</script> By <a href="https://lrcom.co.id" target="_blank">PT.Lumbung Riang Communication.</a>
  <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. --></p>
          </div>
        </div>
      </div>
    </footer>
    
  

  <!-- loader -->
  <div id="ftco-loader" class="show fullscreen"><svg class="circular" width="48px" height="48px"><circle class="path-bg" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke="#eeeeee"/><circle class="path" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke-miterlimit="10" stroke="#F96D00"/></svg></div>


  <script src="js/jquery.min.js"></script>
  <script src="js/jquery-migrate-3.0.1.min.js"></script>
  <script src="js/popper.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/jquery.easing.1.3.js"></script>
  <script src="js/jquery.waypoints.min.js"></script>
  <script src="js/jquery.stellar.min.js"></script>
  <script src="js/owl.carousel.min.js"></script>
  <script src="js/jquery.magnific-popup.min.js"></script>
  <script src="js/aos.js"></script>
  <script src="js/jquery.animateNumber.min.js"></script>
  <script src="js/bootstrap-datepicker.js"></script>
  <script src="js/jquery.timepicker.min.js"></script>
  <script src="js/scrollax.min.js"></script>
  <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBVWaKrjvy3MaE7SQ74_uJiULgl1JY0H2s&sensor=false"></script>
  <script src="js/google-map.js"></script>
  <script src="js/main.js"></script>
   
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