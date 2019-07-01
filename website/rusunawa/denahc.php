<html>
<head>
<title>Denah Tower C</title>
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
<h2><center>DENAH TOWER C</center></h2>
	<center><tr>
	<td><div class="bangku btn-Kuningg" data-id="0"></div>Booking</td>
	<td><div class="bangku btn-hijauu" data-id="0"></div>Isi</td>
	<td><div class="bangku btn-merahh" data-id="0"></div>Kosong</td>
	</center></tr>

  <tr><td><h3><center>Lantai 4</center></h3></td></tr>
  <tr>
  				
  	<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  	<td><a style="text-decoration: none;" href="booking.php">
  	<div class="bangku btn-merah"  data-id="0">C401</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">C402</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C403</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C404</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C405</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C406</div></td>
	<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C407</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C408</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C409</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C410</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C411</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C412</div></td>
	<td><div class="bangku btn-abu" data-id="1">Tangga</div></tdB
  </tr>


  <tr>
  		<td><div class="bangku btn-putih" data-id="1"></div></td>
  
  </tr>

  <tr>
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-merah" data-id="0">C424</div>
    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-merah" data-id="0">C423</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="3">C422</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C421</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="3">C420</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C419</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C418</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C417</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C416</div></td>
	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C415</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C414</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C413</div></td>
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
    <div class="bangku btn-hijau" data-id="0">C301</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-kmerah" data-id="3">C302</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C303</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C304</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C305</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C306</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C307</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C308</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C309</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C310</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kmerah" data-id="3">C311</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C312</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>


  <tr>
  		<td><div class="bangku btn-putih" data-id="1"></div></td>
  		
		
  </tr>
<tr>
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  	<td><a style="text-decoration: none;" href="booking.php">
  	<div class="bangku btn-kuning" data-id="3">C324</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">C323</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C322</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C321</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="3">C320</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C319</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C318</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C317</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C316</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C315</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C314</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-merah" data-id="0">C313</div></td>
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
    <div class="bangku btn-hijau" data-id="0">C201</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-kuning" data-id="3">C202</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C203</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C204</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C205</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C206</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C207</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C208</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C209</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C210</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C211</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C212</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>


  <tr>
  		<td><div class="bangku btn-putih" data-id="1"></div></td>
  		
		
  </tr>
<tr>
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  	<td><a style="text-decoration: none;" href="booking.php">
  	<div class="bangku btn-kuning" data-id="3">C224</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">C223</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C222</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C221</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C220</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C219</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C218</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C217</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C216</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C215</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C214</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C213</div></td>
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
    <div class="bangku btn-hijau" data-id="0">C101</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-kuning" data-id="3">C102</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C103</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C104</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C105</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C106</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C107</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C108</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C109</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C110</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C111</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C112</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>


  <tr>
  		<td><div class="bangku btn-putih" data-id="1"></div></td>
  		
		
  </tr>
<tr>
  		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  	<td><a style="text-decoration: none;" href="booking.php">
  	<div class="bangku btn-kuning" data-id="3">C124</div></td>

    <td><a style="text-decoration: none;" href="booking.php">
    <div class="bangku btn-hijau" data-id="0">C123</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C122</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C121</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-kuning" data-id="3">C120</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C119</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C118</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C117</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C116</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C115</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C114</div></td>

	<td><a style="text-decoration: none;" href="booking.php">
	<div class="bangku btn-hijau" data-id="0">C113</div></td>
		<td><div class="bangku btn-abu" data-id="1">Tangga</div></td>
  </tr>

</table>
</center>
</body>
</html>