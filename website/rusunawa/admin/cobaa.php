<html>
<head>
<title>Denah unit A</title>

<!-- Bootstrap core CSS-->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">

    <!-- Page level plugin CSS-->
    <link href="vendor/datatables/dataTables.bootstrap4.css" rel="stylesheet">

    <!-- Custom styles for this template-->
    <link href="css/sb-admin.min.css" rel="stylesheet">
</head>
<body>
	<h2><center>DENAH UNIT A</center></h2></br>

	<div class="container">

  	<?php
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a ORDER BY kode ASC LIMIT 6");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA007' AND 'TA012'");
      for ($i=1; $i <= 2 ; $i++) { 
      	echo '<div class="row">';
      	for ($o=1; $o <=3 ; $o++) { 
      		for ($i=1; $i <=2 ; $i++) { 
      			echo '<div class="card">
    					<button type="button" style=" " href="#" class="card text-black btn btn-default o-hidden h-10"><center>
		              		Tangga</center>
		                	<div class="card-body">
		         			
		         			</div>
		         		</button>
    				</div> &nbsp';
    				for ($o=1; $o <=2 ; $o++) { 
    					while($row1 = mysqli_fetch_array($sql)){ ?>
		    				<div class="card">
		    					<?php if ($row1['status'] == 'Isi'): ?>
		    						<button type="button" style=" " href="#" class="btn btn-success o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<button type="button" style=" " href="#" class="btn btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn btn-primary o-hidden h-10"><center>
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
    			<div class="card">
		    		<?php if ($row['status'] == 'Isi'): ?>
		    			<button type="button" style=" " href="#" class="btn btn-success o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<button type="button" style=" " href="#" class="btn btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn btn-primary o-hidden h-10"><center>
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
      			echo '<div class="card">
    					<button type="button" style=" " href="#" class="card text-black btn btn-default o-hidden h-10"><center>
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

  	<?php
  	include 'connection.php';
     
      $sql = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA019' AND 'TA024' ORDER BY kode DESC");
      $sql1 = mysqli_query($conn,"SELECT * FROM tower_a WHERE kode BETWEEN 'TA013' AND 'TA018' ORDER BY kode DESC");
      for ($i=1; $i <= 2 ; $i++) { 
      	echo '<div class="row">';
      	for ($o=1; $o <=3 ; $o++) { 
      		for ($i=1; $i <=2 ; $i++) { 
      			echo '<div class="card">
    					<button type="button" style=" " href="#" class="card text-black btn btn-default o-hidden h-10"><center>
		              		Tangga</center>
		                	<div class="card-body">
		         			
		         			</div>
		         		</button>
    				</div> &nbsp';
    				for ($o=1; $o <=2 ; $o++) { 
    					while($row1 = mysqli_fetch_array($sql)){ ?>
		    				<div class="card">
		    					<?php if ($row1['status'] == 'Isi'): ?>
		    						<button type="button" style=" " href="#" class="btn btn-success o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Kosong'): ?>
		    						<button type="button" style=" " href="#" class="btn btn-danger o-hidden h-10"><center>
					              		<?php echo $row1['lantai'];?><?php echo $row1['no_unit'];?></center>
					                	<div class="card-body">
					         			
					         			</div>
					         		</button>
		    					<?php elseif ($row1['status'] == 'Booking'): ?>
		    						<button type="button" style=" " href="#" class="btn btn-primary o-hidden h-10"><center>
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
    			<div class="card">
		    		<?php if ($row['status'] == 'Isi'): ?>
		    			<button type="button" style=" " href="#" class="btn btn-success o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Kosong'): ?>
		    			<button type="button" style=" " href="#" class="btn btn-danger o-hidden h-10"><center>
					        <?php echo $row['lantai'];?><?php echo $row['no_unit'];?></center>
					        <div class="card-body">
					         			
					        </div>
					    </button>
		    		<?php elseif ($row['status'] == 'Booking'): ?>
		    			<button type="button" style=" " href="#" class="btn btn-primary o-hidden h-10"><center>
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
      			echo '<div class="card">
    					<button type="button" style=" " href="#" class="card text-black btn btn-default o-hidden h-10"><center>
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