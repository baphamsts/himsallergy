// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#example").DataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": true, // this is for disable filter (search box)
        "orderMulti": false, // for disable multiple column at once
        "ajax": {
            "url": "http://localhost:51189/api/patient/loadData",
            "type": "POST",
            "datatype": "json"
        },
        "columnDefs":
            [{
                "targets": [0],
                "visible": false,
                "searchable": false
            }],
        
        "columns": [
            { "data": "patientName", "name": "patientName", "autoWidth": true },
            { "data": "gender", "name": "gender", "autoWidth": true },
            { "data": "provider", "name": "provider", "autoWidth": true },
            { "data": "population", "name": "population", "autoWidth": true },
            { "data": "allergen", "name": "allergen", "autoWidth": true },
            {
                "render": function (data, type, full, meta) { return '<a class="btn btn-info" href="/DemoGrid/Edit/' + full.CustomerID + '">Edit</a>'; }
            },
            {
                data: null, render: function (data, type, row) {
                    return "<a href='#' class='btn btn-danger' onclick=DeleteData('" + row.CustomerID + "'); >Delete</a>";
                }
            },
        ],
        dom: 'Bfrtip',
        buttons: [
            {
                extend: 'print',
                text: 'Change View',
                autoPrint: false,
                customize: function (win) {
                    $(win.document.body)
                        .css('font-size', '10pt');

                    $(win.document.body).find('table')
                        .addClass('compact')
                        .css('font-size', 'inherit');
                }
            },
            {
                extend: 'print',
                text: 'Print List',
                customize: function (win) {
                    $(win.document.body)
                        .css('font-size', '10pt');

                    $(win.document.body).find('table')
                        .addClass('compact')
                        .css('font-size', 'inherit');
                }
            },
            {
                extend: 'excelHtml5',
                text: 'Download as Exel',
                exportOptions: {
                    modifier: {
                        page: 'current'
                    }
                }
            },
            {
                extend: 'pdfHtml5',
                text: 'Download as PDF',
                exportOptions: {
                    modifier: {
                        page: 'current'
                    }
                }
            }
        ]
    });

    $('.selectpicker').selectpicker();
});


function DeleteData(CustomerID) {
    if (confirm("Are you sure you want to delete ...?")) {
        Delete(CustomerID);
    }
    else {
        return false;
    }
}


function Delete(CustomerID) {
    var url = '@Url.Content("~/")' + "DemoGrid/Delete";

    $.post(url, { ID: CustomerID }, function (data) {
        if (data) {
            oTable = $('#example').DataTable();
            oTable.draw();
        }
        else {
            alert("Something Went Wrong!");
        }
    });
}