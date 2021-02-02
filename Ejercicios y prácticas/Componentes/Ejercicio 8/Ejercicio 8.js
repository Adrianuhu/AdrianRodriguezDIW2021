class Progress extends HTMLElement {
    constructor() {
        super();

        this.intervalo = "";

        // Creamos shadow DOM que a partir de ahora se puede acceder a través de 
        this.attachShadow({ mode: 'open' });

    }

    connectedCallback() {

        // Se representa el HTML de la propiedad template en el shadow DOM
        this.render(this.getAttribute('status'));


        this.shadowRoot.getElementById("iniciar").addEventListener("click", () => {
            var width = 0;
            var maxWidth = 100;
            var tiempo = 1000;
            var inputTiempo = this.shadowRoot.getElementById("tiempo").value;

            if (inputTiempo != "") {
                tiempo = inputTiempo * 1000;
            }

            var barra = this.shadowRoot.querySelector(".barra");

            this.intervalo = setInterval(() => {

                width += maxWidth * (10 / tiempo);
                barra.style.width = Math.max(width, 0);
                if (width >= maxWidth) clearInterval(this.intervalo);
                barra.style.width = width + "%";
                barra.innerHTML = Math.trunc(width) + "%";

            }, 10);
        })

        this.shadowRoot.getElementById("parar").addEventListener("click", () => {
            clearInterval(this.intervalo);
        })

        this.shadowRoot.getElementById("cambio").addEventListener("click", () => {
            this.setAttribute('status', 5);
        })

    }

    // Se llama cuando se modifica el valor de los atributos especificados en observedAttributes
    attributeChangedCallback(attr, oldVal, newVal) {
        if (attr == 'status' && oldVal != newVal) {
            this.render(newVal);
            this.connectedCallback();
        }
    }

    // Atributos reactivos cuando se invoca attributeChangedCallback
    static get observedAttributes() {
        return ['status'];
    }


    // Código HTML
    render(currentStatus) {
        this.shadowRoot.innerHTML = `
            <style>
            .progreso {
                width: 300px;
                background-color: lightgray;
                padding: 0px 0px;
                border: 1px solid black;
                text-align: center;
            }
            
            .barra {
                width: 0%;
                color: white;
                background-color: green;
                padding: 5px 0px;
                text-align: left;
            }
        </style>
        
        <button id="iniciar">Iniciar</button>
        <button id="parar">Parar</button>
        <div class="progreso">
            <div class="barra">&nbsp</div>
        </div>
    
        <input type="text" id="tiempo" placeholder="segundos" value="${currentStatus}">
        <button id="cambio">5 seg</button>
        `;
    }
}

window.customElements.define('my-progress', Progress);