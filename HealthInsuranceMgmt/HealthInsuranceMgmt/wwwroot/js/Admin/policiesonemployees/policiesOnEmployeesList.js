$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Employees' Policies List");
    loadData();

});
function loadData() {
    $.ajax({
        url: "/admin/policiesonemployees/listData",
        type: "POST",
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#policiesEmployeesTableBody").html(data.data);
            }
        }
    });
}
function deniedBtn(id) {
    swal({
        title: "Cancel Confirm?",
        text: "Do you want to cancel this user's policy?",
        icon: "warning",
        buttons: {
            confirm: "Yes",
            cancel: "Close",
        },
        dangerMode: true,
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                url: '/admin/policiesonemployees/deny',
                type: "POST",
                data: { id: id },
                success: function (res) {
                    swal.close();
                    let data = res[0];
                    if (data.data) {
                        swal({
                            title: "Succeed",
                            text: "Denied",
                            icon: "success",
                            timer: 2500,
                            button: "Close",
                        }).then((value) => {
                            $("#policiesEmployeesTableBody").html("");
                            loadData();
                        });
                    }
                }
            });
        }
    });
}

function acceptedBtn(id) {
    swal({
        title: "Accept Confirm?",
        text: "Do you want to accept this user's policy?",
        icon: "warning",
        buttons: {
            confirm: "Yes",
            cancel: "Close",
        },
        dangerMode: true,
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                url: '/admin/policiesonemployees/accept',
                type: "POST",
                data: { id: id },
                success: function (res) {
                    swal.close();
                    let data = res[0];
                    if (data.data) {
                        swal({
                            title: "Succeed",
                            text: "Accepted",
                            icon: "success",
                            timer: 2500,
                            button: "Close",
                        }).then((value) => {
                            $("#policiesEmployeesTableBody").html("");
                            loadData();
                        });
                    }
                }
            });
        }
    });
}

function getDetail(id) {
    window.location.href = "/admin/policiesonemployees/detail?id=" + id;
}