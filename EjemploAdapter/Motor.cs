using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapter
{
    public abstract class Motor
    {
        public abstract void Acelerar();
        public abstract void Apagar();
        public abstract void Arrancar();
        public abstract void CargarCombustible();
    }
}
