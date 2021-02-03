

$(document).ready(function () {
    fetchData();
});


$("#Lbl_Edit").hide();
$("#Btn_Edit").hide();

// add address type
$("#Btn_Add").click(function () {
    var status_Type = $("#Txt_Status_Type").val();
    $.ajax({
        url: '../StatusManagment/Add_Status',
        type: 'POST',
        data: {
            status_Type: status_Type
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
        url: "../StatusManagment/Fetch_Data",
        success: function (data) {
            console.log(data);
            // delete previous

            $('#Tbl_Status_Type').DataTable().destroy();
            // add new one
            $('#Tbl_Status_Type').DataTable({

                autoFill: true,
                data: data,
                columns: [
                    {
                        'data': 'Status_Type_Id'
                    },
                    //{
                    //    'data': 'Address_Type_Id', render: function (data, type, row) {
                    //        return data;
                    //    }
                    //},
                    {
                        'data': 'Status_Type'
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-primary" onclick=\'Update_Status_Type( "' + row.Status_Type_Id + '" , "' + row.Status_Type + '")\'>Edit</button>'
                        }
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-warning" onclick=\'delete_Status_Type("' + row.Status_Type_Id + '")\'>Delete</button>'
                        }
                    }
                ]
            });
        }
    });
}





function Update_Status_Type(id, type) {
    swal({
        text: id + " : " + type,
        button: "Close"
    });
}

function delete_Status_Type(id) {
    swal({
        text: id,
        button: "Close"
    });
}

