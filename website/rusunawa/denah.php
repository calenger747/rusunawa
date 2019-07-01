<html>
<head>
<title>Denah unit A</title>
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
	<h2><center>DENAH UNIT A</center></h2></br>

	<div class="container">
	<h3>Lantai 4 </h3>
  	<?php
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA073' AND 'TA078'");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA079' AND 'TA084'");

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
		    						<button type="button" style=" " href="#" class="btn-success disabled o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<a href="booking.php?id=<?= $row1['kode'];?>" ><button type="button" style=" " href="booking.php?id=<?= $row['kode'];?>" class=" btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button></a>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn-warning o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
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
		    			<button type="button" style=" " href="#" class="btn-success disabled o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<a href="booking.php?id=<?= $row['kode'];?>" ><button type="button" style=" " class="btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button></a>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn-warning o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
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

  	<div class="container">
    	<button type="button" class="btn-default btn-block  o-hidden h-10">Balkon
		                	<div class="card-body">
		         			
		         			</div>
		         		</button>
    				</div> &nbsp;

  	<?php
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA091' AND 'TA096' ORDER BY kode DESC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA085' AND 'TA090' ORDER BY kode DESC");
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
		    						<button type="button" style=" " href="#" class="btn-success disabled o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<a href="booking.php?id=<?= $row1['kode'];?>"><button type="button" class="btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button></a>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn-warning o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
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
		    			<button type="button" style=" " href="#" class="btn-success disabled o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<a href="booking.php?id=<?= $row['kode'];?>"><button type="button" class=" btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button></a>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn-warning o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
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
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA049' AND 'TA054' ORDER BY kode ASC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA055' AND 'TA060' ORDER BY kode ASC");
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
		    						<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<a href="booking.php?id=<?= $row1['kode'];?>"><button type="button" class="btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button></a>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
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
		    			<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<a href="booking.php?id=<?= $row['kode'];?>"><button type="button" class="btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button></a>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
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

  	<div class="container">
    	<button type="button" class="btn-default btn-block  o-hidden h-10">Balkon
		                	<div class="card-body">
		         			
		         			</div>
		         		</button>
    				</div> &nbsp;

  	<?php
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA067' AND 'TA072' ORDER BY kode DESC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA061' AND 'TA066' ORDER BY kode DESC");
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
		    						<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<a href="booking.php?id=<?= $row1['kode'];?>" ><button type="button" class="btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button></a>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
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
		    			<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<a href="booking.php?id=<?= $row['kode'];?>"><button type="button" class=" btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button></a>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
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
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA025' AND 'TA030' ORDER BY kode ASC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA031' AND 'TA036' ORDER BY kode ASC");
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
		    						<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<a href="booking.php?id=<?= $row1['kode'];?>"><button type="button" class="btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button></a>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
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
		    			<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<a href="booking.php?id=<?= $row['kode'];?>"><button type="button" class="btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button></a>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
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

  	<div class="container">
  		<div class="row">
    	<button type="button" class="btn-default btn-block  o-hidden h-10">Balkon
		                	<div class="card-body">
		         			
		         			</div>
		</button>
		</div>
    				</div> &nbsp;

  	<?php
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA043' AND 'TA048' ORDER BY kode DESC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA037' AND 'TA042' ORDER BY kode DESC");
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
		    						<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<a href="booking.php?id=<?= $row1['kode'];?>" ><button type="button" class="btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button></a>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
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
		    			<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<a href="booking.php?id=<?= $row['kode'];?>"><button type="button" class=" btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button></a>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
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
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA001' AND 'TA006' ORDER BY kode ASC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA007' AND 'TA012' ORDER BY kode ASC");
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
		    						<button type="button" title="Terisi" href="#" class="btn-success o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<a href="booking.php?id=<?= $row1['kode'];?>"><button type="button" class="btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button></a>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
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
		    			<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<a href="booking.php?id=<?= $row['kode'];?>"><button type="button" class="btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button></a>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
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

  	<div class="container">
    	<button type="button" class="btn-default btn-block  o-hidden h-10">Balkon
		                	<div class="card-body">
		         			
		         			</div>
		         		</button>
    				</div> &nbsp;

  	<?php
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA019' AND 'TA024' ORDER BY kode DESC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA013' AND 'TA018' ORDER BY kode DESC");
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
		    						<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<a href="booking.php?id=<?= $row1['kode'];?>" ><button type="button" class="btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button></a>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
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
		    			<button type="button" style=" " href="#" class="btn-success o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<a href="booking.php?id=<?= $row['kode'];?>"><button type="button" class=" btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button></a>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn-primary o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
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

</body>
</html>