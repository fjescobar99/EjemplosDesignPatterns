using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class CafeSolo : Bebida
    {
        public override float Costo()
        {
            return 10;
        }

        public override string GetDescripcion()
        {
            return "Cafe solo ,";
        }
    }
}
