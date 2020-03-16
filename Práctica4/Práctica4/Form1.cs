using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Práctica4
{

    public partial class Form1 : Form
    {
        //Static para contador de  la clase
        private static int contador = 0;
        private static String ruta = "../../logs/logs.txt";


        public Form1()
        {   
            InitializeComponent();
           
        }

        private void escrituraLog(String texto)
        {
            StreamWriter fichero = new StreamWriter(ruta, true);
            String textoLog = DateTime.Now + " " + texto;
            fichero.WriteLine(textoLog);
            fichero.Close();
            fichero.Dispose();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newHijo();
            escrituraLog("Se añade documento nuevo");

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            newHijo();
            escrituraLog("Se añade documento nuevo");
        }

        private void newHijo()
        {
            fhijo objetohijo = new fhijo();
            objetohijo.MdiParent = this;
            contador++;
            objetohijo.Text = "Nuevo Documento " + contador;
            objetohijo.Show();
            botonesTrue();


        }

        private void closeHijo()
        {
            //Coge el hijo activo, hay que hacer casting puede haber otra cosa activa

            fhijo objetohijo = (fhijo)this.ActiveMdiChild;
            if (objetohijo != null)
            {
                objetohijo.Close();
            }
            botonesTrue();

        }

        private void tsmiCerrar_Click(object sender, EventArgs e)
        {
            closeHijo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

                closeHijo();
        }


        private void tsmiCascada_Click_1(object sender, EventArgs e)
        {

            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void tsmiHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void tsmiVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void tsmiMinimizar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].WindowState = FormWindowState.Minimized;
            }
        }

        private void tsmiMaximizar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].WindowState = FormWindowState.Maximized;
            }

        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void tsmiAbrir_Click(object sender, EventArgs e)
        {
            abrirArchivo();
        }

        private void abrirArchivo()
        {
            //Solución del problema de la extensión, la cojo del docuemnto
            // ya abro de dos formas distintas.S
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(ofdAbrir.FileName);

                fhijo objetohijo = new fhijo();
                objetohijo.MdiParent = this;
                //Con rich
                if (ext.Equals(".rtf")) { 
                    objetohijo.rtb1.LoadFile(ofdAbrir.FileName);
                    
                }
                else
                {
                    
                    StreamReader textoarchivo = File.OpenText(ofdAbrir.FileName);
                    objetohijo.rtb1.Text = textoarchivo.ReadToEnd();
                    objetohijo.Text = System.IO.Path.GetFileName(ofdAbrir.FileName);
                    textoarchivo.Close();
                    
                }
                objetohijo.Show();
                String texto = "Se abre archivo : " + ofdAbrir.FileName;
                escrituraLog(texto);
            }
            ofdAbrir.Dispose();
            
            botonesTrue();
        }

        private void botonesTrue()
        {
            if (this.MdiChildren.Length > 0)
            {
                tsmiGuardar.Enabled = true;
                tsbCerrar.Enabled = true;
                tsmiCerrar.Enabled = true;
                tsmiVentana.Enabled = true;
                tsmiFormato.Enabled = true;
                //2. Inhabilitamos ciertos iconos.
                tsmiCerrar.Enabled = true;
            }
            else
            {
                tsmiGuardar.Enabled = false;
                tsbCerrar.Enabled = false;
                tsmiCerrar.Enabled = false;
                tsmiVentana.Enabled = false;
                tsmiFormato.Enabled = false;
                //2. Inhabilitamos ciertos iconos.
                tsmiCerrar.Enabled = false;
            }
        }

        private void ofdAbrir_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tsbAbrir_Click(object sender, EventArgs e)
        {
            abrirArchivo();
            botonesTrue();
        }

        private void tsmiGuardar_Click(object sender, EventArgs e)
        {

            guardar();
            
        }

        private void guardar()
        {
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {

                string ext = Path.GetExtension(ofdAbrir.FileName);

                fhijo objetohijo = new fhijo();
                objetohijo.MdiParent = this;
                //Con rich
                if (ext.Equals(".rtf"))
                {
                    objetohijo.rtb1.SaveFile(sfdGuardar.FileName);

                }
                else {

                    //Para text
                    StreamWriter documento = File.CreateText(sfdGuardar.FileName);
                    documento.WriteLine(objetohijo.rtb1.Text);
                    documento.Close();
                }

                objetohijo.rtb1.SaveFile(sfdGuardar.FileName);
                String texto = "Se guarda archivo con nombre : " + sfdGuardar.FileName;
                escrituraLog(texto);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void tsmiFuente_Click(object sender, EventArgs e)
        {
            // 1. Diálogo creado en herramientas
            //2. Especificamos el tipo de fuente a elegir. (=fontDialog.OK)
            fhijo objetoHijo = (fhijo)this.ActiveMdiChild;
            fontdg.ShowDialog();
            objetoHijo.rtb1.SelectionFont = fontdg.Font;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void tsmiColor_Click(object sender, EventArgs e)
        {

            //1. Creado con herramientas
            //2. Le asignamos el nuevo color a lo seleccionado en el RichTextBox.
            fhijo objetoHijo = (fhijo)this.ActiveMdiChild;
            colordg.ShowDialog();
            objetoHijo.rtb1.SelectionColor = colordg.Color;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            botonesTrue();
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            fhijo objetoHijo = (fhijo)this.ActiveMdiChild;
            objetoHijo.rtb1.Undo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fhijo objetoHijo = (fhijo)this.ActiveMdiChild;
            objetoHijo.rtb1.Redo();
        }
    }
}
