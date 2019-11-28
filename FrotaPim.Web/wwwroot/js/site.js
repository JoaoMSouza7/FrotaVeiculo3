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
    e.preventDefault(); 
    $.ajax({
        type: "DELETE",
        url: path_to_delete,
        data: null,
        success: function () {
            location.reload();
        }
    });
});

$(".input-year").datepicker({ dateFormat: 'yy' });

function moeda(a, e, r, t) {
    let n = ""
        , h = j = 0
        , u = tamanho2 = 0
        , l = ajd2 = ""
        , o = window.Event ? t.which : t.keyCode;
    a.value = a.value.replace('R$ ', '');
    if (n = String.fromCharCode(o),
        -1 == "0123456789".indexOf(n))
        return !1;
    for (u = a.value.replace('R$ ', '').length,
        h = 0; h < u && ("0" == a.value.charAt(h) || a.value.charAt(h) == r); h++)
        ;
    for (l = ""; h < u; h++)
        -1 != "0123456789".indexOf(a.value.charAt(h)) && (l += a.value.charAt(h));
    if (l += n,
        0 == (u = l.length) && (a.value = ""),
        1 == u && (a.value = "R$ 0" + r + "0" + l),
        2 == u && (a.value = "R$ 0" + r + l),
        u > 2) {
        for (ajd2 = "",
            j = 0,
            h = u - 3; h >= 0; h--)
            3 == j && (ajd2 += e,
                j = 0),
                ajd2 += l.charAt(h),
                j++;
        for (a.value = "R$ ",
            tamanho2 = ajd2.length,
            h = tamanho2 - 1; h >= 0; h--)
            a.value += ajd2.charAt(h);
        a.value += r + l.substr(u - 2, u)
    }
    return !1
}