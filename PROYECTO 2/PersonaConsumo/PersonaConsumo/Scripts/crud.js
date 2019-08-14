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

