
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