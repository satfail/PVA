using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class regform : Form
    {
        public regform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLicencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void rbAcepto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAcepto.Checked)
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
