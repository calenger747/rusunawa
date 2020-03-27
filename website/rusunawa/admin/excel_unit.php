<?php     
  
  $gedung     = isset($_POST['gedung']) ? $_POST['gedung'] : "";

  header("Content-type: application/vnd-ms-excel");
  header("Content-Disposition: attachment; filename=Report Unit Gedung - ". $gedung.".xls");
?>
<style type="text/css">
  table,th,td{
    border-collapse: collapse;
    padding: 15px;
    margin: 10px;
    color: #000;
    font-size: 16px;
    float: center;
  }
</style>
<div style="text-align: center;">
	<br>
	<span style="font-size: 20px;"><b>REPORT UNIT</b></span>
</div>
<div style="text-align: center;">
  <span style="font-size: 20px;"><b>RUSUNAWA KOTA DEPOK</b></span>
</div>
<div style="text-align: center;">
  <span style="font-size: 20px;"><b>GEDUNG : <?= $gedung; ?></b></span>
</div><br>
<table border="1" width="100%">
  <thead>
    <tr>
      <th>No.</th>
      <th>No. unit</th>
      <th>No. KWH</th>
      <th>Gedung</th>
      <th>Lantai</th>
      <th>Unit</th>
      <th>Status</th>
    </tr>
  </thead>
  <tbody>
    <?php
      if(isset($_POST['export'])) {
        $gedung     = isset($_POST['gedung']) ? $_POST['gedung'] : "";

        
        include('connection.php');

        if ($gedung == 'All') {
          $no = 1;
            $res = $conn->query("SELECT * FROM tbl_unit");
            while($row = $res->fetch_assoc()){ ?>
              <tr>
                <td><?php echo $no; ?></td>
                <td><?= $row['id_unit'] ?></td>
                <td><?= $row['no_kwh'] ?></td>
                <td><?= $row['gedung'] ?></td>
                <td><?= $row['lantai'] ?></td>
                <td><?= $row['kamar'] ?></td>
                <td><?= $row['status'] ?></td>
              </tr>
      <?php 
            $no++;
            }
        } else {
          $no = 1;
            $res = $conn->query("SELECT * FROM tbl_unit WHERE gedung = '$gedung'");
            while($row = $res->fetch_assoc()){ ?>
              <tr>
                <td><?php echo $no; ?></td>
                <td><?= $row['id_unit'] ?></td>
                <td><?= $row['no_kwh'] ?></td>
                <td><?= $row['lantai'] ?></td>
                <td><?= $row['kamar'] ?></td>
                <td><?= $row['status'] ?></td>
              </tr>
      <?php 
            $no++;
            }
        }
      }
    ?>
  </tbody>
</table>