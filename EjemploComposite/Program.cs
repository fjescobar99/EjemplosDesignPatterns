using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Composite arbol = new Composite();
            arbol.Add(new Leaf() { nombre = "hoja1" });
            arbol.Add(new Composite() { nombre = "raiz1" });
            arbol.Add(new Composite() { nombre = "raiz2" });
            arbol.GetChild(1).Add(new Leaf() { nombre = "subhoja1" });*/
            Form1 form = new Form1();
           
            var d = form.ShowDialog();
            switch (d)
            {
                case System.Windows.Forms.DialogResult.None:
                    break;
                case System.Windows.Forms.DialogResult.OK:
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                    break;
                case System.Windows.Forms.DialogResult.Abort:
                    break;
                case System.Windows.Forms.DialogResult.Retry:
                    break;
                case System.Windows.Forms.DialogResult.Ignore:
                    break;
                case System.Windows.Forms.DialogResult.Yes:
                    break;
                case System.Windows.Forms.DialogResult.No:
                    break;
                default:
                    break;
            }
        }
    }
}
