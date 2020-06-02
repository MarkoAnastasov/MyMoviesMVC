function switchMovieTabs() {
    $("#all-movies").click(function () {
        $(this).css("background-color", "#529ebb");
        $(this).css("color", "#0e0e0e");
        $("#favourite-movies").css("background-color", "#333333");
        $("#favourite-movies").css("color", "#529ebb");
        $("#watched-movies").css("background-color", "#333333");
        $("#watched-movies").css("color", "#529ebb");
        $("#all-container").css("display", "flex");
        $("#favourite-container").css("display", "none");
        $("#watched-container").css("display", "none");
    });
    $("#favourite-movies").click(function () {
        $(this).css("background-color", "#529ebb");
        $(this).css("color", "#0e0e0e");
        $("#all-movies").css("background-color", "#333333");
        $("#all-movies").css("color", "#529ebb");
        $("#watched-movies").css("background-color", "#333333");
        $("#watched-movies").css("color", "#529ebb");
        $("#all-container").css("display", "none");
        $("#favourite-container").css("display", "flex");
        $("#watched-container").css("display", "none");
    });
    $("#watched-movies").click(function () {
        $(this).css("background-color", "#529ebb");
        $(this).css("color", "#0e0e0e");
        $("#favourite-movies").css("background-color", "#333333");
        $("#favourite-movies").css("color", "#529ebb");
        $("#all-movies").css("background-color", "#333333");
        $("#all-movies").css("color", "#529ebb");
        $("#all-container").css("display", "none");
        $("#favourite-container").css("display", "none");
        $("#watched-container").css("display", "flex");
    });
    
}

$(document).ready(function () {
    switchMovieTabs();
});