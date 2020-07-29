$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Policy's Detail");

    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/policies/list";
    });
})