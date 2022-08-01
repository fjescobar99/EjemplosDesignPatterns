using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class TeTradicional : Bebida
    {
        public override float Costo()
        {
            return 8;
        }

        public override string GetDescripcion()
        {
            return "Te tradicional, ";
        }
    }
}
