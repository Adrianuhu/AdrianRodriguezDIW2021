using System;
using System.Windows.Forms;

namespace App1
{
    public partial class FormSalir : Form
    {
        public FormSalir()
        {
            InitializeComponent();

        }

        private void pictureBoxNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxSi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
