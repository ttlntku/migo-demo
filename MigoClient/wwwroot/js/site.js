//touch active menu
$('.trending-category-title li').click(function () {
    $(this).closest('.trending-category-title').find('li').removeClass('active');
    $(this).addClass('active');
});