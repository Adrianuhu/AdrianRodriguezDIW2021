var aciertos = 0;
var fallos = 0;
var fallosConsecutivos = 0;
var tiempo = 5000;

function inicio() {

    //  Mostrar menú
    document.getElementsByClassName("start")[0].addEventListener("click", startJuego);
    document.getElementsByClassName("instrucciones")[0].addEventListener("click", mostrarInstrucciones);
}

function startJuego() {
    var ronda = 1;
    aciertos = 0;
    fallos = 0;
    fallosConsecutivos = 0;

    //Borrar dianas del menu de inicio
    var dianas = document.querySelectorAll("my-ball");
    console.log(dianas);
    for (let d of dianas) {
        d.parentNode.removeChild(d);
    }
    //--------------------------------

    let instrucciones = document.getElementsByClassName("textoInstrucciones")[0];
    let display = document.getElementsByClassName("display")[0];
    let menu = document.getElementsByClassName("menu")[0];
    let resultado = document.getElementsByClassName("puntuacionFinal")[0];
    resultado.style.visibility = "hidden";
    instrucciones.style.visibility = "hidden";
    menu.style.visibility = "hidden";
    display.style.visibility = "visible";

    document.getElementById("fondo").addEventListener("click", clickBody);

    crearRonda(1);
}

function crearRonda(numRonda) {
    var ronda = setTimeout(() => {

        if (fallosConsecutivos >= 2) {
            clearInterval(ronda);
            mostrarFinal(numRonda);

        } else {
            fallosConsecutivos = 0;

            for (let i = 0; i < numRonda; i++) {
                crearDiana();
            }
            document.getElementById("ronda").innerHTML = "RONDA " + numRonda
            numRonda++;
            crearRonda(numRonda);
        }

    }, 4500);
}


function crearDiana() {
    var diana = document.createElement("div");
    document.body.appendChild(diana);
    diana.className = "diana";
    diana.style.position = "absolute";
    let topRand = numeroAleatorio(20, 80);
    let leftRand = numeroAleatorio(20, 80);
    diana.style.top = topRand + "%";
    diana.style.left = leftRand + "%";

    diana.addEventListener("click", clickDiana);
    mover(diana);

    setTimeout(() => {
        borrarcaja(diana);
    }, 3000);


    function mover(caja) {
        setTimeout(function() {
            let top = numeroAleatorio(10, 90);
            let left = numeroAleatorio(10, 90);
            caja.style.top = top + "%";
            caja.style.left = left + "%";
        }, 10);

    }

    function borrarcaja(caja) {
        fallosConsecutivos++;
        fallos++;

        try {
            caja.parentNode.removeChild(caja);
        } catch (error) {
            fallosConsecutivos--;
            fallos--;
        }
        actualizarPuntuacion();
    }

}

function clickDiana() {
    aciertos++;
    actualizarPuntuacion();
    this.parentNode.removeChild(this);
}

function clickBody() {
    fallos++;
    fallosConsecutivos++;
    actualizarPuntuacion();
}

function numeroAleatorio(min, max) {
    return Math.round(Math.random() * (max - min) + min);
}

function mostrarInstrucciones() {
    let instrucciones = document.getElementsByClassName("textoInstrucciones")[0];
    let menu = document.getElementsByClassName("menu")[0];

    let elementStyle = window.getComputedStyle(instrucciones);
    let elementVis = elementStyle.getPropertyValue('visibility');

    if (elementVis == "hidden") {
        instrucciones.style.visibility = "visible";
        menu.style.top = "80%";
    } else {
        instrucciones.style.visibility = "hidden";
        menu.style.top = "50%";
    }

}

function mostrarFinal(ronda) {
    var display = document.getElementsByClassName("display")[0];
    display.style.visibility = "hidden";
    var menu = document.getElementsByClassName("menu")[0];
    menu.style.visibility = "visible";
    var resultado = document.getElementsByClassName("puntuacionFinal")[0];
    resultado.style.visibility = "visible";
    resultado.innerHTML = "Tu puntuación ha sido: " + "<br/> RONDA: " + (ronda - 1) + " <br/> PTS: " + (aciertos * 100 - fallos * 200);
}

function actualizarPuntuacion() {
    document.getElementsByClassName("numPuntos")[0].innerHTML = (aciertos * 100 - fallos * 200);
    document.getElementsByClassName("numPorcentaje")[0].innerHTML = ((aciertos / (aciertos + fallos)) * 100).toFixed();
}


window.onload = inicio;