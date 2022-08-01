using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class Crema : AgregadoDecorator
    {
        public Crema(Bebida bebida)
        {
            this.bebida = bebida;
        }

        public override float Costo()
        {
            return bebida.Costo() + 1;
        }

        public override string GetDescripcion()
        {
            return bebida.GetDescripcion() + "crema, ";
        }
    }
}
