$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Employees List");
    loadData();
    $("#createNew").on("click", function () {
        window.location.href = "/admin/employees/create";
    })

});
function loadData() {
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
}
function getDetail(id) {
    window.location.href = "/admin/employees/detail?id=" + id;
}

function blockBtn(idEmp) {
    swal({
        title: "Block Confirm?",
        text: "Do you want to block this user?",
        icon: "warning",
        buttons: {
            confirm: "Yes",
            cancel: "Close",
        },
        dangerMode: true,
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                url: '/admin/employees/block',
                type: "POST",
                data: { id: idEmp },
                success: function (res) {
                    swal.close();
                    let data = res[0];
                    if (data.data) {
                        swal({
                            title: "Succeed",
                            text: "Deleted",
                            icon: "success",
                            timer: 2500,
                            button: "Close",
                        }).then((value) => {
                            $("#employeeTableBody").html("");
                            loadData();
                        });
                    }
                }
            });
        }
    });
}