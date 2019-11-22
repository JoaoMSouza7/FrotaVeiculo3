// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var path_to_delete;
var code_received;
var name_received;

$(".deleteItem").click(function (e) {
    code_received = $(this).attr('code');
    name_received = $(this).attr('data-name');
    path_to_delete = window.location.href + "/Delete/" + code_received;
    $(".data-name").html(name_received);
});

$('#btnContinueDelete').click(function (e) {
    //$(".modalCode").val(code_received);
    
    e.preventDefault();
    $.ajax({
        type: "POST",
        url: path_to_delete,
        data: null
    });
    //window.location = path_to_delete;
});