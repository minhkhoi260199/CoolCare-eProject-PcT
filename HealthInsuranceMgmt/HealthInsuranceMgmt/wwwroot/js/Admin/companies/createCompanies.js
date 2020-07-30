$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Create New Company");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/companies/list";
    });
})