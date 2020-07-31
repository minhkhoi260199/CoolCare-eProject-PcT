$(document).ready(function () {
    $("#pageTitle").html("");
    $("#pageTitle").html("Employee's Policy Detail");
    $(".form-control").prop("readonly", true);
    $("#btnGoback").on("click", function () {
        window.location.href = "/admin/policiesonemployees/list";
    });
})

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
                url: '/admin/policiesonemployees/deny',
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
                            window.location.href = "/admin/policiesonemployees/list";
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
                url: '/admin/policiesonemployees/accept',
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
                            window.location.href = "/admin/policiesonemployees/list";
                        });
                    }
                }
            });
        }
    });
}