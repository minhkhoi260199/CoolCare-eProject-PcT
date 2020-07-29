$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Policy List");

    $.ajax({
        url: "/admin/policies/listData",
        type: "POST",
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#policyTableBody").html(data.data);
            }
        }
    });
    $("#createNew").on("click", function () {
        window.location.href = "/admin/policies/create";
    })
});
function getDetail(id) {
    window.location.href = "/admin/policies/detail?id=" + id;
}