using AbstractFactory;
using AbstractFactory.ClasesPizzas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploAbstractFacotory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Cliente cliente;

        private void button1_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            //cliente.pizzeria = new PizzeriaArgentina();
            cliente.pizzeria = new PizzeriaItaliana();
            var emp = cliente.pizzeria.CrearEmpanada();
            var pizza = cliente.pizzeria.CrearPizza();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cboEmpanadas.DataSource = new List<string>() { "Carne", "Caprese" };
            this.cboPizzas.DataSource = new List<string>() { "Cancha", "Napolitana" };
            this.cboPizzerias.DataSource = new List<string>() { "Argentina", "Italiana" };
        }
    }
}
