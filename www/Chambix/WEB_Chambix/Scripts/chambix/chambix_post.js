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

    var titulo = $('#post-titulo');
    var descripcion = $('#descripcion');
    var cboSubCategoria = $('#cboSubCategoria');
    var cboDistrito = $('#cboDistrito');
    var btn = $('#btnPublicar');

    btn.prop('disabled', true);

    titulo.on("change", function () {
        if (titulo.val() > 0 || titulo.val() != "") {
            descripcion.on("change", function () {
                if (descripcion.val() > 0 || descripcion.val() != "") {
                    cboSubCategoria.on("change", function () {
                        if (cboSubCategoria.val() != "0") {
                            cboDistrito.on("change", function () {
                                if (cboDistrito.val() != "0") {
                                    btn.prop('disabled', false);
                                }
                            })
                        }
                    })
                }
            })
        }
    })


    var tituloComentario = $('#tituloComentario');
    var comentario = $('#comentario');
    var btnComentar = $('#btnComentar');

    btnComentar.prop('disabled', true);

    tituloComentario.on("change", function () {
        if (tituloComentario.val() > 0 || tituloComentario.val() != "") {
            comentario.on("change", function () {
                if (comentario.val() > 0 || comentario.val() != "") {
                    btnComentar.prop('disabled', false);
                }
            })
        }
    })
});