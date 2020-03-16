using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5_POO
{
    public partial class Form1 : Form
    {
        Persona persona1 = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            persona1.pNombre = txtNombre.Text;
            persona1.pApellido = txtApellido.Text;
            persona1.pEdad = Int32.Parse(txtEdad.Text);
            persona1.pDni = txtDni.Text;

            MessageBox.Show(persona1.ToString());        }
    }
}
