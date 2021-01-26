class TestElement extends HTMLElement {
    constructor() {
        super();
    }

    connectedCallback() {

        var colorPrincipal

        if (this.getAttribute('baseColor') == null) {
            colorPrincipal = 'inherit';
        } else {
            colorPrincipal = this.getAttribute('baseColor');
        }
        this.style.color == colorPrincipal;

        var colorSecundario;

        if (this.getAttribute('alternativeColor') == null) {
            colorSecundario = 'inherit';
        } else {
            colorSecundario = this.getAttribute('alternativeColor');
        }

        var interval;

        if (this.getAttribute('changeInterval') == null) {
            interval = 1000;
        } else {
            interval = this.getAttribute('changeInterval') * 1000;
        }

        setInterval(() => {
            if (this.style.color == colorPrincipal) {
                this.style.color = colorSecundario;
            } else {
                this.style.color = colorPrincipal;
            }
        }, interval);

    }

}

customElements.define('test-element', TestElement);