function inputFocusColor() {
    $(".account-inputs").children().focus(function () {
        $(this).prev().css("background-color", "#484848");
    });
    $(".account-inputs").children().focusout(function () {
        $(this).prev().css("background-color", "#313131");
    });
}

function focusInputOnClick() {
    $(".input-icon").click(function () {
        $(this).next().focus();
    })
}

function preventDuplicateRequests() {
    $("form").submit(function () {
        $("input[type='submit']").attr("disabled", true);
    });
}

function toggleFunctions() {
    preventDuplicateRequests();
    inputFocusColor();
    focusInputOnClick();
}

$(document).ready(function () {
    toggleFunctions();
});