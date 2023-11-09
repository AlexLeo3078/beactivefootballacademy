
if (document.getElementById('galleria') != null) {
    Galleria.configure({
        transition: "fade",
        imageCrop: false,
        lightbox: true,
        responsive: true,
        showInfo: true,
        height: 600,
    });

    Galleria.run('#galleria', {
        height: parseInt($('#galleria').css('height')),
        wait: true
    });
}


var lastScrollTop = 0;
$('.navbar').css('top', '0');

window.addEventListener("scroll", function () {
    var st = window.pageYOffset || document.documentElement.scrollTop; // Credits: "https://github.com/qeremy/so/blob/master/so.dom.js#L426"
    if (st > lastScrollTop) {
        $('.navbar').css('top', '-10rem');
    } else if (st < lastScrollTop) {
        $('.navbar').css('top', '0');
    } // else was horizontal scroll
    lastScrollTop = st <= 0 ? 0 : st; // For Mobile or negative scrolling
}, false);