using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDecorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bebida bebida;
        private void btnSolo_Click(object sender, EventArgs e)
        {
            bebida = new CafeSolo();
            textBox1.Text = "$" + bebida.Costo().ToString("#.##") + " ";
            textBox1.AppendText(bebida.GetDescripcion());
        }

        private void btnExpreso_Click(object sender, EventArgs e)
        {
            bebida = new CafeExpreso();
            textBox1.Text = "$" + bebida.Costo().ToString("#.##") + " ";
            textBox1.AppendText(bebida.GetDescripcion());
        }

        private void btnSinCafeina_Click(object sender, EventArgs e)
        {
            bebida = new CafeSinCafeina();
            textBox1.Text = "$" + bebida.Costo().ToString("#.##") + " ";
            textBox1.AppendText(bebida.GetDescripcion());
        }

        private void btnTe_Click(object sender, EventArgs e)
        {
            bebida = new TeTradicional();
            textBox1.Text = "$" + bebida.Costo().ToString("#.##") + " ";
            textBox1.AppendText(bebida.GetDescripcion());
        }

        private void btnleche_Click(object sender, EventArgs e)
        {
            bebida = new Leche(bebida);
            textBox1.Text = "$" + bebida.Costo().ToString("#.##") + " ";
            textBox1.AppendText(bebida.GetDescripcion());
        }

        private void btnCrema_Click(object sender, EventArgs e)
        {
            bebida = new Crema(bebida);
            textBox1.Text = "$" + bebida.Costo().ToString("#.##") + " ";
            textBox1.AppendText(bebida.GetDescripcion());
        }

        private void btnEdulcorante_Click(object sender, EventArgs e)
        {
            bebida = new Edulcorante(bebida);
            textBox1.Text = "$" + bebida.Costo().ToString("#.##") + " ";
            textBox1.AppendText(bebida.GetDescripcion());
        }

        private void btnAzucar_Click(object sender, EventArgs e)
        {
            bebida = new Azucar(bebida);
            textBox1.Text = "$" + bebida.Costo().ToString("#.##") + " ";
            textBox1.AppendText(bebida.GetDescripcion());
        }
    }
}
