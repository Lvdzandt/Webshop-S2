$(document).ready(function () {
    $("#myInput").on("keyup", function () {
        var elem = document.getElementById('myDIV');
        var value = $(this).val().toLowerCase();
        $(".GameBox").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
        });
    });
});
