using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class CafeSinCafeina : Bebida
    {
        public override float Costo()
        {
            return 15;
        }

        public override string GetDescripcion()
        {
            return "Cafe sin cafeina, ";
        }
    }
}
