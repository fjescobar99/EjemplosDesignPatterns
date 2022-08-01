using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposite
{
    public class Leaf : Component
    {
        public Leaf() : base()
        {
        }

        public override void Add(Component component)
        {
            
        }

        public override bool ExisteHijo(string nombre)
        {
            return false;
        }

        public override Component GetChild(string nombre)
        {
            return null;
        }

        public override string Operation()
        {
            return nombre;   
        }

        public override void Remove(Component component)
        {
            
        }
    }
}
