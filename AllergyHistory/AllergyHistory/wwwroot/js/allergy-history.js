﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    var dataTable = $("#example").DataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": true, // this is for disable filter (search box)
        "orderMulti": false, // for disable multiple column at once
        "ajax": {
            "url": "/home/loadData",
            "type": "POST",
            "datatype": "json"
        },
        //"columnDefs":
        //    [{
        //        "targets": [0],
        //        "visible": false,
        //        "searchable": false
        //    }],

        "columns": [
            { "data": "patient", "name": "patient", "autoWidth": true },
            { "data": "type", "name": "type", "autoWidth": true },
            { "data": "allergen", "name": "allergen", "autoWidth": true },
            { "data": "reaction", "name": "reaction", "autoWidth": true },
            { "data": "serverty", "name": "serverty", "autoWidth": true },
            { "data": "notes", "name": "notes", "autoWidth": true },
            { "data": "createInfo", "name": "createInfo", "autoWidth": true },
            { "data": "updateInfo", "name": "updateInfo", "autoWidth": true },
            {
                data: null, render: function (data, type, row) {
                    return "<a href='#' class='btn btn-inf' onclick=EditData('" + row.patient + "'); >Edit</a>";
                }
            },
        ],
        dom: '<"allergy-table-button"B>rt<"allergy-table-len"l>ip',
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

    //dataTable.buttons().container()
    //    .appendTo($('#printButtons'));

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

