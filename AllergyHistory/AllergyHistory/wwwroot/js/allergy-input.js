// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


var selectedAllergen;
var selectedAllergenType;
var selectedAllergenReaction;
var selectedAllergenSeverity;
var selectedMedication;


// get value from selected box

$('#medicationSelectBox').change(function (e) {
    ////alert(e.target.value);
    //selectedMedication = e.target.value;
    //$('#medicationSelectBox').value = e.target.value;

    console.log($('#medicationSelectBox').val());
});


// Set value for selected box

$('#medicationSelectBox').val(4);
$('#medicationSelectBox').selectpicker('refresh');
