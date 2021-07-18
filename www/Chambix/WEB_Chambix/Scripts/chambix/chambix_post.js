$(document).ready(function () {
    console.log("\n %c Hecho con ♥ por Diego Cáceres Cardoza, Josué Flores Cacho, Diego Janampa Porras, Fiorella Rey Baella y Kerwin Sandoval Sánchez %c %c v.18072021 %c %c \n", "color: #fff; background: #FF5532; padding:5px 0;", "background: #2F58CA; padding:5px 0;", "color: #fff; background: #2F58CA; padding:5px 0;", "background: #fff; padding:5px 0;", "color: #e43333; background: #fff; padding:5px 0;")
    $('#cboCategorias').prop('disabled', 'disabled');
    $('#condicion2').on('change', function () {
        if ($('#condicion2').is(':checked')) {
            $('#cboCategorias').prop('disabled', false);
        }
    });
    $('#condicion1').on('change', function () {
        if ($('#condicion1').is(':checked')) {
            $('#cboCategorias').prop('disabled', 'disabled');
        }
    });
});