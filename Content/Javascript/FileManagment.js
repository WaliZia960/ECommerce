

$(document).ready(function () {
    fetchData();
});


$("#Lbl_Edit").hide();
$("#Btn_Edit").hide();

// add address type
$("#Btn_Add").click(function () {
    var file_Type = $("#Txt_File_Type").val();
    $.ajax({
        url: '../FileManagment/Add_File',
        type: 'POST',
        data: {
            file_Type: file_Type
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
        url: "../FileManagment/Fetch_Data",
        success: function (data) {
            console.log(data);
            // delete previous

            $('#Tbl_File_Type').DataTable().destroy();
            // add new one
            $('#Tbl_File_Type').DataTable({

                autoFill: true,
                data: data,
                columns: [
                    {
                        'data': 'File_Type_Id'
                    },
                    //{
                    //    'data': 'Address_Type_Id', render: function (data, type, row) {
                    //        return data;
                    //    }
                    //},
                    {
                        'data': 'File_Type'
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-primary" onclick=\'Update_File_Type( "' + row.File_Type_Id + '" , "' + row.File_Type + '")\'>Edit</button>'
                        }
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-warning" onclick=\'delete_File_Type("' + row.File_Type_Id + '")\'>Delete</button>'
                        }
                    }
                ]
            });
        }
    });
}





function Update_File_Type(id, type) {
    swal({
        text: id + " : " + type,
        button: "Close"
    });
}

function delete_File_Type(id) {
    swal({
        text: id,
        button: "Close"
    });
}

