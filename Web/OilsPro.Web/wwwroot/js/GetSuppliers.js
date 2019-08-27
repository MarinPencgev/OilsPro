$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Suppliers/All",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Select supplier...</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i] + '">' + data[i] + '</option>';
            }
            $("#suppliers").html(s);
        }
    });
});