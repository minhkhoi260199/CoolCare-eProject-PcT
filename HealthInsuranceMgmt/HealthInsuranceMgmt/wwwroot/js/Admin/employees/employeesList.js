$(document).ready(function () {
    var searchFirstName = "";
    $("#pageTitle").html("");
    $("#pageTitle").html("Employees List");
    loadData();
    $("#createNew").on("click", function () {
        window.location.href = "/admin/employees/create";
    })
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
            loadData(curPos, 5, searchFirstName);
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
            loadData(curPos, 5, searchFirstName);
        }
    });
    $(document).on("click", "#searchBtn", function () {
        searchFirstName = $("#searchFirstName").val();
        loadData(0, 5, searchFirstName);
    });
    $(document).on("click", "#showAll", function () {
        searchFirstName = "";
        loadData(0, 5, searchFirstName);
    })
});
function loadData(fromNum = 0, limitNum = 5, searchData = "") {
    $.ajax({
        url: "/admin/employees/listData",
        type: "POST",
        data: {
            fromNum: fromNum,
            limitNum: limitNum,
            searchData: searchData,
        },
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#employeeTableBody").html(data.data);
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

