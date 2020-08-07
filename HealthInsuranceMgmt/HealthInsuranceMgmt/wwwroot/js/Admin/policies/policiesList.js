$(document).ready(function () {
    var searchPolicyName = "";
    $("#pageTitle").html("");
    $("#pageTitle").html("Policy List");

    loadData();
    $("#createNew").on("click", function () {
        window.location.href = "/admin/policies/create";
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
            loadData(curPos, 5, searchPolicyName);
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
            loadData(curPos, 5, searchPolicyName);
        }
    });
    $(document).on("click", "#searchBtn", function () {
        searchPolicyName = $("#searchPolicyName").val();
        loadData(0, 5, searchPolicyName);
    });
    $(document).on("click", "#showAll", function () {
        searchPolicyName = "";
        loadData(0, 5, searchPolicyName);
    });
});
function getDetail(id) {
    window.location.href = "/admin/policies/detail?id=" + id;
}

function loadData(fromNum = 0, limitNum = 5, searchData = ""){
    $.ajax({
        url: "/admin/policies/listData",
        type: "POST",
        data: {
            fromNum: fromNum,
            limitNum: limitNum,
            searchData: searchData,
        },
        success: function (res) {
            let data = res[0];
            if (data.status) {
                $("#policyTableBody").html(data.data);

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