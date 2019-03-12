// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


var selectedAllergen;
var selectedAllergenType;
var selectedAllergenReaction;
var selectedAllergenSeverity;
var selectedMedication;


// get value from selected box

$('#allergenTypeSelectBox').change(function (e) {
    console.log($('#allergenTypeSelectBox').val());
    var typeId = $('#allergenTypeSelectBox').val();

    //Medication
    if (typeId == "612") {
        $('#medicationOption').show();
    }
    else {
        $('#medicationOption').hide();
    }

    ////alert(e.target.value);
    //selectedMedication = e.target.value;
    //$('#medicationSelectBox').value = e.target.value;

    console.log($('#allergenTypeSelectBox').val());
});


// Set value for selected box

//$('#medicationSelectBox').selectpicker('refresh');

$("#submitButton").click(function (e) {
    e.preventDefault();

    var data = {
        typeId: $('#allergenTypeSelectBox').val(),
        severityId: $('#allergenSeveritySelectBox').val(),
        reactionId: $('#allergenReactionSelectBox').val(),
        allergenId: $('#allergenSelectBox').val(),
        drugId: $('#medicationSelectBox').val(),
        notes: $('#noteText').val()
    }

    console.log(data);

    //$.ajax({
    //    type: "POST",
    //    url: "/imball-reagens/public/shareitem",
    //    data: {
    //        id: $("#Shareitem").val(),
    //        access_token: $("#access_token").val(),

    //    },

    //    success: function (result) {
    //        $("#sharelink").html(result);
    //    }
    //});
});


$("#resetButton").click(function (e) {
    $('#allergenTypeSelectBox').val(-1);
    $('#allergenTypeSelectBox').selectpicker('refresh');

    $('#allergenSeveritySelectBox').val(-1);
    $('#allergenSeveritySelectBox').selectpicker('refresh');

    $('#allergenReactionSelectBox').val(-1);
    $('#allergenReactionSelectBox').selectpicker('refresh');

    $('#allergenSelectBox').val(-1);
    $('#allergenSelectBox').selectpicker('refresh');

    $('#medicationSelectBox').val(-1);
    $('#medicationSelectBox').selectpicker('refresh');

    $('#noteText').val("");

});