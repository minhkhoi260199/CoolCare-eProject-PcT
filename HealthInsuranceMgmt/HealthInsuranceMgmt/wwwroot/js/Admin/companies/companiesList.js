$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Companies List");

    $.ajax({
        url: "/admin/companies/listData",
        type: "POST",
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#companiesTableBody").html(data.data);
            }
        }
    });
    $("#createNew").on("click", function () {
        window.location.href = "/admin/companies/create";
    })
})

function getDetail(id) {
    window.location.href = "/admin/companies/detail?id=" + id;
}