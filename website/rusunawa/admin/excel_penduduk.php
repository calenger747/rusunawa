<?php     
  
  $gedung     = isset($_POST['gedung']) ? $_POST['gedung'] : "";

  header("Content-type: application/vnd-ms-excel");
  header("Content-Disposition: attachment; filename=Report Penduduk Gedung - ". $gedung.".xls");
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
	<span style="font-size: 20px;"><b>REPORT PENDUDUK</b></span>
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
      <th>No. </th>
      <th>NIK</th>
      <th>Nama</th>
      <th>Jenis Kelamin</th>
      <th>Tempat, Tanggal Lahir</th>
      <th>Agama</th>
      <th>Status</th>
      <th>Unit</th>
    </tr>
  </thead>
  <tbody>
    <?php
      if(isset($_POST['export'])) {
        $gedung     = isset($_POST['gedung']) ? $_POST['gedung'] : "";

        
        include('connection.php');

        if ($gedung == 'All') {
          $no = 1;
            $res = $conn->query("SELECT * FROM tbl_penduduk JOIN tbl_keluarga ON tbl_penduduk.id_kk = tbl_keluarga.id_kk JOIN tbl_unit ON tbl_keluarga.id_penghuni = tbl_unit.id_unit");
            while($row = $res->fetch_assoc()){ ?>
              <tr>
                <td><?php echo $no; ?></td>
                <td><?= $row['nik'] ?></td>
                <td><?= $row['nama'] ?></td>
                <td><?= $row['jenis_kelamin'] ?></td>
                <td><?= $row['tmpt_lahir'] ?>, <?= $row['tgl_lahir'] ?></td>
                <td><?= $row['agama'] ?></td>
                <td><?= $row['status_kawin'] ?></td>
                <td><?= $row['id_unit'] ?></td>
              </tr>
      <?php 
            $no++;
            }
        } else {
          $no = 1;
            $res = $conn->query("SELECT * FROM tbl_penduduk JOIN tbl_keluarga ON tbl_penduduk.id_kk = tbl_keluarga.id_kk JOIN tbl_unit ON tbl_keluarga.id_penghuni = tbl_unit.id_unit WHERE tbl_unit.gedung = '$gedung'");
            while($row = $res->fetch_assoc()){ ?>
              <tr>
                <td><?php echo $no; ?></td>
                <td><?= $row['nik'] ?></td>
                <td><?= $row['nama'] ?></td>
                <td><?= $row['jenis_kelamin'] ?></td>
                <td><?= $row['tmpt_lahir'] ?>, <?= $row['tgl_lahir'] ?></td>
                <td><?= $row['agama'] ?></td>
                <td><?= $row['status_kawin'] ?></td>
                <td><?= $row['id_unit'] ?></td>
              </tr>
      <?php 
            $no++;
            }
        }
      }
    ?>
  </tbody>
</table>