// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Create driver & vehicle

$("#create").click(function () {
    var carrierName = $("#carrier").val();
    if (carrierName === "Choose >>>") {
        //alert("Choose a carrier name, please !");
        $('#myModal').modal({
            keyboard: false
        });
    } else {
        document.getElementById("myForm").submit();
    }
});


