$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Hospital's Detail");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/hospitals/list";
    });
})