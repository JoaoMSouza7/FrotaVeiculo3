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
/*----------------------------------------------------------------------------------*/
function mascara(i){
   
    var v = i.value;
    
    if(isNaN(v[v.length-1])){ // impede entrar outro caractere que não seja número
       i.value = v.substring(0, v.length-1);
       return;
    }
    
    i.setAttribute("maxlength", "14");
    if (v.length == 3 || v.length == 7) i.value += ".";
    if (v.length == 11) i.value += "-";
 
 }

 function BlockKeybord()
 {
     if(window.event) // IE
     {
         if((event.keyCode < 48) || (event.keyCode > 57))
         {
             event.returnValue = false;
         }
     }
     else if(e.which) // Netscape/Firefox/Opera
     {
         if((event.which < 48) || (event.which > 57))
         {
             event.returnValue = false;
         }
     }


 }

 function troca(str,strsai,strentra)
 {
     while(str.indexOf(strsai)>-1)
     {
         str = str.replace(strsai,strentra);
     }
     return str;
 }

 function FormataMoeda(campo,tammax,teclapres,caracter)
 {
     if(teclapres == null || teclapres == "undefined")
     {
         var tecla = -1;
     }
     else
     {
         var tecla = teclapres.keyCode;
     }

     if(caracter == null || caracter == "undefined")
     {
         caracter = ".";
     }

     vr = campo.value;
     if(caracter != "")
     {
         vr = troca(vr,caracter,"");
     }
     vr = troca(vr,"/","");
     vr = troca(vr,",","");
     vr = troca(vr,".","");

     tam = vr.length;
     if(tecla > 0)
     {
         if(tam < tammax && tecla != 8)
         {
             tam = vr.length + 1;
         }

         if(tecla == 8)
         {
             tam = tam - 1;
         }
     }
     if(tecla == -1 || tecla == 8 || tecla >= 48 && tecla <= 57 || tecla >= 96 && tecla <= 105)
     {
         if(tam <= 2)
         {
             campo.value = vr;
         }
         if((tam > 2) && (tam <= 5))
         {
             campo.value = vr.substr(0, tam - 2) + ',' + vr.substr(tam - 2, tam);
         }
         if((tam >= 6) && (tam <= 8))
         {
             campo.value = vr.substr(0, tam - 5) + caracter + vr.substr(tam - 5, 3) + ',' + vr.substr(tam - 2, tam);
         }
         if((tam >= 9) && (tam <= 11))
         {
             campo.value = vr.substr(0, tam - 8) + caracter + vr.substr(tam - 8, 3) + caracter + vr.substr(tam - 5, 3) + ',' + vr.substr(tam - 2, tam);
         }
         if((tam >= 12) && (tam <= 14))
         {
             campo.value = vr.substr(0, tam - 11) + caracter + vr.substr(tam - 11, 3) + caracter + vr.substr(tam - 8, 3) + caracter + vr.substr(tam - 5, 3) + ',' + vr.substr(tam - 2, tam);
         }
         if((tam >= 15) && (tam <= 17))
         {
             campo.value = vr.substr(0, tam - 14) + caracter + vr.substr(tam - 14, 3) + caracter + vr.substr(tam - 11, 3) + caracter + vr.substr(tam - 8, 3) + caracter + vr.substr(tam - 5, 3) + ',' + vr.substr(tam - 2, tam);
         }
     }
 }

 function maskKeyPress(objEvent)
 {
     var iKeyCode;

     if(window.event) // IE
     {
         iKeyCode = objEvent.keyCode;
         if(iKeyCode>=48 && iKeyCode<=57) return true;
         return false;
     }
     else if(e.which) // Netscape/Firefox/Opera
     {
         iKeyCode = objEvent.which;
         if(iKeyCode>=48 && iKeyCode<=57) return true;
         return false;
     }


 }

 function continuar(){
    var inputs = document.getElementsByClassName("verification");
  
    if (validationInput(inputs) == true){
      console.log("continuar");
    }else{
      console.log("Não continuar");
    }
  
  }
  
  function validationInput(inputs){
    var resutado = true;
    for(var i = 0; i < inputs.length; i++){
        if (inputs[i].hasAttribute('required') ){
          if (inputs[i].value == ""){
  
            inputs[i].style.background = "Red";
            inputs[i].placeholder = "Esse Campo é obrigatório !"
            resutado = false;
          }
        }
      }
    return resutado;
  }
