<?php
mysqli_connect('127.0.0.1','root','','db_siap');
?>
<?php


	require('pendapatan.php');


	/* Getting demo_viewer table data */
	$sql = "SELECT SUM(numberofview) as count FROM jenis 
			GROUP BY YEAR(created_at) ORDER BY pendapatan";
	$viewer = mysqli_query($mysqli,$sql);
	$viewer = mysqli_fetch_all($viewer,MYSQLI_ASSOC);
	$viewer = json_encode(array_column($viewer, 'count'),JSON_NUMERIC_CHECK);

?>


<!DOCTYPE html>
<html>
<head>
	<title>rusunawa</title>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
	<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.js"></script>
	<script src="https://code.highcharts.com/highcharts.js"></script>
</head>
<body>


<script type="text/javascript">


$(function () { 


    var data_viewer = <?php echo $viewer; ?>;


    $('#container').highcharts({
        chart: {
            type: 'column'
        },
        title: {
            text: 'pendapatan rusunawa'
        },
        xAxis: {
            categories: ['Total pendapatan Maksimal','Total pendapatan Optimal','Total pendapatan Seharusnya', 'Total pendapatan Real','Total pendapatan Tertunggak']
        },
        yAxis: {
            title: {
                text: 'pendapatan'
            }
        },
        {
            name: 'View',
            data: data_viewer
        }]
    });
});


</script>


<div class="container">
	<br/>
	<h2 class="text-center">Highcharts rusunawa</h2>
    <div class="row">
        <div class="col-md-10 col-md-offset-1">
            <div class="panel panel-default">
                <div class="panel-heading">rusunawa</div>
                <div class="panel-body">
                    <div id="container"></div>
                </div>
            </div>
        </div>
    </div>
</div>


</body>
</html>