/*!
    * Start Bootstrap - SB Admin v7.0.4 (https://startbootstrap.com/template/sb-admin)
    * Copyright 2013-2021 Start Bootstrap
    * Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-sb-admin/blob/master/LICENSE)
    */
    // 
// Scripts
// 

window.addEventListener('DOMContentLoaded', event => {

    // Toggle the side navigation
    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    if (sidebarToggle) {
        // Uncomment Below to persist sidebar toggle between refreshes
        // if (localStorage.getItem('sb|sidebar-toggle') === 'true') {
        //     document.body.classList.toggle('sb-sidenav-toggled');
        // }
        sidebarToggle.addEventListener('click', event => {
            event.preventDefault();
            document.body.classList.toggle('sb-sidenav-toggled');
            localStorage.setItem('sb|sidebar-toggle', document.body.classList.contains('sb-sidenav-toggled'));
        });
    }
});

$(document).ready(function () {
    /*      image click     */
    $('.__thumbnails .__thumbnail-pic img').on('click', function () {
        const selectedImage = $(this).attr('src');
        $('.__main-pic img').attr('src', selectedImage)
    });

    /*      delete popup        */
    var redirectUrl = null;
    $('#deleteButton').on('click', function () {
        $('.__popup-confirm').show();
        redirectUrl = $(this).attr('data-href')
    });

    $('#closePopupButton').click(function () {
        $('.__popup-confirm').hide();
    });

    $('#confirmPopupButton').click(function () {
        if (redirectUrl) {
            window.location.replace(window.location.protocol + "//" + window.location.host + redirectUrl);
        }
    });

    /*      remove error messages       */
    $(':input.AcUpdateInput').on('click', () => {
        $('.AcUpdateMess').text("");
    })

    $(':input.AcCreateInput').on('click', () => {
        $('.AcCreateMess').text("");
    })

    /*      remove image        */
    $('.__remove-image').on('click', function () {
        /* hide remove button */
        $(this).hide();

        /* remove main pic if selected */
        const img = $(this).closest('.__thumbnail-input-pic').find('img')
        const mainImg = $('.__main-pic img')
        if (mainImg.attr('src') == img.attr('src')) {
            mainImg.attr('src', '')
            mainImg.hide()
            $('.__main-pic p').show()
        }

        /* remove src value and hide */
        img.removeAttr("src")
        img.hide()

        /* show button again */
        const btn = $(this).closest('.__thumbnail-input-pic').find('button')
        btn.show()
    })

    $('.__thumbnail-input-pic img').click(function () {
        var imgSrc = $(this).attr('src')
        $('.__main-pic p').attr("style", "display: none !important")

        const mainImg = $('.__main-pic img')
        mainImg.attr('src', imgSrc)
        mainImg.show()
    })

    /*      SELECT2     */
    $(".js-example-basic-multiple").select2();
    
    /*          StockIn            */
    $('#ExistProduct-form').hide();
    $("input[name$='stockInMethod']").click(function () {
        var value = $(this).val();

        $('#NewProduct-form').hide();
        $('#ExistProduct-form').hide();
        $("#" + value + "-form").show();
    });
});

