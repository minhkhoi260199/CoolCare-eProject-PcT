$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Employees List");

    $.ajax({
        url: "/admin/employees/listData",
        type: "POST",
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#employeeTableBody").html(data.data);
            }
        }
    });
    $("#createNew").on("click", function () {
        window.location.href = "/admin/employees/create";
    })
});
function getDetail(id) {
    window.location.href = "/admin/employees/detail?id=" + id;
}