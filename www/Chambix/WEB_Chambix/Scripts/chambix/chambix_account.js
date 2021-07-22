$(document).ready(function () {
    console.log("\n %c Hecho con ♥ por Diego Cáceres Cardoza, Josué Flores Cacho, Diego Janampa Porras, Fiorella Rey Baella y Kerwin Sandoval Sánchez %c %c v.18072021 %c %c \n", "color: #fff; background: #FF5532; padding:5px 0;", "background: #2F58CA; padding:5px 0;", "color: #fff; background: #2F58CA; padding:5px 0;", "background: #fff; padding:5px 0;", "color: #e43333; background: #fff; padding:5px 0;")

    var nombre = $('#nombre');
    var apellido = $('#apellido');
    var contrasena = $('#contrasena');
    var recontrasena = $('#recontrasena');
    var correo = $('#correo');
    var distrito = $('#cboDistritos');
    var tipoUsuario = $('#tipoUser');
    var ocupacion = $('#ocupacion');
    
    var accountSuccess = $('#accountSuccess');
    var usaWsp = $('#cellWsp');
    var numCel = $('#celular');
    var numWsp = $('#login-wsp');

    var btnCreate = $('#createAccount');

    btnCreate.prop('disabled', true);

    recontrasena.on("keyup", function () {
        if (contrasena.val() != recontrasena.val()) {
            btnCreate.prop('disabled', true);
        } else {
            btnCreate.prop('disabled', false);
        }
    });

    btnCreate.on("click", function () {
        accountSuccess.addClass("active");
    });

    usaWsp.on("change", function () {
        if ($(this).val == "Si") {
            console.log("usa wsp");
            numWsp.val(numCel.val());
            numWsp.prop('disabled', true);
        } else {
            console.log("no usa wsp");
            numWsp.val("");
            numWsp.prop('disabled', false);
        }
    })
});