// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

jQuery(document).ready(function () {

    var options = {
        format: 'dd.mm.yyyy',
        todayHighlight: true,
        autoclose: true,
    };
    jQuery("#ScreeningDate").datepicker(options);

    $.date = function (dateObject) {
        var d = new Date(dateObject);
        var day = d.getDate();
        var month = d.getMonth() + 1;
        var year = d.getFullYear();
        if (day < 10) {
            day = "0" + day;
        }
        if (month < 10) {
            month = "0" + month;
        }
        var date = day + "/" + month + "/" + year;

        return date;
    };

    //jQuery("#MovieDatePicker .btn").click(function () {
    //    var selectedDate = new Date(jQuery("#ScreeningDate").val());

    //    //jQuery("#date").val(jQuery.date(selectedDate));
    //    //console.log(jQuery.date(selectedDate));
    //    jQuery("form").submit();
    //})
});