    $('#Btnsignup').click(function () {
        var name = $("#name").val()
        var email = $("#email").val()
        var pass = $("#pass").val()
        var re_pass = $("#re_pass").val()
        $.ajax({
            url: "../Register/Register_User",
            data: {
                name: name,
                email: email,
                pass: pass,
                re_pass: re_pass
            }, success: function (data) {
                swal({
                    text: data,
                    button: "Close",
                });
            }, error: function (data) {
                swal({
                    text: data,
                    button: "Close",
                });
            }
        });

    });
