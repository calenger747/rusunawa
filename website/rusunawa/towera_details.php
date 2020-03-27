<!DOCTYPE html>
<html lang="en">

<head>
    <title>Tower A Details</title>
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

<body onload="updateDB();">
    <?php include('navigation.php'); ?>
    <!-- END nav -->
    <div class="hero-wrap" style="background-image: url('images/f.jpg');">
        <div class="overlay"></div>
        <div class="container">
            <div class="row no-gutters slider-text d-flex align-itemd-end justify-content-center">
                <div class="col-md-9 ftco-animate text-center d-flex align-items-end justify-content-center">
                    <h1 class="mb-4 bread">Tower A</h1>
                </div>
            </div>
        </div>
    </div>
    </div>
    <section class="ftco-section">
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <div class="row">
                        <div class="col-md-12 ftco-animate">
                            <h2 class="mb-4">Unit Tower A</h2>
                            <div class="single-slider owl-carousel">
                                <div class="item">
                                    <div class="room-img" style="background-image: url(images/j.jpg);"></div>
                                </div>
                                <div class="item">
                                    <div class="room-img" style="background-image: url(images/g.jpg);"></div>
                                </div>
                                <div class="item">
                                    <div class="room-img" style="background-image: url(images/f.jpg);"></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-12 room-single mt-4 mb-5 ftco-animate">
                            <p>When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove, the headline of Alphabet Village and the subline of her own road, the Line Lane. Pityful a rethoric question ran over her cheek, then she continued her way.</p>
                            <div class="d-md-flex mt-5 mb-5">
                                <ul class="list">
                                    <li><span>Kapasitas :</span> 4 Orang</li>
                                    <li><span>Ukuran :</span> 45 m2</li>
                                </ul>
                                <ul class="list ml-md-5">
                                    <li><span>Dapur</span></li>
                                    <li><span>Kamar Mandi</span></li>
                                </ul>
                            </div>
                            <p>When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove, the headline of Alphabet Village and the subline of her own road, the Line Lane. Pityful a rethoric question ran over her cheek, then she continued her way.</p>
                        </div>
                        <div class="col-md-12 room-single ftco-animate mb-5 mt-4">
                            <h3 class="mb-4">Denah Ruang Tower A</h3>
                            <div class="block-16">
                                <figure>
                                    <img src="images/room-4.jpg" alt="Image placeholder" class="img-fluid">
                                    <a href="https://vimeo.com/45830194" class="play-button popup-vimeo"><span class="icon-play"></span></a>
                                </figure>
                            </div>
                        </div>
                    </div>
                </div> <!-- .col-md-8 -->
                <div class="col-lg-4 sidebar">
                    <br>
                    <div class="sidebar-box">
                        <h3>Berita Terkini</h3>
                        <hr>
                        <?php
        
                          date_default_timezone_set('Asia/Jakarta');
                          include 'connection.php';

                          $tampil=mysqli_query($conn, "SELECT * FROM update_berita ORDER BY kode_berita DESC LIMIT 4");
                          while ($row=mysqli_fetch_array($tampil)){ 
                        ?>
                        <div class="block-21 mb-4 d-flex">
                            <a href="#<?= $row['kode_berita'];?>" data-toggle="modal" data-target="#beritaModal<?=$row['kode_berita']?>" class="blog-img mr-4"><img style="height: auto; width: 100%;" src="images/<?php echo $row['gambar'];?>" value=""></a>
                            <div class="text">
                                <h3 class="heading">
                                    <?php echo $row['judul_berita'];?>
                                </h3>
                                <div class="meta">
                                    <div>
                                        <?php echo $row['tanggal'];?>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="modal fade" id="beritaModal<?=$row['kode_berita']?>" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog modal-lg" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <button class="close" type="button" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">×</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <div class="col-md-12 ftco-animate">
                                            <h2 class="mb-4 text-center">
                                                <?php echo $row['judul_berita'];?>
                                            </h2>
                                            <div class="single-slider owl-carousel">
                                                <div class="item">
                                                    <div class="room-img" style="background-image: url(images/<?php echo $row['gambar'];?>);"></div>
                                                </div>
                                                <!-- 
                                        <div class="item">
                                            <div class="room-img" style="background-image: url(images/g.jpg);"></div>
                                        </div>
                                        <div class="item">
                                            <div class="room-img" style="background-image: url(images/f.jpg);"></div>
                                        </div> -->
                                            </div>
                                        </div>
                                        <div class="col-md-12 room-single mt-4 mb-5 ftco-animate">
                                            <p>
                                                <?php echo $row['deskripsi'];?>
                                            </p>
                                        </div>
                                    </div>
                                    <div class="modal-footer">
                                        <button class="btn btn-secondary" type="button" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <?php } ?>
                    </div>
                    <div class="sidebar-box ftco-animate">
                        <h3>Rusunawa Depok</h3>
                        <p>Rusunawa yang dibangun Kementerian Pekerjaan Umum tersebut, lanjut Kania, tak akan lagi diperuntukkan hanya bagi warga Depok dari kalangan tak mampu, tetapi juga bagi warga luar Depok yang bekerja di Depok.</p>
                        <p>Menurut Kania, sebelumnya persyaratan bagi calon penyewa rusun ini adalah warga Depok dengan menunjukkan KTP serta berpenghasilan rendah. Kini, warga tak ber-KTP Depok tetapi bekerja di kota ini bisa pula menempati rusunawa dengan sistem sewa.</p>
                        <p>Rusunawa yang sudah berumur 8 tahun ini tak terlalu laku karena tak ada angkutan umum dari rusun ke jalan utama di Jalan Raya Bogor. Dari tiga tower yang berdiri, hanya satu tower yang sudah terisi. Setiap tower di rusunawa ini memiliki 4 lantai dan 96 unit.</p>
                        <p>Pada tower A yang siap dihuni sejak 2006, baru 49 dari 96 unit yang dihuni warga. Selebihnya, 47 unit, kosong. Padahal, harga sewa di rusunawa ini hanya berkisar Rp 150.000 hingga Rp 250.000 per bulan, tergantung lokasi lantai rusun. Ditargetkan, 2 tower lain yang kini sedang direnovasi segera siap huni dan bisa ditawarkan ke masyarakat.</p>
                    </div>
                </div>
            </div>
        </div>
    </section> <!-- .section -->
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
                        <p>Hunian Penduduk Kota Depok</p>
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
                        <h2 class="ftco-heading-2">Have a Questions?</h2>
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
                    <p>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        Copyright &copy; <script>
                        document.write(new Date().getFullYear());
                        </script> By <a href="https://lrcom.co.id" target="_blank">PT.Lumbung Riang Communication.</a>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </p>
                </div>
            </div>
        </div>
    </footer>
    <!-- loader -->
    <div id="ftco-loader" class="show fullscreen"><svg class="circular" width="48px" height="48px">
            <circle class="path-bg" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke="#eeeeee" />
            <circle class="path" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke-miterlimit="10" stroke="#F96D00" /></svg></div>
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