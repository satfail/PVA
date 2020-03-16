using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Practica6_xml
{
    public partial class Form1 : Form
    {

        private XmlDocument midocxml = new XmlDocument();
        private XmlNodeList nNombre, nApellido1, nApellido2, nTelefono, nEmail1, nEmail2;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            midocxml.Save(@"../../data/personas.xml");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String seleccionado = lbXml.SelectedItem.ToString().Trim();
            lbXml.Items.Clear();
            XmlNodeList personas = midocxml.GetElementsByTagName("personas");
            XmlNodeList lista = ((XmlElement)personas[0]).GetElementsByTagName("persona");

            foreach (XmlElement nodo in lista)
            {
                nNombre = nodo.GetElementsByTagName("nombre");
                nApellido1 = nodo.GetElementsByTagName("apellido1");
                nApellido2 = nodo.GetElementsByTagName("apellido2");
                nTelefono = nodo.GetElementsByTagName("telefono");
                nEmail1 = nodo.GetElementsByTagName("email");


                if (seleccionado.Equals(nNombre[0].InnerText))
                {
                    nNombre[0].InnerText = txtModificar.Text;
                }


                else if (seleccionado.Equals(nApellido1[0].InnerText))
                {

                    nApellido1[0].InnerText = txtModificar.Text;

                }

                else if (seleccionado.Equals(nApellido2[0].InnerText))
                {
                    nApellido2[0].InnerText = txtModificar.Text;

                }

                else if (seleccionado.Equals(nTelefono[0].InnerText))
                {
                    nTelefono[0].InnerText = txtModificar.Text;
                }

                for (int i = 0; i < nEmail1.Count; ++i)
                {
                     if(seleccionado.Equals(nEmail1[i].InnerText))
                        nEmail1[i].InnerText = txtModificar.Text;
                }

                lbXml.Items.Add(nNombre[0].InnerText);
                lbXml.Items.Add("\t" + nApellido1[0].InnerText);
                lbXml.Items.Add("\t" + nApellido2[0].InnerText);
                lbXml.Items.Add("\t" + nTelefono[0].InnerText);
                for (int i = 0; i < nEmail1.Count; ++i)
                      lbXml.Items.Add("\t" + nEmail1[i].InnerText);
                



            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbXml.Items.Clear();
            if (ofdXml.ShowDialog() == DialogResult.OK)
            {
                //try
               // {
                    
                    midocxml.Load(ofdXml.FileName);
                 
                    XmlNodeList personas = midocxml.GetElementsByTagName("personas");
                    XmlNodeList lista = ((XmlElement)personas[0]).GetElementsByTagName("persona");
                   
                    foreach (XmlElement nodo in lista)
                    {
                        nNombre = nodo.GetElementsByTagName("nombre");
                        nApellido1 = nodo.GetElementsByTagName("apellido1");
                        nApellido2 = nodo.GetElementsByTagName("apellido2");
                        nTelefono = nodo.GetElementsByTagName("telefono");
                        nEmail1 = nodo.GetElementsByTagName("email");
                        lbXml.Items.Add(nNombre[0].InnerText);
                        lbXml.Items.Add("\t" + nApellido1[0].InnerText);
                        lbXml.Items.Add("\t" + nApellido2[0].InnerText);
                        lbXml.Items.Add("\t" + nTelefono[0].InnerText);
                        for(int i = 0; i< nEmail1.Count; ++i)
                            lbXml.Items.Add("\t" + nEmail1[i].InnerText);
                     }
                

           



                // }
                //catch
                //{
                //    MessageBox.Show("Error al abrir el fichero");
                //}

            }
            
        }

        private void lvwXml_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
