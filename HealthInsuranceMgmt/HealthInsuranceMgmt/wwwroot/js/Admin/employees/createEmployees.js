$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Create New Employee");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/employees/list";
    });
})