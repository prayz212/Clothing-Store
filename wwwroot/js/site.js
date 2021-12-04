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

    /*       RATING-STAR    */
    /* 1. Visualizing things on Hover - See next part for action on click */
    $('#stars li').on('mouseover', function(){
    var onStar = parseInt($(this).data('value'), 10); // The star currently mouse on
   
    // Now highlight all the stars that's not after the current hovered star
    $(this).parent().children('li.__star').each(function(e){
        if (e < onStar) {
        $(this).addClass('__hover');
        }
        else {
        $(this).removeClass('__hover');
        }
    });
    
    }).on('mouseout', function(){
    $(this).parent().children('li.__star').each(function(e){
        $(this).removeClass('__hover');
    });
    });
  
  
    /* 2. Action to perform on click */
    $('#stars li').on('click', function(){
    var onStar = parseInt($(this).data('value'), 10); // The star currently selected
    var stars = $(this).parent().children('li.__star');
    
    for (i = 0; i < stars.length; i++) {
        $(stars[i]).removeClass('__selected');
    }
    
    for (i = 0; i < onStar; i++) {
        $(stars[i]).addClass('__selected');
    }
    
    // JUST RESPONSE (Not needed)
    var ratingValue = parseInt($('#stars li.__selected').last().data('value'), 10);
    });

    $('.__thumbnails .__thumbnail img').on('click', function() {
    const selectedImage = $(this).attr('src');
    $('.__main img').attr('src', selectedImage)
    });
  
    $("#check_all").click(function(){
    $('input:checkbox').not(this).prop('checked', this.checked);
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
});


gsap.from(".__logo", { opacity: 0, duration: 1, delay: 0.5, y: -10 });
gsap.from(".__hamburger", { opacity: 0, duration: 1, delay: 1, x: 20 });
gsap.from(".__hero-img", { opacity: 0, duration: 1, delay: 1.5, x: -200 });
gsap.from(".__hero-content h2", { opacity: 0, duration: 1, delay: 2, y: -50 });
gsap.from(".__hero-content h1", { opacity: 0, duration: 1, delay: 2.5, y: -45 });
gsap.from(".__hero-content a", { opacity: 0, duration: 1, delay: 3.5, y: 50 });