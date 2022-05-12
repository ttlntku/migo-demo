//touch active menu
$('.trending-category-title li').click(function () {
    $(this).closest('.trending-category-title').find('li').removeClass('active');
    $(this).addClass('active');
});

//swiper
window.addEventListener('DOMContentLoaded', function () {
    var swiper = new Swiper('.swiper-container', {
        slidesPerView: 1,
        slidesPerColumn: 1,
        spaceBetween: 30,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
    });
});
