$(function (){
    $("#btnSubmit").click(function () {
        var message = $("#txtMessage").val();
        if (message == '') {
            alert("Message is Mandatory");
        }
        else {
            alert("Message sent successfully");
        }
    });
});