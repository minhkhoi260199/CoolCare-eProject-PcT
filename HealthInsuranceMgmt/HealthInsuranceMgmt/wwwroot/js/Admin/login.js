$(document).ready(function () {
    $(document).on("click", "#signIn", function (e) {
        e.preventDefault();
        let userName = $("#username").val();
        let password = $("#password").val();
        if (userName == "" || password == "") {
            if (userName == "") {
                $("#usernameError").html("Username can't be missing");
            }
            if (password == "") {
                $("#passwordError").html("Password can't be missing");
            }
            return;
        } else {
            $.ajax({
                type: "POST",
                //processData: false,
                //contentType: false,
                data: {
                    userName: userName,
                    password: password
                },
                url: "/admin/login/postLogin",
                success: function (data) {
                    if (data) {
                        window.location.href = "/admin/policiesonemployees/list";
                    } else {
                        $("#usernameError").html("Username is wrong");
                        $("#passwordError").html("Password is wrong");
                    }
                }
            })
        }
    });
})