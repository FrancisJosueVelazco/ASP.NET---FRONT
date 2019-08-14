

$(document).ready(function () {

    //SELECTOR ID
    $("#rojo").css("background", "red")
        .css("color", "white");

    $("#amarillo").css("background", "yellow")
        .css("color", "green");

    $("#verde").css("background", "green")
        .css("color", "orange");


    //SELECTOR CLASE
    var cl = $('.clase');
    cl.css("border", "5px dashed black")


    //SELECTOR ETIQUETA
    var parrafos = $('p').css("cursor", "pointer");
    parrafos.click(function () {
        var cl = $(this);
        if (!cl.hasClass('grande')) {
            cl.addClass('grande');
        } else {
            cl.removeClass("grande");
        }
    });




    // SELECTOR DE ATRIBUTOS
    $('[title="Google"]').css("background", "green")
    $('[title="Facebook"]').css("background", "blue")


    //AJAX GET - POST


    //-----------GET------------
    $.get("https://reqres.in/api/users", { page: 1 }, function (response) {
        response.data.forEach((element, index) => {
            $('#contenedor').append("<p>" + element.first_name + "</p>");
        });

    });

    //-----------POST - .ajax ------------
    $('#formulario').submit(function (e) {
        e.preventDefault();

        var usuario = {
            name: $('[name="txtusuario"]').val(),
            web: $('[name="txtweb"]').val()
        };

        $.ajax({
            type: 'POST',

            url: $(this).attr("action"),

            data: usuario,

            beforeSend: function () {
                console.log("Enviando usuario...");
            },
            success: function (response) {
                alert("Usuario Loguedo correctamente");
            },
            error: function () {
                console.log("A ocurrido un error");
            },
            timeout: 2000

        });

        return false;

    });

});


