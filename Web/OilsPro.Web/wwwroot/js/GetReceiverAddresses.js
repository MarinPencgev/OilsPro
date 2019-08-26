$("#receiver").change(function () {
    var receiverName = $("#receiver").val();
    $.ajax({
        type: "GET",
        url: "/Receivers/GetReceiverAddresses?receiverName=" + receiverName,
        data: "{}",
        success: function (response) {
            var option = '<option value="-1">Select address...</option>';
            for (var i = 0; i < response.length; i++) {
                option += '<option value="' + response[i] + '">' + response[i] + '</option>';
            }
            $("#addresses").html(option);
        }
    });
});