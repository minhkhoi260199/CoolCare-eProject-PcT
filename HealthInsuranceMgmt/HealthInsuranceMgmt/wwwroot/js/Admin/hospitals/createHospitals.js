$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Create New Hospital");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/hospitals/list";
    });
})