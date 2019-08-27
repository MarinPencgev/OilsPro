$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Products/AllLots",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Select Lot...</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i] + '">' + data[i] + '</option>';
            }
            $("#lots").html(s);
        }
    });
});