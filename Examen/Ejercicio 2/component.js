const template = document.createElement('template');
template.innerHTML =
    `
    <style>
    div {
        width: 100px;
        height: 100px;
        margin-bottom: 3px;
        border: 1px solid black;
    }

    .rojo {
        background-color: red;
    }

    .grey {
        background-color: grey;
    }
    </style>

        <div class="rojo"></div>
        <div class="grey"></div>
        <div class="grey"></div>
    `;
customElements.define('my-semaforo', class extends HTMLElement {
    constructor() {
        super();
        this._shadowRoot = this.attachShadow({ mode: 'open' });
        this._shadowRoot.appendChild(template.content.cloneNode(true));

        console.log(this.seconds);

    }

    get seconds() { return this.getAttribute('seconds'); }

});