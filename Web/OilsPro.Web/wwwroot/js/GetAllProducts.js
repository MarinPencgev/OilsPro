$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Products/AllProducts",
        data: "{}",
        success: function (response) {
            var option = '<option value="-1">Select product...</option>';
            for (var i = 0; i < response.length; i++) {
                option += '<option value="' + response[i].product + '">' + response[i].product + '</option>';
            }
            $("#products").html(option);
        }
    });
});