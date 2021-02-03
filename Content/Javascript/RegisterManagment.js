

$(document).ready(function () {
    fetchData();
});


$("#Lbl_Edit").hide();
$("#Btn_Edit").hide();

// add address type
$("#Btn_Add").click(function () {
    var register_Type = $("#Txt_Register_Type").val();
    $.ajax({
        url: '../RegisterManagment/Add_Register',
        type: 'POST',
        data: {
            register_Type: register_Type
        }, success: function (data) {
            fetchData();
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
function fetchData() {
    $.ajax({
        url: "../RegisterManagment/Fetch_Data",
        success: function (data) {
            console.log(data);
            // delete previous

            $('#Tbl_Register_Type').DataTable().destroy();
            // add new one
            $('#Tbl_Register_Type').DataTable({

                autoFill: true,
                data: data,
                columns: [
                    {
                        'data': 'Reg_Mode_Type_Id'
                    },
                    //{
                    //    'data': 'Address_Type_Id', render: function (data, type, row) {
                    //        return data;
                    //    }
                    //},
                    {
                        'data': 'Reg_Mode_Type'
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-primary" onclick=\'Update_Register_Type( "' + row.Reg_Mode_Type_Id + '" , "' + row.Reg_Mode_Type + '")\'>Edit</button>'
                        }
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-warning" onclick=\'delete_Register_Type("' + row.Reg_Mode_Type_Id + '")\'>Delete</button>'
                        }
                    }
                ]
            });
        }
    });
}





function Update_Register_Type(id, type) {
    swal({
        text: id + " : " + type,
        button: "Close"
    });
}

function delete_Register_Type(id) {
    swal({
        text: id,
        button: "Close"
    });
}

