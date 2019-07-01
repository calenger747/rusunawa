<html>
<head>
<title>Denah Tower B</title>
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

	.btn-hijau

	{

		background:#4fb821;

	}		
	.btn-kuning

	{

		background:#e6e600;

	}
	.btn-abu

	{

		background:#ff9900;

	}
	.btn-putih

	{

		background:#d6d6c2;
		width : 1765%;
		height: 
	}
	.btn-merah

	{

		background:#ff0000;

	}
	.btn-hijauu

	{

		background:#4fb821;
		width: 20px;
		height: 20px;
	}	
	.btn-merahh

	{

		background:#ff0000;
		width: 20px;
		height: 20px;
	}
	.btn-kuningg

	{

		background:#e6e600;
		width: 20px;
		height: 20px;
		
	}		
</style>
<script type="text/javascript">
	function writeCookie(name,value,days) {

    var date, expires;

    if (days) {

        date = new Date();

        date.setTime(date.getTime()+(days*24*60*60*1000));

        expires = "; expires=" + date.toGMTString();

            }else{

        expires = "";

    }

    document.cookie = name + "=" + value + expires + "; path=/";

}

function readCookie(name) {

    var i, c, ca, nameEQ = name + "=";

    ca = document.cookie.split(';');

    for(i=0;i < ca.length;i++) {

        c = ca[i];

        while (c.charAt(0)==' ') {

            c = c.substring(1,c.length);

        }

        if (c.indexOf(nameEQ) == 0) {

            return c.substring(nameEQ.length,c.length);

        }

    }

    return '';

}

$(document).ready(function(){

	$('.bangku').each(function() {

		    $(this).click(function() {

		    			    	var i=$(this).attr("data-id");

					if(i=="1")

					{

						return false;

					}else{

						if(i=="0")

						{

							$(this).attr('class','btn-kuning bangku');

							$(this).attr('data-id','3');

							Tambah();

						}else if(i=="3"){

							$(this).attr('class','btn-hijau bangku');

							$(this).attr('data-id','0');

							Tambah();

						}
						if(i=="4")

						{

							$(this).attr('class','btn-abu bangku');

							$(this).attr('data-id','1');

							Tambah();

						}else if(i=="5"){

							$(this).attr('class','btn-putih bangku');

							$(this).attr('data-id','2');

							Tambah();

						}

											}

															    });

  		});

  	  	$("#lihattotal").click(function(){

  		var total=$('div[data-id="3"]').length;

  		alert("Jumlah pemesanan " + total);

  	});

  	  	$("#lihatbangku").click(function(){

  		var str = [], item;

			    $.each($('div[data-id="3"]'), function (index, value) {

			        item = $(this).text();                 

			        str.push(item);                 

			    });

			    var selek=str.join(',');

			    alert("Bangku yg dipesan "+selek);

  	});

  		  	function Tambah() {

		  var total=$('div[data-id="3"]').length;

		    	var str = [], item;

			    $.each($('div[data-id="3"]'), function (index, value) {

			        item = $(this).text();                 

			        str.push(item);                 

			    });

			    var selek=str.join(',');

		    	writeCookie('totseat',total,1);

		    	writeCookie('selekseat',selek,1);

		    		}

});
</script>
</head>
<body>
<center>
<table width="10%" border="0" cellpadding="4" cellspacing="4" class="aaaaa">
<h2><center>DENAH TOWER B</center></h2>
	<center><tr>
	<td><div class="bangku btn-Kuningg" ></div>Booking</td>
	<td><div class="bangku btn-hijauu" ></div>Isi</td>
	<td><div class="bangku btn-merahh" ></div>Kosong</td>
	</center></tr>

  <tr><td><h3><center>Lantai 4</center></h3></td></tr>
  <tr>
  				
  	<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  	<td><a style="text-decoration: none;" href="booking.php">
  	<div class="bangku btn-merah"  data-id="0">B401</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">B402</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B403</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B404</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B405</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B406</div></td>
	<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B407</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B408</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B409</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B410</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B411</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B412</div></td>
	<td><div class="bangku btn-abu" data-id="1">Tangga</div></tdB
  </tr>


  <tr>
  		<td><div class="bangku btn-putih" data-id="1"></div></td>
  
  </tr>

  <tr>
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-merah" data-id="0">B424</div>
    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-merah" data-id="0">B423</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="3">B422</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B421</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="3">B420</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B419</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B418</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B417</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B416</div></td>
	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B415</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B414</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B413</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>

 <td>
  <br/>
  <br/>
  <br/>
  <br/>
  <br/>
  <br/>
 </td>
  
  <tr><td><center><h3>Lantai 3</h3></center></td></tr>
  <tr>
  					
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">B301</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-kmerah" data-id="3">B302</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B303</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B304</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B305</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B306</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B307</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B308</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B309</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B310</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kmerah" data-id="3">B311</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B312</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>


  <tr>
  		<td><div class="bangku btn-putih" data-id="1"></div></td>
  		
		
  </tr>
<tr>
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  	<td><a style="text-decoration: none;" href="booking.php">
  	<div class="bangku btn-kuning" data-id="3">B324</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">B323</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B322</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B321</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="3">B320</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B319</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B318</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B317</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B316</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B315</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B314</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">B313</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>
  

  <td>
  <br/>
  <br/>
  <br/>
  <br/>
  <br/>
  <br/>
  </td>


  <tr><td><h3><center>Lantai 2</center></h3></td></tr>
  <tr>
  					
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">B201</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-kuning" data-id="3">B202</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B203</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B204</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B205</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B206</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B207</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B208</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B209</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B210</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B211</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B212</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>


  <tr>
  		<td><div class="bangku btn-putih" data-id="1"></div></td>
  		
		
  </tr>
<tr>
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  	<td><a style="text-decoration: none;" href="booking.php">
  	<div class="bangku btn-kuning" data-id="3">B224</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">B223</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B222</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B221</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B220</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B219</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B218</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B217</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B216</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B215</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B214</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B213</div></td>
	<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>
  

  <td>
  <br/>
  <br/>
  <br/>
  <br/>
  <br/>
  <br/>
  </td>

  <tr><td><h3><center>Lantai 1</center></h3></td></tr>
  <tr>
  					
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">B101</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-kuning" data-id="3">B102</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B103</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B104</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B105</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B106</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B107</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B108</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B109</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B110</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B111</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B112</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>


  <tr>
  		<td><div class="bangku btn-putih" data-id="1"></div></tdB
  		
		
  </tr>
<tr>
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  	<td><a style="text-decoration: none;" href="booking.php">
  	<div class="bangku btn-kuning" data-id="3">B124</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">B123</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B122</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B121</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">B120</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B119</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B118</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B117</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B116</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B115</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B114</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">B113</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>

</table>
</center>
</body>
</html>