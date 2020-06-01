function toggleMenu() {
    $("#user-info-full").click(function () {
        $("#toggle-full-menu").slideToggle("medium");
        $(this).toggleClass("user-info-full-bgcolor");
    });
}

function hideMenuOutOfFocus() {
    var menuButton = $("#user-info-full").children();
    $(document).click(function (event) {
        if (!$(event.target).is(menuButton)) {
            if ($("#toggle-full-menu").css("display") === ("block")) {
                $("#toggle-full-menu").css("display", "none");
                $("#user-info-full").removeClass("user-info-full-bgcolor");
            }
        }
    });
}

function preventDuplicateRequests() {
    $("form").submit(function () {
        $("input[type='submit']").attr("disabled", true);
    });
}

function toggleFunctions() {
    toggleMenu();
    hideMenuOutOfFocus();
    preventDuplicateRequests();
}

$(document).ready(function () {
    toggleFunctions();
});