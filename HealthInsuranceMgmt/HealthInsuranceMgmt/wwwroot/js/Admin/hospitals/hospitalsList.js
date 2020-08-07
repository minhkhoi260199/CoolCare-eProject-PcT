$(document).ready(function () {
    var searchHospital = "";
    $("#pageTitle").html("");
    $("#pageTitle").html("Hospital List");

    loadData();
    $("#createNew").on("click", function () {
        window.location.href = "/admin/hospitals/create";
    });
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
            loadData(curPos, 5, searchHospital);
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
            loadData(curPos, 5, searchHospital);
        }
    });
    $(document).on("click", "#searchBtn", function () {
        searchHospital = $("#searchHospital").val();
        loadData(0, 5, searchHospital);
    });
    $(document).on("click", "#showAll", function () {
        searchHospital = "";
        loadData(0, 5, searchHospital);
    });
});
function getDetail(id) {
    window.location.href = "/admin/hospitals/detail?id=" + id;
}
function loadData(fromNum = 0, limitNum = 5, searchData = "") {
    $.ajax({
        url: "/admin/hospitals/listData",
        type: "POST",
        data: {
            fromNum: fromNum,
            limitNum: limitNum,
            searchData: searchData,
        },
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#hospitalTableBody").html(data.data);

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

function deleteFunction(id) {
    swal({
        title: "Block Confirm?",
        text: "Do you want to delete this hospital?",
        icon: "warning",
        buttons: {
            confirm: "Yes",
            cancel: "Close",
        },
        dangerMode: true,
    }).then((willDelete) => {
        $.ajax({
            url: '/admin/hospitals/delete?id=' + id,
            type: "POST",
            success: function (res) {
                let data = res[0];
                if (data.status) {
                    swal({
                        title: "Succeed!",
                        text: "Deleted Successful",
                        icon: "success",
                        button: {
                            cancel: "Close",
                        }
                    })
                    let searchHospitalData = $("#searchHospital").val();
                    loadData(0, 5, searchHospitalData);
                } else {
                    swal({
                        title: "Error!",
                        text: data.error,
                        icon: "error",
                        button: {
                            cancel: "Close",
                        }
                    })
                }
            }
        })
    });
}