

$(document).ready(function () {
    fetchData();

});


$("#Lbl_Edit").hide();
$("#Btn_Edit").hide();

// add address type
$("#Btn_Add").click(function () {
    var address_Type = $("#Txt_Address_Type").val();
    $.ajax({
        url: '../AddressManagment/Add_Address',
        type: 'POST',
        data: {
            address_Type: address_Type
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
        url: "../AddressManagment/Fetch_Data",
        success: function (data) {
             console.log(data);
            // delete previous
            
            $('#Tbl_Address_Type').DataTable().destroy();
            // add new one
            $('#Tbl_Address_Type').DataTable({
                
                autoFill: true,
                data: data,
                columns: [
                    {
                        'data': 'Address_Type_Id'
                    },
                    //{
                    //    'data': 'Address_Type_Id', render: function (data, type, row) {
                    //        return data;
                    //    }
                    //},
                    {
                        'data': 'Address_Type'
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-primary" onclick=\'Update_Address_Type( "' + row.Address_Type_Id + '" , "' + row.Address_Type + '")\'>Edit</button>'
                        }
                    },
                    {
                        data: null, render: function (data, type, row) {
                            return '<button class="btn btn-warning" onclick=\'delete_Address_Type("' + row.Address_Type_Id + '")\'>Delete</button>'
                        }
                    }
                ]
            });
        }
    });
}





function Update_Address_Type(id, type) {
    swal({
        text: id + " : " + type,
        button: "Close"
    });
}

function delete_Address_Type(id) {
    swal({
        text: id,
        button: "Close"
    });
}

