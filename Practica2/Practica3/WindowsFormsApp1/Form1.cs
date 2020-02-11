using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbRama_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {


            if (rbRama.Checked)
                tvwArbol.Nodes.Add(txtInsertar.Text);
            else
            {
                if (tvwArbol.Nodes.Count == 0)
                    MessageBox.Show("Inserte una rama");
                TreeNode objNode;
                objNode = tvwArbol.SelectedNode;
                if (objNode != null)
                    objNode.Nodes.Add(txtInsertar.Text);

                else
                    MessageBox.Show("Seleccione un Rama");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tvwArbol.Nodes.Remove(tvwArbol.SelectedNode);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            tvwArbol.Nodes.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarLista_Click(object sender, EventArgs e)
        {
            ListViewItem milista;
            milista = lvwLista.Items.Add(txtDni.Text);
            milista.SubItems.Add(txtNombre.Text);
            milista.SubItems.Add(txtTelefono.Text);
        }

        private void lvwLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrarLista_Click(object sender, EventArgs e)
        {
            int count = lvwLista.SelectedItems.Count;
            if (count != 0)
            {
                for (int i = 0; i < lvwLista.Items.Count; i++)
                {
                    if (lvwLista.Items[i].Selected)
                    {
                        lvwLista.Items[i].Remove();
                        i--;
                    }
                }
            }
        }

        private void btnBorrarTodoLista_Click(object sender, EventArgs e)
        {
            lvwLista.Items.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
