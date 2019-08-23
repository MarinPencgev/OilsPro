// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    $("#create").click(function () {
        var receiverName = $("#receiver").val();
        if (receiverName === "Choose >>>") {
            //alert("Choose a receiver name, please !");
            $('#myModal').modal({
                keyboard: false
            });
        } else {
            document.getElementById("myForm").submit();
        }
    });
