$(document).ready(function () {
    var searchEmployeeName = "";
    $("#pageTitle").html("");
    $("#pageTitle").html("Employees' Policies List");
    loadData();

    $(document).on("click", "#nextBtn", function () {
        let curPageData = $("#curPage").val();
        curPageData = Number(curPageData) + 1;
        curPos = curPageData * 5 - 5;
        if (curPageData > $("#totalPage").val()) {
            $("#nextBtn").prop("disabled", true);
        } else {
            if (curPageData == $("#totalPage").val()) {
                $("#nextBtn").prop("disabled", true);
            }
            $("#backBtn").prop("disabled", false);
            loadData(curPos, 5, searchEmployeeName);
        }
    });
    $(document).on("click", "#backBtn", function () {
        let curPageData = $("#curPage").val();
        curPageData = Number(curPageData) - 1;
        curPos = curPageData * 5 - 5;
        if (curPageData < 1) {
            $("#backBtn").prop("disabled", true);
        } else {
            if (curPageData == 1) {
                $("#backBtn").prop("disabled", true);
            }
            $("#nextBtn").prop("disabled", false);
            loadData(curPos, 5, searchEmployeeName);
        }
    });
    $(document).on("click", "#searchBtn", function () {
        searchEmployeeName = $("#searchEmployeeName").val();
        loadData(0, 5, searchEmployeeName);
    });
    $(document).on("click", "#showAll", function () {
        searchEmployeeName = "";
        loadData(0, 5, searchEmployeeName);
    })
});
function loadData(fromNum = 0, limitNum = 5, searchData = "") {
    $.ajax({
        url: "/admin/policiesonemployees/listData",
        type: "POST",
        data: {
            fromNum: fromNum,
            limitNum: limitNum,
            searchData: searchData,
        },
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#policiesEmployeesTableBody").html(data.data);

                let totalPage = data.pageTotal;
                let curPage = Math.round(fromNum / 5) + 1;
                let showPage = curPage + "/" + totalPage;
                if (curPage == 1) {
                    $("#backBtn").prop("disabled", true);
                    $("#nextBtn").prop("disabled", false);
                    if (totalPage == curPage) {
                        $("#nextBtn").prop("disabled", true);
                    }
                }
                $("#showPage").html(showPage);
                $("#totalPage").val(data.pageTotal);
                $("#curPage").val(curPage);
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