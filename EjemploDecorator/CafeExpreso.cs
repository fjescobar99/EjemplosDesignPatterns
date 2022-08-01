using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class CafeExpreso : Bebida
    {
        public override float Costo()
        {
            return 12;
        }

        public override string GetDescripcion()
        {
            return "Cafe expreso";
        }
    }
}
