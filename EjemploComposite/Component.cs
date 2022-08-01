using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposite
{
    public abstract class Component
    {
        public string nombre;

        public List<Component> components;

        protected Component()
        {
            this.components = new List<Component>();
        }

        public abstract string Operation();

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public abstract Component GetChild(string nombre);

        public abstract bool ExisteHijo(string nombre);
    }
}
