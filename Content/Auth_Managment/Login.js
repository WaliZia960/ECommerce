$('#signin').click(function () {
    var email = $("#your_email").val();
    var pass = $("#your_pass").val();
    swal({
        text: email + " : " + pass,
        button: "Close",
    });
});