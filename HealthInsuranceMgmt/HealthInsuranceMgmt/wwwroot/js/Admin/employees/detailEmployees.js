$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Employee's Detail");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/employees/list";
    });
})