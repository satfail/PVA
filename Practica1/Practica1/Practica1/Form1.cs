using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFichaPersonal_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || cbCiudad.Text == ""
                || pbFoto.Image == null)
            {
                MessageBox.Show("Tiene que rellenar el formulario");

            }
            else
            {
                MessageBox.Show("Se ha rellenado el formulario correctamente");

            }
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = null;
            txtDireccion.Text = null;
            cbCiudad.Text = null;
            pbFoto.Image = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {   // Si pulsamos en insertar!
            if(opfFoto.ShowDialog() == DialogResult.OK)
            {
                //Almacena la foto recibida por archivo
                pbFoto.Image = Image.FromFile(opfFoto.FileName);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cbCiudad.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValidar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
