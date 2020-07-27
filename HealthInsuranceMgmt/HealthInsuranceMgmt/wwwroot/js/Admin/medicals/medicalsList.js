$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Medical List");

    $.ajax({
        url: "/admin/medicals/listData",
        type: "POST",
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#medicalTableBody").html(data.data);
            }
        }
    });
    $("#createNew").on("click", function () {
        window.location.href = "/admin/medicals/create";
    })
});
function getDetail(id) {
    window.location.href = "/admin/medicals/detail?id=" + id;
}