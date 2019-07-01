
function writeCookie(name,value,days) {

    var date, expires;

    if ('7days') {

        date = new Date("Y-m-d H:i:s");

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

		    $('bangku').click(function() {

		    			    	var i=$(this).attr("data-id","0");

					if(i=="0")

					{

						return true;

					}else{

						if(i=="0")

						{

							$(this).attr('class','bangku btn-kuningg' );

							$(this).attr('data-id','3');

							Tambah();

						}else if(i=="3"){

							$(this).attr('class','bangku btn-hijau');

							$(this).attr('data-id','0');

							Tambah();

						}

											}

	   });

});

  	  	

