using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public abstract class Bebida
    {
        protected float costo;
        protected string descripcion;

        public abstract float Costo();

        public abstract string GetDescripcion();
    }
}
