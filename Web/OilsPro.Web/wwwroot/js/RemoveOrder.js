$("#remove").click(function () {

    $('#myModal').modal({
        keyboard: true 
    });

    data = {};
    $("#save").on("click", function (e) {
        e.preventDefault(); // prevent de default action, which is to submit
        // save your value where you want
        data.select = $("#exampleSelect").value();
        // or call the save function here
        save();
        $(this).prev().click();

    });

});