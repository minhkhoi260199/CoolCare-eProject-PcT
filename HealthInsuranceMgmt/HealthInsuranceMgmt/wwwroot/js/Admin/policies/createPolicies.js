$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Create New Policy");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/policies/list";
    });
})