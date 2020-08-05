$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Policy Request List");
    loadData();

});
function loadData() {
    $.ajax({
        url: "/admin/policyrequest/listData",
        type: "POST",
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#policyRequestTableBody").html(data.data);
            }
        }
    });
}
function deniedBtn(idPolOnEm) {
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
                url: '/admin/policyrequest/deny',
                type: "POST",
                data: { id: idPolOnEm },
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
                            $("#policyRequestTableBody").html("");
                            loadData();
                        });
                    }
                }
            });
        }
    });
}

function acceptedBtn(idPolOnEm) {
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
                url: '/admin/policyrequest/accept',
                type: "POST",
                data: { id: idPolOnEm },
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
    window.location.href = "/admin/policyrequest/detail?id=" + id;
}