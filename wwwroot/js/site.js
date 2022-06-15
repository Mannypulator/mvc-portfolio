// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// NAV HAMBURGR MENU
const navIcon = document.querySelector(".nav--icon");
const navSecond = document.querySelector(".nav--second");

navIcon.addEventListener("click", function () {
    if (this.classList.contains("nav--anim")) {
        this.classList.remove("nav--anim");
        navSecond.classList.remove("showIn");
    } else {
        this.classList.add("nav--anim");
        navSecond.classList.add("showIn");
    }
});

// CLOSE THE NAV WHEN THE NAV LINKS ARE GETTING CLICKED
const navLinks = document.querySelectorAll(".nav__link");

navLinks.forEach(function (navLink) {
    navLink.addEventListener("click", function () {
        navSecond.classList.remove("showIn");
        navIcon.classList.remove("nav--anim");
    });
});

// CLOSE THE NAV WHEN THE SIDE NAV LOGO IS CLICKED
const logoWhite = document.querySelector(".logo--white");

logoWhite.addEventListener("click", function () {
    navSecond.classList.remove("showIn");
    navIcon.classList.remove("nav--anim");
});


//based on https://dribbble.com/shots/3913847-404-page

var pageX = $(document).width();
var pageY = $(document).height();
var mouseY = 0;
var mouseX = 0;

$(document).mousemove(function (event) {
    //verticalAxis
    mouseY = event.pageY;
    yAxis = (pageY / 2 - mouseY) / pageY * 300;
    //horizontalAxis
    mouseX = event.pageX / -pageX;
    xAxis = -mouseX * 100 - 100;

    $('.box__ghost-eyes').css({ 'transform': 'translate(' + xAxis + '%,-' + yAxis + '%)' });

    //console.log('X: ' + xAxis);

});

