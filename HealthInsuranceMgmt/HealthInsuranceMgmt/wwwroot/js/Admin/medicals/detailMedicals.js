$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Medical's Detail");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/medicals/list";
    });
})