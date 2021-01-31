const templateMyParagraph = document.createElement('template');

templateMyParagraph.innerHTML = `
<style>
summary>span:first-child {
    color: darkcyan;
}

dl {
    margin-left: 20px;
}

dt:first-child {
    color: white;
    background-color: darkcyan;
    display: inline-block;
    padding: 5px;
    border-radius: 5px;
    font-weight: bold;
}
</style>

  
  <details>
        <summary>
          <span>&lt<slot name="my-nombre">
            NECESITA NOMBRE
          </slot>&gt</span>
            
          <span><slot name="my-descripcion">
              NECESITA DESCRIPCIÓN
          </slot></span>
        </summary>
        <dl>
            <dt>Atributos</dt>
            <dt><slot name="my-name">Ninguno</slot></dt>
            <dd><slot name="my-atributo"></slot></dd>
        </dl>
    </details>
`;

// En este caso creamos el Custom Element con una clase anónima
customElements.define('my-details',
    class extends HTMLElement {
        constructor() {
            super();

            this._shadowRoot = this.attachShadow({ mode: 'open' });
            this._shadowRoot.appendChild(templateMyParagraph.content.cloneNode(true));
        }
    }
)