function validarNombre(nombre) {
    var exprReg = /^[a-zA-ZÀ-ÿ\u00f1\u00d1]+$/; //permite el ingreso de letras minúsculas, mayúsculas, vocales con acentos y la "n"/"Ñ".
    if (!(exprReg.test(nombre))) {
        window.alert("Campo Nombre incorrecto. Solo se permiten letras.");
        return false;
    } else {
        return true;
    }
}

function validarApellido(apellido) {
    var exprReg = /^[a-zA-ZÀ-ÿ\u00f1\u00d1]+$/;
    if (!(exprReg.test(apellido))) {
        window.alert("Campo Apellido incorrecto. Solo se permiten letras.");
        return false;
    } else {
        return true;
    }
}

function validarMail(mail) {
    var mailValido = /^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$/;
    if (!(mailValido.test(mail))) {
        window.alert("Campo Email incorrecto. Ingrese un Email válido.");
        return false;
    } else {
        return true;
    }
}

function validarOpcion(opciones) {
    if (opciones === 0) {
        window.alert("Campo Turno incompleto. Seleccione una opción.");
        return false;
    } else {
        return true;
    }

}

function validarDni(dni) {
    if (dni === "") {
        window.alert("Campo DNI vacío. Ingrese un DNI.");
        return false;
    } else {
        return true;
    }
}


function Validacion() {
    var nombre = document.getElementById("txtNombre").value;
    var apellido = document.getElementById("txtApellido").value;
    var dni = document.getElementById("txtDni").value;
    var mail = document.getElementById("txtMail").value;
    var opciones = document.getElementById("opciones").selectedIndex;

    return validarApellido(apellido) && validarNombre(nombre) && validarDni(dni) && validarMail(mail) && validarOpcion(opciones); 

}





function validarComentario() {
    var comentario = document.getElementById("txtComentario").value;
    if (comentario === "") {
        window.alert("Campo incompleto. Ingrese un comentario.");
        return false;
    }
}



