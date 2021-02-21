using System;
using System.Windows.Forms;

namespace AppAccesible
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            FormSalir2 form = new FormSalir2();
            form.ShowDialog();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
