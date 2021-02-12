const template = document.createElement('template');
template.innerHTML =
    `
    <style>
    div {
        width: 100px;
        height: 100px;
        margin-bottom: 3px;
        border: 1px solid black;
        cursor: pointer;
    }

    .red {
        background-color: red;
    }

    .grey {
        background-color: grey;
    }

    .yellow {
        background-color: yellow;
    }

    .green {
        background-color: green;
    }
    </style>

        <div id="caja1" class="red"></div>
        <div id="caja2" class="grey"></div>
        <div id="caja3" class="grey"></div>
    `;
customElements.define('my-semaforo', class extends HTMLElement {
    constructor() {
        super();
        this._shadowRoot = this.attachShadow({ mode: 'open' });
        this._shadowRoot.appendChild(template.content.cloneNode(true));

        this.interval = "";
    }

    connectedCallback() {

        var caja1 = this._shadowRoot.getElementById("caja1");
        var caja2 = this._shadowRoot.getElementById("caja2");
        var caja3 = this._shadowRoot.getElementById("caja3");

        // Caja 1--------------------------------
        caja1.addEventListener("click", () => {
            caja1.className = "red";
            caja2.className = "grey";
            caja3.className = "grey";
            clearInterval(this.interval);
        })

        // Caja 2--------------------------------
        caja2.addEventListener("click", () => {
            caja1.className = "grey";
            caja3.className = "grey";
            var tiempo;
            if (this.seconds) {
                tiempo = this.seconds;
            } else {
                tiempo = 1;
            }

            var cambio = 0;

            this.interval = setInterval(() => {

                if (cambio % 2) {
                    caja2.className = "yellow";
                } else {
                    caja2.className = "grey";
                }
                cambio++;

            }, (tiempo * 1000 / 2));
        })

        // Caja 3--------------------------------
        caja3.addEventListener("click", () => {
            caja1.className = "grey";
            caja2.className = "grey";
            caja3.className = "green";
            clearInterval(this.interval);
        })
    }

    attributeChangedCallback(attr, oldVal, newVal) {
        if (attr == 'seconds' && oldVal != newVal) {

            this._shadowRoot.getElementById("caja1").className = "red";
            this._shadowRoot.getElementById("caja2").className = "grey";
            this._shadowRoot.getElementById("caja3").className = "grey";
            clearInterval(this.interval);
        }
    }

    static get observedAttributes() {
        return ['seconds'];
    }

    get seconds() {
        return this.getAttribute('seconds');
    }

});