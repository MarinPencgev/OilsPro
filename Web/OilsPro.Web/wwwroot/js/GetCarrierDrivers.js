$("#carrier").change(function () {
    var carrierName = $("#carrier").val();
    $.ajax({
        type: "GET",
        url: "/Carriers/GetCarrierDrivers?carrierName=" + carrierName,
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Select driver...</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i] + '">' + data[i] + '</option>';
            }
            $("#drivers").html(s);
        }
    });
});