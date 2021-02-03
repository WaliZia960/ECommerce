

$(document).ready(function () {
    fetchData();
});


$("#Lbl_Edit").hide();
$("#Btn_Edit").hide();

// add address type
$("#Btn_Add").click(function () {
    var contact_Type = $("#Txt_Contact_Type").val();
    $.ajax({
        url: '../ContactManagment/Add_Contact',
        type: 'POST',
        data: {
            contact_Type: contact_Type
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
        url: "../ContactManagment/Fetch_Data",
        success: function (data) {
            console.log(data);
            // delete previous

            $('#Tbl_Contact_Type').DataTable().destroy();
            // add new one
            $('#Tbl_Contact_Type').DataTable({

                autoFill: true,
                data: data,
                columns: [
                    {
                        'data': 'Contact_Type_Id'
                    },
                    //{
                    //    'data': 'Address_Type_Id', render: function (data, type, row) {
                    //        return data;
                    //    }
                    //},
                    {
                        'data': 'Contact_Type'
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-primary" onclick=\'Update_Contact_Type( "' + row.Contact_Type_Id + '" , "' + row.Contact_Type + '")\'>Edit</button>'
                        }
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-warning" onclick=\'delete_Contact_Type("' + row.Contact_Type_Id + '")\'>Delete</button>'
                        }
                    }
                ]
            });
        }
    });
}





function Update_Contact_Type(id, type) {
    swal({
        text: id + " : " + type,
        button: "Close"
    });
}

function delete_Contact_Type(id) {
    swal({
        text: id,
        button: "Close"
    });
}

