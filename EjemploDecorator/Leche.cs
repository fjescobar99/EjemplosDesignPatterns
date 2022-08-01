using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    public class Leche : AgregadoDecorator
    {
        public Leche(Bebida bebida)
        {
            this.bebida = bebida;
        }

        public override float Costo()
        {
            return (float)(bebida.Costo() + 0.30);
        }

        public override string GetDescripcion()
        {
            return bebida.GetDescripcion() + "leche, ";
        }
    }
}
