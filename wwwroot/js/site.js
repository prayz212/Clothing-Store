// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// @ts-nocheck


$(document).ready(function () {
    const menu = document.querySelector(".__menu");
    const navOpen = document.querySelector(".__hamburger");
    const navClose = document.querySelector(".__close");

    navOpen.addEventListener("click", () => {
        menu.classList.add("__show");
        document.body.classList.add("__show");
        navBar.classList.add("__show");
    });


    navClose.addEventListener("click", () => {
        menu.classList.remove("__show");
        document.body.classList.remove("__show");
        navBar.classList.remove("__show");
    });

    // Fixed Nav
    const navBar = document.querySelector(".__nav");
    const navHeight = navBar.getBoundingClientRect().height;
    window.addEventListener("scroll", () => {
    const scrollHeight = window.pageYOffset;
    if (scrollHeight > navHeight) {
        navBar.classList.add("__fix-nav");
    } else {
        navBar.classList.remove("__fix-nav");
    }
    });

    // Scroll To
    const links = [...document.querySelectorAll(".__scroll-link")];
    links.map((link) => {
    if (!link) return;
    link.addEventListener("click", (e) => {
        e.preventDefault();

        const id = e.target.getAttribute("href").slice(1);

        const element = document.getElementById(id);
        const fixNav = navBar.classList.contains("__fix-nav");
        let position = element.offsetTop - navHeight;

        window.scrollTo({
        top: position,
        left: 0,
        });

        navBar.classList.remove("__show");
        menu.classList.remove("__show");
        document.body.classList.remove("__show");
    });
    });

    /*      image click     */
    $('.__thumbnails .__thumbnail img').on('click', function() {
    const selectedImage = $(this).attr('src');
    $('.__main img').attr('src', selectedImage)
    });
  

    const registerErrMsg = $("#error-msg-reg").html();
    if (registerErrMsg != "") {
        $('#signup_span').click();
    }

    $('#signin_span').click(() => {
        $('#_RegForm').css('transform', "translateX(0px)");
        $('#_LoginForm').css('transform', "translateX(0px)");
        $('#_Indicator').css('transform', "translateX(0px)");
    })

    $('#signup_span').click(() => {
        $('#_RegForm').css('transform', "translateX(-300px)");
        $('#_LoginForm').css('transform', "translateX(-300px)");
        $('#_Indicator').css('transform', "translateX(110px)");
    })

    $('#sortBy').on('change', () => {
        var url = window.location.href

        if (url.indexOf("page") > -1) {
            var index = url.indexOf("page") + 5
            url = url.substr(0, index) + "1"
        }

        if (url.indexOf("sortBy") > -1) {
            url = url.substr(0, url.lastIndexOf("=") + 1) + $('#sortBy').val()
        }
        else {
            if (url.indexOf("?") < 0) {
                url += "?"
            } else {
                url += "&"
            }
            url += "sortBy=" + $('#sortBy').val()
        }

        window.location.replace(url)
    })
  
    let x;
    function showToast(mess, toastMess) {
        clearTimeout(x);

        if (mess == "success") {
            $("#toast").removeClass("fail")
        } else {
            $("#toast").removeClass("success")
        }

        $("#toast").addClass(mess)
        $("#toast").css("transform", "translateX(0px)");
        x = setTimeout(() => {
            $("#toast").css("transform", "translateX(400px)");
        }, 7000);

        if (mess == "success") {
            $('.toast-sta').text("Thành công")
            $('.toast-msg').text(toastMess)
        } else {
            $('.toast-sta').text("Thất bại")
            $('.toast-msg').text(toastMess)
        }
    }

    $("#close").on('click', () => {
        $("#toast_success").css("transform", "translateX(400px)");
    })

    // add product to cart
    $('#addToCartForm').submit(function(e) {
        e.preventDefault();
        e.stopImmediatePropagation();

        if ($('#product_color').find(":selected").val() == "selectColor") {
            $('#errorMess').text("Quý khách cần chọn màu sắc cho sản phẩm")
        } else if ($('#product_size').find(":selected").val() == "selectSize") {
            $('#errorMess').text("Quý khách cần chọn kích cỡ cho sản phẩm")
        } else {
            var form = $(this);
            var url = window.location.protocol + "//" + window.location.host + form.attr('action');
            var data = $(this).find(':input').serialize()
            
            $.ajax({
                type: "POST",
                url: url,
                data: data,
                success: function (data) {

                    if (data.status == 'success') {
                        showToast("success", "Sản phẩm đã được thêm vào giỏ hàng")
                    } else {
                        if (data.url != "" && data.mess == "need to login") {
                            var loginUrl = window.location.protocol + "//" + window.location.host + data.url;

                            window.location.replace(loginUrl)
                        } else {
                            showToast("fail", "Rất tiếc đã xảy ra lỗi. Xin vui lòng thử lại sau.")
                        }
                    }
                }
            });
        }
    })

    // clear error messs page Product/Details/id
    $('#product_color').on('change', () => {
        $('#errorMess').text("")
    })

    $('#product_size').on('change', () => {
        $('#errorMess').text("")
    })

    // page Cart -> Cart/Payment
    $('#payment_btn').on('click', (e) => {
        var form = $('#paymentForm');
        var url = window.location.protocol + "//" + window.location.host + form.attr('action');
        var data = form.find(':input[type=checkbox]:checked').serialize()
 
        $.ajax({
            type: "POST",
            url: url,
            data: data,
            success: function (data) {

                if (data.status == 'success') {
                    if (data.url != "" && data.mess == null) {
                        var loginUrl = window.location.protocol + "//" + window.location.host + data.url;

                        window.location.replace(loginUrl)
                    } 
                } else {
                    if (data.url != "" && data.mess == "need to login") {
                        var loginUrl = window.location.protocol + "//" + window.location.host + data.url;

                        window.location.replace(loginUrl)
                    } else {
                        if (data.mess != null) {
                            showToast("fail", data.mess)
                        } else {
                            console.log(data)
                            showToast("fail", "Đã xảy ra lỗi xin quý khách vui lòng tử lại sau")
                        }
                    }
                }
            }
        });

    })

    /*          ACCOUNT INFO            */
    if ($('#ValidDate').val() == '0001-01-01') {
        $('#ValidDate').val("");
    }


    /*          PAYMENT            */
    const currentChecked = $("#info_Method").val();
    if (currentChecked == "COD") {
        $('#CreditCard-info').hide();
    }
    else if (currentChecked == "CreditCard") {
        $('#COD-info').hide();
    }
    
    $("input[name$='paymentType']").click(function () {
        var value = $(this).val();
        $("#info_Method").val(value);

        $('#COD-info').hide();
        $('#CreditCard-info').hide();
        $("#" + value + "-info").show();
    });

    /*       RATING-STAR    */
    /* 1. Visualizing things on Hover - See next part for action on click */
    $('#stars li').on('mouseover', function () {
        var onStar = parseInt($(this).data('value'), 10); // The star currently mouse on

        // Now highlight all the stars that's not after the current hovered star
        $(this).parent().children('li.__star').each(function (e) {
            if (e < onStar) {
                $(this).addClass('__hover');
            }
            else {
                $(this).removeClass('__hover');
            }
        });

    }).on('mouseout', function () {
        $(this).parent().children('li.__star').each(function (e) {
            $(this).removeClass('__hover');
        });
    });

    var ratingValue = 0;
    /* 2. Action to perform on click */
    $('#stars li').on('click', function () {
        var onStar = parseInt($(this).data('value'), 10); // The star currently selected
        var stars = $(this).parent().children('li.__star');

        for (i = 0; i < stars.length; i++) {
            $(stars[i]).removeClass('__selected');
        }

        for (i = 0; i < onStar; i++) {
            $(stars[i]).addClass('__selected');
        }

        // JUST RESPONSE (Not needed)
        ratingValue = parseInt($('#stars li.__selected').last().data('value'), 10);
    });

    //Show rating modal
    var productId = -1, receiptId = -1;
    $('#product-table tbody tr').on('click', function () {
        $('.__popup-rating').show();
        productId = $(this).attr('data-product')
        receiptId = $(this).attr('data-receipt')
    });

    $('._submit-rating').click(function (e) {
        e.stopImmediatePropagation();
        $('.__popup-rating').hide();

        if (ratingValue == 0) {
            showToast("fail", "Cần chọn số sao đánh giá.")
            return;
        }

        var formData = {
            ProductId: productId,
            ReceiptId: receiptId,
            rating: ratingValue
        };;

        var url = window.location.protocol + "//" + window.location.host + '/Product/Rating';

        $.ajax({
            type: "POST",
            url: url,
            data: formData,
            success: function (data) {
                console.log(data)
                if (data.status == 'success') {
                    showToast("success", "Đã lưu đánh đánh giá.")

                    var stars = $("#stars").children('li.__star');
                    for (i = 0; i < stars.length; i++) {
                        $(stars[i]).removeClass('__selected');
                        $(stars[i]).removeClass('__hover');
                    }
                } else {    
                    showToast("fail", "Rất tiếc đã xảy ra lỗi. Xin vui lòng thử lại sau.")
                }
            }
        });
    });

    $('.popupCloseButton').click(function () {
        $('.__popup-rating').hide();
    });
});


gsap.from(".__logo", { opacity: 0, duration: 1, delay: 0.5, y: -10 });
gsap.from(".__hamburger", { opacity: 0, duration: 1, delay: 1, x: 20 });
gsap.from(".__hero-img", { opacity: 0, duration: 1, delay: 1.5, x: -200 });
gsap.from(".__hero-content h2", { opacity: 0, duration: 1, delay: 2, y: -50 });
gsap.from(".__hero-content h1", { opacity: 0, duration: 1, delay: 2.5, y: -45 });
gsap.from(".__hero-content a", { opacity: 0, duration: 1, delay: 3.5, y: 50 });