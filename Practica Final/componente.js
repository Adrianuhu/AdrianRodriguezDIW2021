class Progress extends HTMLElement {
    constructor() {
        super();
        this.attachShadow({ mode: 'open' });
    }

    connectedCallback() {
        // Se representa el HTML de la propiedad template en el shadow DOM
        this.render();

        var diana = this.shadowRoot.querySelector(".diana");
        diana.style.position = "absolute";

        let topRand = numeroAleatorio(20, 80);
        let leftRand = numeroAleatorio(20, 80);
        diana.style.top = topRand + "%";
        diana.style.left = leftRand + "%";
        diana.addEventListener("click", clickDiana);

        window.requestAnimationFrame(step);

        var start = "";
        var top = numeroAleatorio(-30, 30);
        var left = numeroAleatorio(-30, 30);
        var actualTOP = parseInt(diana.style.top.split("%")[0]);
        var actualLEFT = parseInt(diana.style.left.split("%")[0]);

        function step(timestamp) {
            if (!start) start = timestamp;
            var progress = timestamp - start;
            diana.style.top = actualTOP + (top * progress / 8000) + "%";
            diana.style.left = actualLEFT + (left * progress / 8000) + "%";

            if (progress < 8000) {
                window.requestAnimationFrame(step);
            }
        }

        function clickDiana() {
            this.parentNode.removeChild(this);
        }
    }

    // Código HTML
    render() {
        this.shadowRoot.innerHTML = `
        <style>
        .diana {
            position: absolute;
            width: 80px;
            height: 80px;
            background-color: #666;
            border-radius: 30%;
            cursor: pointer;
        }
        </style>
        <div class="diana"></div>
        `;
    }
}

function numeroAleatorio(min, max) {
    return Math.round(Math.random() * (max - min) + min);
}
window.customElements.define('my-ball', Progress);