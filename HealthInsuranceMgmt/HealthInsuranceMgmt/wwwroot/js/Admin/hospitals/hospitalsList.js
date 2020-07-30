$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Hospital List");

    $.ajax({
        url: "/admin/hospitals/listData",
        type: "POST",
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#hospitalTableBody").html(data.data);
            }
        }
    });
    $("#createNew").on("click", function () {
        window.location.href = "/admin/hospitals/create";
    })
});
function getDetail(id) {
    window.location.href = "/admin/hospitals/detail?id=" + id;
}