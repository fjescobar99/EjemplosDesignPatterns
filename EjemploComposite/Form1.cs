using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace EjemploComposite
{
    public partial class Form1 : Form
    {
        private Composite nodoPadre;
        public Form1()
        {
            InitializeComponent();
            nodoPadre = new Composite()
            {
                nombre = "padre"
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Padre");
        }

        //hoja
        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
                return;
            string nombreHijo = Interaction.InputBox("Nombre:");
            if (nodoPadre.ExisteHijo(nombreHijo))
                return;
            string nombrePadre = treeView1.SelectedNode.Text;
            nodoPadre.GetChild(nombrePadre).Add(new Leaf() {nombre = nombreHijo });

            ActualizarTreeViewPermisos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
                return;

            string nombreHijo = Interaction.InputBox("Nombre:");
            if (nodoPadre.ExisteHijo(nombreHijo))
                return;

            string nombrePadre = treeView1.SelectedNode.Text;
            if (String.IsNullOrEmpty(nombrePadre))
                return;

            nodoPadre
                .GetChild(nombrePadre)
                .Add(
                    new Composite() {
                        nombre = nombreHijo 
                    });

            ActualizarTreeViewPermisos();
        }

        private void ActualizarTreeViewPermisos()
        {
            treeView1.Nodes.Clear();

            TreeNode raiz = new TreeNode(nodoPadre.nombre);
            this.treeView1.Nodes.Add(raiz);

            foreach (var item in nodoPadre.components)
            {
                var tn = CrearNodo(item);
                raiz.Nodes.Add(tn);
                if (item.components.Count > 0)
                {
                    MostrarArbolRecursivo(tn, item);
                }
            }

            this.treeView1.ExpandAll();
        }

        private TreeNode CrearNodo(Component item)
        {
            TreeNode tn = new TreeNode(item.nombre);
            tn.Tag = item;
            return tn;
        }

        private void MostrarArbolRecursivo(TreeNode treeNodepadre, Component componentPadre)
        {
            foreach (var componentHijo in componentPadre.components)
            {
                TreeNode treeNodeHijo = new TreeNode(componentHijo.nombre);
                treeNodepadre.Nodes.Add(treeNodeHijo);
                if (componentHijo.components.Count > 0)
                {
                    MostrarArbolRecursivo(treeNodeHijo, componentHijo);
                }
            }
        }
        private string selectedNode;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.selectedNode = treeView1.SelectedNode.Text;
        }
    }
}
