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

function validateImage() {
    $("#upload-picture").change(function () {
        var validExtensions = ["jpg", "jpeg", "png"];
        var file = $(this).val().split('.').pop();
        if (validExtensions.indexOf(file) == -1) {
            $(this).val("");
        }
    });
}

function preventDuplicateRequests() {
    $("form").submit(function () {
        $("input[type='submit']").attr("disabled", true);
    });
}

function toggleFunctions() {
    preventDuplicateRequests();
    validateImage();
    inputFocusColor();
    focusInputOnClick();
}

$(document).ready(function () {
    toggleFunctions();
});