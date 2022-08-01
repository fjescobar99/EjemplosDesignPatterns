using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposite
{
    public class Composite : Component
    {
        public Composite() : base()
        {
        }

        public override void Add(Component component)
        {
            this.components.Add(component);
        }

        public override bool ExisteHijo(string nombreHijo)
        {
            bool existe = false;
            if (this.nombre.Equals(nombreHijo, StringComparison.OrdinalIgnoreCase))
            {
                existe = true;
            }
            else
            {
                foreach (var item in components)
                {
                    if (item.nombre.Equals(nombreHijo, StringComparison.OrdinalIgnoreCase))
                    {
                        existe = true;
                        break;
                    }
                    else
                    {
                        existe = item.ExisteHijo(nombreHijo);
                    }
                }
            }
            return existe;
        }

        public override Component GetChild(string nombreHijo)
        {
            Component encontrado = null;
            if (this.nombre.Equals(nombreHijo, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = this;                
            }
            else
            {
                foreach (var item in components)
                {
                    if (item.nombre.Equals(nombreHijo, StringComparison.OrdinalIgnoreCase))
                    {
                        encontrado = item;
                        break;
                    }
                    else
                    {
                        encontrado = item.GetChild(nombreHijo);                        
                    }
                }
            }
            return encontrado;
        }

        public override string Operation()
        {
            return nombre;
        }

        public override void Remove(Component component)
        {
            this.components.Remove(component);
        }
        
    }
}
