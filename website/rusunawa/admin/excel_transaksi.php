<?php     
  
  $bulan     = isset($_POST['bulan']) ? $_POST['bulan'] : "";
  $status     = isset($_POST['status']) ? $_POST['status'] : "";

  header("Content-type: application/vnd-ms-excel");
  header("Content-Disposition: attachment; filename=Report Transaksi Bulan - ". $bulan." Status ".$status." .xls");
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
	<span style="font-size: 20px;"><b>REPORT TRANSAKSI PEMBAYARAN</b></span>
</div>
<div style="text-align: center;">
  <span style="font-size: 20px;"><b>RUSUNAWA KOTA DEPOK</b></span>
</div>
<div style="text-align: center;">
  <span style="font-size: 20px;"><b>BULAN : <?= $bulan; ?>, STATUS : <?= $status ?></b></span>
</div><br>
<table border="1" width="100%">
  <thead>
    <tr>
      <th>No. </th>
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
  <tbody>
    <?php
      if(isset($_POST['export'])) {
        $bulan     = isset($_POST['bulan']) ? $_POST['bulan'] : "";
        $status     = isset($_POST['status']) ? $_POST['status'] : "";

        
        include('connection.php');

        if ($bulan == 'All') {
          if ($status == 'All') {
            $no = 1;
              $res = $conn->query("SELECT * FROM tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan JOIN tbl_keluarga ON tbl_keluarga.id_penghuni = tbl_pembayaran.id_pelanggan");
              while($row = $res->fetch_assoc()){
                $jumlah[] = $row['jumlah'];
                $total = array_sum($jumlah); ?>
                <tr>
                  <td><?php echo $no; ?></td>
                  <td><?= $row['no_transaksi'] ?></td>
                  <td><?= $row['tgl_transaksi'] ?></td>
                  <td><?= $row['jatuh_tempo'] ?></td>
                  <td><?= $row['id_pelanggan'] ?></td>
                  <td><?= $row['nama_kk'] ?></td>
                  <td><?= $row['bulan'] ?></td>
                  <td><?= $row['jumlah'] ?></td>
                  <td><?= $row['keterangan'] ?></td>
                </tr>
        <?php 
              $no++;
              }
          } else {
            $no = 1;
              $res = $conn->query("SELECT * FROM tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan JOIN tbl_keluarga ON tbl_keluarga.id_penghuni = tbl_pembayaran.id_pelanggan WHERE tbl_pembayaran.keterangan = '$status'");
              while($row = $res->fetch_assoc()){ 
                $jumlah[] = $row['jumlah'];
                $total = array_sum($jumlah); ?>
                <tr>
                  <td><?php echo $no; ?></td>
                  <td><?= $row['no_transaksi'] ?></td>
                  <td><?= $row['tgl_transaksi'] ?></td>
                  <td><?= $row['jatuh_tempo'] ?></td>
                  <td><?= $row['id_pelanggan'] ?></td>
                  <td><?= $row['nama_kk'] ?></td>
                  <td><?= $row['bulan'] ?></td>
                  <td><?= $row['jumlah'] ?></td>
                  <td><?= $row['keterangan'] ?></td>
                </tr>
        <?php 
              $no++;
              }
          }
        } else {
          if ($status == 'All') {
            $no = 1;
              $res = $conn->query("SELECT * FROM tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan JOIN tbl_keluarga ON tbl_keluarga.id_penghuni = tbl_pembayaran.id_pelanggan WHERE tbl_pembayaran.bulan = '$bulan'");
              while($row = $res->fetch_assoc()){
                $jumlah[] = $row['jumlah'];
                $total = array_sum($jumlah); ?>
                <tr>
                  <td><?php echo $no; ?></td>
                  <td><?= $row['no_transaksi'] ?></td>
                  <td><?= $row['tgl_transaksi'] ?></td>
                  <td><?= $row['jatuh_tempo'] ?></td>
                  <td><?= $row['id_pelanggan'] ?></td>
                  <td><?= $row['nama_kk'] ?></td>
                  <td><?= $row['bulan'] ?></td>
                  <td><?= $row['jumlah'] ?></td>
                  <td><?= $row['keterangan'] ?></td>
                </tr>
        <?php 
              $no++;
              }
          } else {
            $no = 1;
              $res = $conn->query("SELECT * FROM tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan JOIN tbl_keluarga ON tbl_keluarga.id_penghuni = tbl_pembayaran.id_pelanggan WHERE tbl_pembayaran.bulan = '$bulan' AND tbl_pembayaran.keterangan = '$status'");
              while($row = $res->fetch_assoc()){ 
                $jumlah[] = $row['jumlah'];
                $total = array_sum($jumlah); ?>
                <tr>
                  <td><?php echo $no; ?></td>
                  <td><?= $row['no_transaksi'] ?></td>
                  <td><?= $row['tgl_transaksi'] ?></td>
                  <td><?= $row['jatuh_tempo'] ?></td>
                  <td><?= $row['id_pelanggan'] ?></td>
                  <td><?= $row['nama_kk'] ?></td>
                  <td><?= $row['bulan'] ?></td>
                  <td><?= $row['jumlah'] ?></td>
                  <td><?= $row['keterangan'] ?></td>
                </tr>
        <?php 
              $no++;
              }
          }
        }
      }
    ?>
  </tbody>
  <tfoot>
    <tr style="background-color: pink;">
      <th colspan="7"><h3>TOTAL : </h3></th>
      <th colspan="2"><h3>Rp. <?= number_format($total, 0, ".", ".");?></h3></th>
    </tr>
  </tfoot>
</table>