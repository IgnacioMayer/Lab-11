using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class Form1 : Form
    {
        private Gestionador gestionador;
        private int selectedId;

        public Form1(Gestionador gestionador)
        {
            this.gestionador = gestionador;
            InitializeComponent();
            foreach(Local local in  this.gestionador.Locales)
            {
                listBox1.Items.Add(local.Show());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gestionador.Guardar();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)listBox1.SelectedItem;
            int id = int.Parse(selected.Split(',')[0]);
            this.selectedId = id;
            Local localSeleccionado = null;
            foreach(Local local in this.gestionador.Locales)
            {
                if(local.Id == id)
                {
                    localSeleccionado = local;
                    break;
                }
            }
            textBox1.Text = localSeleccionado.Nombre;
            textBox2.Text = localSeleccionado.Horario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line = $"{this.selectedId},{textBox1.Text},{textBox2.Text}";
            listBox1.Items.RemoveAt(this.selectedId - 1);
            listBox1.Items.Insert(this.selectedId - 1, line);

            Local localSeleccionado = null;
            foreach (Local local in this.gestionador.Locales)
            {
                if (local.Id == this.selectedId)
                {
                    localSeleccionado = local;
                    break;
                }
            }
            localSeleccionado.Nombre = textBox1.Text;
            localSeleccionado.Horario = textBox2.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
