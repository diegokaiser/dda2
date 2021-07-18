$(document).ready(function () {
    console.log("\n %c Hecho con ♥ por Diego Cáceres Cardoza, Josué Flores Cacho, Diego Janampa Porras, Fiorella Rey Baella y Kerwin Sandoval Sánchez %c %c v.18072021 %c %c \n", "color: #fff; background: #FF5532; padding:5px 0;", "background: #2F58CA; padding:5px 0;", "color: #fff; background: #2F58CA; padding:5px 0;", "background: #fff; padding:5px 0;", "color: #e43333; background: #fff; padding:5px 0;")

    if (Cookies.get("ejemplo") == undefined) {
        Cookies.set("ejemplo", "0")
    } 
    

    var homeSearch = $('.home-banner-hero-content-search-container');
    var homeStart  = $('.to-Start');
    var homeJoin   = $('.to-Join');
    var homePost   = $('.to-Post');
    var homeCat    = $('.to-Category');
    var footerDist = $('.to-District');

    homeJoin.prepend(`
        <div class="helper-alert join">
            <div class="helper-alert-body">
                Si eres un profesional de servicios, regístrate <i class="fa fa-level-up" aria-hidden="true"></i>
                <div class="helper-alert-body-icon">
                    <i class="fa fa-lightbulb-o" aria-hidden="true"></i>
                </div>
            </div>
            <div class="helper-alert-actions">
                <span class="goto-Post">Siguiente <i class="fa fa-long-arrow-right" aria-hidden="true"></i></span>
            </div>
        </div>
    `);

    homePost.prepend(`
        <div class="helper-alert post">
            <div class="helper-alert-body">
                Encuentra todas las publicaciones aquí <i class="fa fa-level-up" aria-hidden="true"></i>
                <div class="helper-alert-body-icon">
                    <i class="fa fa-lightbulb-o" aria-hidden="true"></i>
                </div>
            </div>
            <div class="helper-alert-actions">
                <span class="goto-Search">Siguiente <i class="fa fa-long-arrow-right" aria-hidden="true"></i></span>
            </div>
        </div>
    `);

    homeSearch.prepend(`
        <div class="helper-alert search">
            <div class="helper-alert-body">
                Busca servicios que necesites para tu hogar u oficina <i class="fa fa-level-down" aria-hidden="true"></i>
                <div class="helper-alert-body-icon">
                    <i class="fa fa-lightbulb-o" aria-hidden="true"></i>
                </div>
            </div>
            <div class="helper-alert-actions">
                <span class="goto-Category">Siguiente <i class="fa fa-long-arrow-right" aria-hidden="true"></i></span>
            </div>
        </div>
    `);

    homeCat.prepend(`
        <div class="helper-alert category">
            <div class="helper-alert-body">
                Busca servicios de acuerdo a una categoría de tu interés <i class="fa fa-level-down" aria-hidden="true"></i>
                <div class="helper-alert-body-icon">
                    <i class="fa fa-lightbulb-o" aria-hidden="true"></i>
                </div>
            </div>
            <div class="helper-alert-actions">
                <span class="goto-District">Siguiente <i class="fa fa-long-arrow-right" aria-hidden="true"></i></span>
            </div>
        </div>
    `);

    footerDist.prepend(`
        <div class="helper-alert district">
            <div class="helper-alert-body">
                Busca servicios en tu distrito o aledaños <i class="fa fa-level-down" aria-hidden="true"></i>
                <div class="helper-alert-body-icon">
                    <i class="fa fa-lightbulb-o" aria-hidden="true"></i>
                </div>
            </div>
            <div class="helper-alert-actions">
                <span class="goto-End">Siguiente <i class="fa fa-long-arrow-right" aria-hidden="true"></i></span>
            </div>
        </div>
    `);

    if (Cookies.get("ejemplo") == "0") {
        $('body').prepend('<div class="helper"></div>');
        $('.helper-alert.join').addClass("active");
        $('.goto-Post').on('click', function (e) {
            e.preventDefault();
            $('.helper-alert.join').removeClass("active");
            $('.helper-alert.post').addClass("active");
        });
        $('.goto-Search').on('click', function (e) {
            e.preventDefault();
            $('.helper-alert.post').removeClass("active");
            $('.helper-alert.search').addClass("active");
        });
        $('.goto-Category').on('click', function (e) {
            e.preventDefault();
            $('.helper-alert.search').removeClass("active");
            $('.helper-alert.category').addClass("active");
        });
        $('.goto-District').on('click', function (e) {
            e.preventDefault();
            $('html, body').animate({
                scrollTop: $('.helper-alert.district').offset().top
            }, 0);
            $('.helper-alert.category').removeClass("active");
            $('.helper-alert.district').addClass("active");
        });
        $('.goto-End').on('click', function (e) {
            e.preventDefault();
            $('.helper-alert.district').removeClass("active");
            $('.helper').remove();
            $('.helper-alert.join').remove();
            $('.helper-alert.post').remove();
            $('.helper-alert.search').remove();
            $('.helper-alert.category').remove();
            $('.helper-alert.district').remove();
            Cookies.set("ejemplo", "1")
        })
    }
});