<!DOCTYPE html>
<html lang="en">
  <head>
    <title>Denah Tower A</title>
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
    <style>
    .bangku

  {

    width: 50px;

    height:50px;

    text-align:center;

    font-size:15px;

    background-color:#F00;

    color:#FFF;

    cursor:pointer;

    margin-top:4px;

    margin-right:4px;

  }
      .btn-putih

  {

    background:#d6d6c2;
    width : 85%;
    height: 
  }
    </style>
  </head>
  <body onload="updateDB();">

    <?php include('navigation.php'); ?>
    <!-- END nav -->

    <div class="hero-wrap" style="background-image: url('images/l.jpg');">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text d-flex align-itemd-end justify-content-center">
          <div class="col-md-9 ftco-animate text-center d-flex align-items-end justify-content-center">
          	<div class="text">
	            <h1 class="mb-4 bread">Tower A</h1>
            </div>
          </div>
        </div>
      </div>
    </div>

    <section class="ftco-section">
      <div class="container">


                <h2><center>DENAH UNIT A</center></h2></br></br></br>
                <ul>
                <tr>
                    <td><button type="button" class="bangku btn-warning disabled" ></button>Booking</td><br/>
                    <td><button type="button" class="bangku btn-danger disabled" ></button>Isi</td><br/>
                    <td><button type="button" class="bangku btn-success disabled" ></button>Kosong</td><br/>
                </tr>
                </ul>
                <br/>


  <div class="container">
  <h3>Lantai 4 </h3>
    <?php
    include 'connect.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='4' AND id_unit BETWEEN 'A401' AND 'A406'");
      $sql1 = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='4' AND id_unit BETWEEN 'A407' AND 'A412'");

      for ($i=1; $i <= 2 ; $i++) { 
        echo '<div class="row">';
        for ($o=1; $o <=3 ; $o++) { 
          for ($i=1; $i <=2 ; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class=" text-black btn-default  h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
            for ($o=1; $o <=2 ; $o++) { 
              while($row1 = mysqli_fetch_array($sql)){ ?>
                <div class="button">
                  <?php if ($row1['status'] == 'Isi'): ?>
                    <button type="button" style=" " href="#" class="btn-danger disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php elseif ($row1['status'] == 'Kosong'): ?>
                    <a href="booking_tower_a.php?id=<?= $row1['id_unit'];?>" ><button type="button" style=" "class=" btn-success o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button></a>
                  <?php elseif ($row1['status'] == 'Booking'): ?>
                    <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php endif ?>
                </div>
                &nbsp

      <?php
        }
            }
          }
          
        while($row = mysqli_fetch_array($sql1)){ ?>
          <div class="button">
            <?php if ($row['status'] == 'Isi'): ?>
              <button type="button" style=" " title="Sudah Terisi" href="#" class="btn-danger disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php elseif ($row['status'] == 'Kosong'): ?>
              <a href="booking_tower_a.php?id=<?= $row['id_unit'];?>" ><button type="button" style=" " class="btn-success o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button></a>
            <?php elseif ($row['status'] == 'Booking'): ?>
              <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php endif ?>
          </div>
          &nbsp

      <?php
        }
        for ($i=1; $i <=1; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
          }

        }
        echo '</div>';

      }
    
    ?>
    </br>

     <tr>
      <td><div class="bangku btn-putih"></div></td>
  
     </tr> &nbsp;

    <?php
    include 'connect.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='4' AND id_unit BETWEEN 'A419' AND 'A424' ORDER BY id_unit DESC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='4' AND id_unit BETWEEN 'A413' AND 'A418' ORDER BY id_unit DESC");
      for ($i=1; $i <= 2 ; $i++) { 
        echo '<div class="row">';
        for ($o=1; $o <=3 ; $o++) { 
          for ($i=1; $i <=2 ; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
            for ($o=1; $o <=2 ; $o++) { 
              while($row1 = mysqli_fetch_array($sql)){ ?>
                <div class="button">
                  <?php if ($row1['status'] == 'Isi'): ?>
                    <button type="button" style=" " href="#" class="btn-danger disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php elseif ($row1['status'] == 'Kosong'): ?>
                    <a href="booking_tower_a.php?id=<?= $row1['id_unit'];?>" ><button type="button" style=" "class=" btn-success o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button></a>
                  <?php elseif ($row1['status'] == 'Booking'): ?>
                    <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php endif ?>
                </div>
                &nbsp

      <?php
        }
            }
          }
          
        while($row = mysqli_fetch_array($sql1)){ ?>
          <div class="button">
            <?php if ($row['status'] == 'Isi'): ?>
              <button type="button" style=" " title="Sudah Terisi" href="#" class="btn-danger disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php elseif ($row['status'] == 'Kosong'): ?>
              <a href="booking_tower_a.php?id=<?= $row['id_unit'];?>" ><button type="button" style=" " class="btn-success o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button></a>
            <?php elseif ($row['status'] == 'Booking'): ?>
              <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php endif ?>
          </div>
          &nbsp

      <?php
        }
        for ($i=1; $i <=1; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
          }

        }
        echo '</div>';

      }
    
    ?>
    <br/>
    <br/>
    <br/>
    <br/>



    <h3>Lantai 3 </h3>
    <?php
    include 'connect.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='3' AND id_unit BETWEEN 'A301' AND 'A306'");
      $sql1 = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='3' AND id_unit BETWEEN 'A307' AND 'A312'");
      for ($i=1; $i <= 2 ; $i++) { 
        echo '<div class="row">';
        for ($o=1; $o <=3 ; $o++) { 
          for ($i=1; $i <=2 ; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class=" text-black btn-default  h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
            for ($o=1; $o <=2 ; $o++) { 
              while($row1 = mysqli_fetch_array($sql)){ ?>
                <div class="button">
                  <?php if ($row1['status'] == 'Isi'): ?>
                    <button type="button" style=" " href="#" class="btn-danger disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php elseif ($row1['status'] == 'Kosong'): ?>
                    <a href="booking_tower_a.php?id=<?= $row1['id_unit'];?>" ><button type="button" style=" "class=" btn-success o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button></a>
                  <?php elseif ($row1['status'] == 'Booking'): ?>
                    <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php endif ?>
                </div>
                &nbsp

      <?php
        }
            }
          }
          
        while($row = mysqli_fetch_array($sql1)){ ?>
          <div class="button">
            <?php if ($row['status'] == 'Isi'): ?>
              <button type="button" style=" " title="Sudah Terisi" href="#" class="btn-danger disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php elseif ($row['status'] == 'Kosong'): ?>
              <a href="booking_tower_a.php?id=<?= $row['id_unit'];?>" ><button type="button" style=" " class="btn-success o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button></a>
            <?php elseif ($row['status'] == 'Booking'): ?>
              <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php endif ?>
          </div>
          &nbsp

      <?php
        }
        for ($i=1; $i <=1; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
          }

        }
        echo '</div>';

      }
    
    ?>
    </br>

    <tr>
      <td><div class="bangku btn-putih"></div></td>
  
     </tr> &nbsp;


    <?php
    include 'connect.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='3' AND id_unit BETWEEN 'A319' AND 'A324' ORDER BY id_unit DESC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='3' AND id_unit BETWEEN 'A313' AND 'A318' ORDER BY id_unit DESC");
      for ($i=1; $i <= 2 ; $i++) { 
        echo '<div class="row">';
        for ($o=1; $o <=3 ; $o++) { 
          for ($i=1; $i <=2 ; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
            for ($o=1; $o <=2 ; $o++) { 
              while($row1 = mysqli_fetch_array($sql)){ ?>
                <div class="button">
                  <?php if ($row1['status'] == 'Isi'): ?>
                    <button type="button" style=" " href="#" class="btn-danger disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php elseif ($row1['status'] == 'Kosong'): ?>
                    <a href="booking_tower_a.php?id=<?= $row1['id_unit'];?>" ><button type="button" style=" "class=" btn-success o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button></a>
                  <?php elseif ($row1['status'] == 'Booking'): ?>
                    <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php endif ?>
                </div>
                &nbsp

      <?php
        }
            }
          }
          
        while($row = mysqli_fetch_array($sql1)){ ?>
          <div class="button">
            <?php if ($row['status'] == 'Isi'): ?>
              <button type="button" style=" " title="Sudah Terisi" href="#" class="btn-danger disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php elseif ($row['status'] == 'Kosong'): ?>
              <a href="booking_tower_a.php?id=<?= $row['id_unit'];?>" ><button type="button" style=" " class="btn-success o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button></a>
            <?php elseif ($row['status'] == 'Booking'): ?>
              <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php endif ?>
          </div>
          &nbsp

      <?php
        }
        for ($i=1; $i <=1; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
          }

        }
        echo '</div>';

      }
    
    ?>
    <br/>
    <br/>
    <br/>
    <br/>


    <h3>Lantai 2 </h3>
    <?php
    include 'connect.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='2' AND id_unit BETWEEN 'A201' AND 'A206'");
      $sql1 = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='2' AND id_unit BETWEEN 'A207' AND 'A212'");
      for ($i=1; $i <= 2 ; $i++) { 
        echo '<div class="row">';
        for ($o=1; $o <=3 ; $o++) { 
          for ($i=1; $i <=2 ; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class=" text-black btn-default  h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
            for ($o=1; $o <=2 ; $o++) { 
              while($row1 = mysqli_fetch_array($sql)){ ?>
                <div class="button">
                  <?php if ($row1['status'] == 'Isi'): ?>
                    <button type="button" style=" " href="#" class="btn-danger disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php elseif ($row1['status'] == 'Kosong'): ?>
                    <a href="booking_tower_a.php?id=<?= $row1['id_unit'];?>" ><button type="button" style=" "class=" btn-success o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button></a>
                  <?php elseif ($row1['status'] == 'Booking'): ?>
                    <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php endif ?>
                </div>
                &nbsp

      <?php
        }
            }
          }
          
        while($row = mysqli_fetch_array($sql1)){ ?>
          <div class="button">
            <?php if ($row['status'] == 'Isi'): ?>
              <button type="button" style=" " title="Sudah Terisi" href="#" class="btn-danger disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php elseif ($row['status'] == 'Kosong'): ?>
              <a href="booking_tower_a.php?id=<?= $row['id_unit'];?>" ><button type="button" style=" " class="btn-success o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button></a>
            <?php elseif ($row['status'] == 'Booking'): ?>
              <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php endif ?>
          </div>
          &nbsp

      <?php
        }
        for ($i=1; $i <=1; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
          }

        }
        echo '</div>';

      }
    
    ?>
    </br>

    <tr>
      <td><div class="bangku btn-putih"></div></td>
  
     </tr> &nbsp;


    <?php
    include 'connect.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='2' AND id_unit BETWEEN 'A219' AND 'A224' ORDER BY id_unit DESC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='2' AND id_unit BETWEEN 'A213' AND 'A218' ORDER BY id_unit DESC");
      for ($i=1; $i <= 2 ; $i++) { 
        echo '<div class="row">';
        for ($o=1; $o <=3 ; $o++) { 
          for ($i=1; $i <=2 ; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
            for ($o=1; $o <=2 ; $o++) { 
              while($row1 = mysqli_fetch_array($sql)){ ?>
                <div class="button">
                  <?php if ($row1['status'] == 'Isi'): ?>
                    <button type="button" style=" " href="#" class="btn-danger disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php elseif ($row1['status'] == 'Kosong'): ?>
                    <a href="booking_tower_a.php?id=<?= $row1['id_unit'];?>" ><button type="button" style=" "class=" btn-success o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button></a>
                  <?php elseif ($row1['status'] == 'Booking'): ?>
                    <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php endif ?>
                </div>
                &nbsp

      <?php
        }
            }
          }
          
        while($row = mysqli_fetch_array($sql1)){ ?>
          <div class="button">
            <?php if ($row['status'] == 'Isi'): ?>
              <button type="button" style=" " title="Sudah Terisi" href="#" class="btn-danger disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php elseif ($row['status'] == 'Kosong'): ?>
              <a href="booking_tower_a.php?id=<?= $row['id_unit'];?>" ><button type="button" style=" " class="btn-success o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button></a>
            <?php elseif ($row['status'] == 'Booking'): ?>
              <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php endif ?>
          </div>
          &nbsp

      <?php
        }
        for ($i=1; $i <=1; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
          }

        }
        echo '</div>';

      }
    
    ?>
    <br/>
    <br/>
    <br/>
    <br/>


    <h3>Lantai 1 </h3>
    <?php
    include 'connect.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='1' AND id_unit BETWEEN 'A101' AND 'A106'");
      $sql1 = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='1' AND id_unit BETWEEN 'A107' AND 'A112'");
      for ($i=1; $i <= 2 ; $i++) { 
        echo '<div class="row">';
        for ($o=1; $o <=3 ; $o++) {   
          for ($i=1; $i <=2 ; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class=" text-black btn-default  h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
            for ($o=1; $o <=2 ; $o++) { 
              while($row1 = mysqli_fetch_array($sql)){ ?>
                <div class="button">
                  <?php if ($row1['status'] == 'Isi'): ?>
                    <button type="button" style=" " href="#" class="btn-danger disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php elseif ($row1['status'] == 'Kosong'): ?>
                    <a href="booking_tower_a.php?id=<?= $row1['id_unit'];?>" ><button type="button" style=" "class=" btn-success o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button></a>
                  <?php elseif ($row1['status'] == 'Booking'): ?>
                    <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php endif ?>
                </div>
                &nbsp

      <?php
        }
            }
          }
          
        while($row = mysqli_fetch_array($sql1)){ ?>
          <div class="button">
            <?php if ($row['status'] == 'Isi'): ?>
              <button type="button" style=" " title="Sudah Terisi" href="#" class="btn-danger disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php elseif ($row['status'] == 'Kosong'): ?>
              <a href="booking_tower_a.php?id=<?= $row['id_unit'];?>" ><button type="button" style=" " class="btn-success o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button></a>
            <?php elseif ($row['status'] == 'Booking'): ?>
              <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php endif ?>
          </div>
          &nbsp

      <?php
        }
        for ($i=1; $i <=1; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
          }

        }
        echo '</div>';

      }
    
    ?>
    </br>

    <tr>
      <td><div class="bangku btn-putih"></div></td>
  
     </tr> &nbsp;


    <?php
    include 'connect.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='1' AND id_unit BETWEEN 'A119' AND 'A124' ORDER BY id_unit DESC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tbl_unit WHERE gedung ='A' AND lantai='1' AND id_unit BETWEEN 'A113' AND 'A118' ORDER BY id_unit DESC");
      for ($i=1; $i <= 2 ; $i++) { 
        echo '<div class="row">';
        for ($o=1; $o <=3 ; $o++) { 
          for ($i=1; $i <=2 ; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
            for ($o=1; $o <=2 ; $o++) { 
              while($row1 = mysqli_fetch_array($sql)){ ?>
                <div class="button">
                  <?php if ($row1['status'] == 'Isi'): ?>
                    <button type="button" style=" " href="#" class="btn-danger disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php elseif ($row1['status'] == 'Kosong'): ?>
                    <a href="booking_tower_a.php?id=<?= $row1['id_unit'];?>" ><button type="button" style=" "class=" btn-success o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button></a>
                  <?php elseif ($row1['status'] == 'Booking'): ?>
                    <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                            <?php echo $row1['id_unit'];?></center>
                            <div class="card-body">
                        
                        </div>
                      </button>
                  <?php endif ?>
                </div>
                &nbsp

      <?php
        }
            }
          }
          
        while($row = mysqli_fetch_array($sql1)){ ?>
          <div class="button">
            <?php if ($row['status'] == 'Isi'): ?>
              <button type="button" style=" " title="Sudah Terisi" href="#" class="btn-danger disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php elseif ($row['status'] == 'Kosong'): ?>
              <a href="booking_tower_a.php?id=<?= $row['id_unit'];?>" ><button type="button" style=" " class="btn-success o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button></a>
            <?php elseif ($row['status'] == 'Booking'): ?>
              <button type="button" title="Sudah Terbooking" href="#" class="btn-warning disabled o-hidden h-10"><center>
                  <?php echo $row['id_unit'];?></center>
                  <div class="card-body">
                        
                  </div>
              </button>
            <?php endif ?>
          </div>
          &nbsp

      <?php
        }
        for ($i=1; $i <=1; $i++) { 
            echo '<div class="button">
              <button type="button" style=" " href="#" class="btn-default o-hidden h-10"><center>
                      Tangga</center>
                      <div class="card-body">
                  
                  </div>
                </button>
            </div> &nbsp';
          }

        }
        echo '</div>';

      }
    
    ?>


  </div>
    </section>

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
                <li><a href="#" class="py-2 d-block">Booking</a></li>
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