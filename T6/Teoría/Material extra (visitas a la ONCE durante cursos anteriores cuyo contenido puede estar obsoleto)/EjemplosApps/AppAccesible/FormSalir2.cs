using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAccesible
{
    public partial class FormSalir2 : Form
    {
        public FormSalir2()
        {
            InitializeComponent();
        }

        private void btSi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
