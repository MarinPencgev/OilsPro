$("#products").change(function () {
    var selectedProduct = $("#products").val();
    $.ajax({
        type: "GET",
        url: "/Products/GetLotsByProduct?selectedProduct=" + selectedProduct,
        data: "{}",
        success: function (response) {
            var option = '<option value="-1">Select lot...</option>';
            for (var i = 0; i < response.length; i++) {
                option += '<option value="' + response[i] + '">' + response[i] + '</option>';
            }
            $("#lots").html(option);
        }
    });
});