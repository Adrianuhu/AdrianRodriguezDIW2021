function inicio() {

    document.getElementById("left").addEventListener("click", izquierda);
    document.getElementById("right").addEventListener("click", derecha);
    document.getElementById("top").addEventListener("click", arriba);
    document.getElementById("bottom").addEventListener("click", abajo);

    setInterval(() => {
        checkDentro();
    }, 100);


}

function izquierda() {
    var cantidad = document.getElementById("mov").value;
    var bloque = document.getElementsByClassName("block")[0];
    var cantidadActual = window.getComputedStyle(bloque).getPropertyValue("left").split('px')[0];
    bloque.style.left = (parseInt(cantidadActual) - parseInt(cantidad)) + "px";
}

function derecha() {
    var cantidad = document.getElementById("mov").value;
    var bloque = document.getElementsByClassName("block")[0];
    var cantidadActual = window.getComputedStyle(bloque).getPropertyValue("left").split('px')[0];
    bloque.style.left = (parseInt(cantidadActual) + parseInt(cantidad)) + "px";
}

function arriba() {
    var cantidad = document.getElementById("mov").value;
    var bloque = document.getElementsByClassName("block")[0];
    var cantidadActual = window.getComputedStyle(bloque).getPropertyValue("top").split('px')[0];
    bloque.style.top = (parseInt(cantidadActual) - parseInt(cantidad)) + "px";
}

function abajo() {
    var cantidad = document.getElementById("mov").value;
    var bloque = document.getElementsByClassName("block")[0];
    var cantidadActual = window.getComputedStyle(bloque).getPropertyValue("top").split('px')[0];
    bloque.style.top = (parseInt(cantidadActual) + parseInt(cantidad)) + "px";
}

function checkDentro() {

    var cuadrado = $(".cuadrado").last();
    var offsetCuadrado = cuadrado.offset();
    var cuadradoLeft = offsetCuadrado.left;
    var cuadradoTop = offsetCuadrado.top;
    var objCuadrado = document.getElementsByClassName("cuadrado")[0];
    var anchoCuadrado = window.getComputedStyle(objCuadrado).width.split("px")[0];
    var altoCuadrado = window.getComputedStyle(objCuadrado).height.split("px")[0];

    var bloque = $(".block").last();
    var offsetBloque = bloque.offset();
    var bloqueLeft = offsetBloque.left;
    var bloqueTop = offsetBloque.top;
    var objBlock = document.getElementsByClassName("block")[0];
    var anchoBloque = window.getComputedStyle(objBlock).width.split("px")[0];
    var altoBloque = window.getComputedStyle(objBlock).height.split("px")[0];

    var block = document.getElementsByClassName("block")[0];

    var sumaBloqueAncho = parseInt(bloqueLeft) + parseInt(anchoBloque);
    var sumaCuadradoAncho = parseInt(cuadradoLeft) + parseInt(anchoCuadrado);

    var sumaBloqueAlto = parseInt(bloqueTop) + parseInt(altoBloque);
    var sumaCuadradoAlto = parseInt(cuadradoTop) + parseInt(altoCuadrado);

    if ((bloqueLeft > cuadradoLeft) && (bloqueTop > cuadradoTop) && (sumaBloqueAncho < sumaCuadradoAncho) && (sumaCuadradoAlto > sumaBloqueAlto)) {
        block.style.backgroundColor = "yellow";
    } else {
        block.style.backgroundColor = "greenyellow";
    }

}

function allowDrop(ev) {
    ev.preventDefault();
}

function drag(ev) {
    ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    var caja = document.getElementById(data);
    var nuevaCaja = ev.target.appendChild(caja);
    nuevaCaja.style.top = ev.clientY + "px";
    nuevaCaja.style.left = ev.clientX + "px";
}

window.onload = inicio;