$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Company's Detail");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/companies/list";
    });
})