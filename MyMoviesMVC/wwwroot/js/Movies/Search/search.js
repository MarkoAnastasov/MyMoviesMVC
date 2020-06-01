function getSearchParamForTitle() {
    var params = (new URL(document.location)).searchParams;
    var title = params.get("title");
    if (title != null) {
        $("#title").val(title.trim());
    }
}

$(document).ready(function () {
    getSearchParamForTitle();
})
