function validateImage() {
    $("#upload-picture").change(function () {
        var validExtensions = ["jpg", "jpeg", "png"];
        var file = $(this).val().split('.').pop();
        if (validExtensions.indexOf(file) == -1) {
            $(this).val("");
        }
    });
}

$(document).ready(function () {
    validateImage();
});