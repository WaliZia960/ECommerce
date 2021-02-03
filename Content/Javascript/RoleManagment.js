

$(document).ready(function () {
    fetchData();

});


$("#Lbl_Edit").hide();
$("#Btn_Edit").hide();

// add address type
$("#Btn_Add").click(function () {
    var role_Type = $("#Txt_Role_Type").val();
    $.ajax({
        url: '../RoleManagment/Add_Role',
        type: 'POST',
        data: {
            role_Type: role_Type
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
        url: "../RoleManagment/Fetch_Data",
        success: function (data) {
            console.log(data);
            // delete previous

            $('#Tbl_Role_Type').DataTable().destroy();
            // add new one
            $('#Tbl_Role_Type').DataTable({

                autoFill: true,
                data: data,
                columns: [
                    {
                        'data': 'Role_Type_Id'
                    },
                    //{
                    //    'data': 'Address_Type_Id', render: function (data, type, row) {
                    //        return data;
                    //    }
                    //},
                    {
                        'data': 'Role_Type'
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-primary" onclick=\'Update_Role_Type( "' + row.Role_Type_Id + '" , "' + row.Role_Type + '")\'>Edit</button>'
                        }
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-warning" onclick=\'delete_Role_Type("' + row.Role_Type_Id + '")\'>Delete</button>'
                        }
                    }
                ]
            });
        }
    });
}





function Update_Role_Type(id, type) {
    swal({
        text: id + " : " + type,
        button: "Close"
    });
}

function delete_Role_Type(id) {
    swal({
        text: id,
        button: "Close"
    });
}

