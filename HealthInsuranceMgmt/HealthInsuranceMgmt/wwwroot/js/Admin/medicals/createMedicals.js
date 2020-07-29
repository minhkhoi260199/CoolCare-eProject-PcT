$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Create New Medical");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/medicals/list";
    });
})