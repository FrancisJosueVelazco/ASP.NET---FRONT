$(document).ready(function () {

    var codigo = $("#txtcodigo");
    var nombres = $('#txtnombres');
    var apellidos = $('#txtapellidos');
    var edad = $('#txtedad');
    var fecha = $('#txtfecha');
    var botonregistrar = $("#btnregistrar");

    var modaladvertencia = $('#advertencia');
    botonregistrar.click(function () {
        $('#advertencia').modal('show');
    });

});


function mostrar() {

    var info = document.getElementById("datos");

    var xmlhttp;
    xmlhttp.open("GET", "https://jsonplaceholder.typicode.com/todos/", true);
    xmlhttp.send();
    /*if (window.XMLHttpRequest) {
        xmlhttp = new XMLHttpRequest();
    } else {
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }*/
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState === 4 && xmlhttp.status === 200) {
            var datos = JSON.parse(xmlhttp.responseText);

            if (datos.innerHTML === ""){
                for (var i in datos) {
                    info.innerHTML += datos[i].userId + "<hr/>";
                }
            }

        }
        xmlhttp.open("GET", "https://jsonplaceholder.typicode.com/todos/", true);
        xmlhttp.send();
    }
 

}


