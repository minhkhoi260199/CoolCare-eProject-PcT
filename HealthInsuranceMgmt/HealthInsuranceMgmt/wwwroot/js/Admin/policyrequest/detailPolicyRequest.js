$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Policy Request Detail");
    $(".form-control").prop("readonly", true);
    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/policyrequest/list";
    });
})

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
                url: '/admin/policyrequest/deny',
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
                            window.location.href = "/admin/policyrequest/list";
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
                url: '/admin/policyrequest/accept',
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
                            window.location.href = "/admin/policyrequest/list";
                        });
                    }
                }
            });
        }
    });
}