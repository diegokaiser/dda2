$(document).ready(function () {
    console.log("\n %c Hecho con ♥ por Diego Cáceres Cardoza, Josué Flores Cacho, Diego Janampa Porras, Fiorella Rey Baella y Kerwin Sandoval Sánchez %c %c v.18072021 %c %c \n", "color: #fff; background: #FF5532; padding:5px 0;", "background: #2F58CA; padding:5px 0;", "color: #fff; background: #2F58CA; padding:5px 0;", "background: #fff; padding:5px 0;", "color: #e43333; background: #fff; padding:5px 0;")
    var email = $('#login-email');
    var pass = $('#login-password');
    var btn = $('#btn-login');

    btn.prop('disabled', true);

    email.on("change", function () {
        if (email.val() > 0 || email.val() != "") {
            pass.on("change", function () {
                if (pass.val() > 0 || pass.val() != "") {
                    btn.prop('disabled', false);
                }
            })
        }
    })
});