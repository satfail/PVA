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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chckIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chckIdiomas.Items.Add(txtAddchk.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = chckIdiomas.Items.Count;

            for (int index = count; index > 0; index--)
                chckIdiomas.Items.RemoveAt(index - 1);

        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" ||txtDireccion.Text == "" 
                || cbCiudad.Text == "" || chckIdiomas.SelectedItem == null)
            {
                MessageBox.Show("Formulario Incompleto");
            }
            else
            {
                MessageBox.Show("Formulario Completo");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            cbCiudad.Text = "";
            for (int i =0; i< chckIdiomas.Items.Count; ++i)
                chckIdiomas.SetItemChecked(i, false);


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                //Cargar la imagen. Picfoto es el PictureBox.
                picFoto.Image = Image.FromFile(ofdFoto.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int count = chckIdiomas.Items.Count;

            for (int index = count; index > 0; index--)

            {
                if (chckIdiomas.CheckedItems.Contains(chckIdiomas.Items[index - 1]))
                {
                    chckIdiomas.Items.RemoveAt(index - 1);
                }

            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmsobre frmsobreautor = new frmsobre();
            //showDialog solo 1, show N
            frmsobreautor.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            regform registroform = new regform();
            //showDialog solo 1, show N
            registroform.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir?", "Salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
