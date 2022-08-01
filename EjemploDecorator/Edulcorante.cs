using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    class Edulcorante : AgregadoDecorator
    {
        public Edulcorante(Bebida bebida)
        {
            this.bebida = bebida;
        }

        public override float Costo()
        {
            return (float)(bebida.Costo() + 0.6);
        }

        public override string GetDescripcion()
        {
            return bebida.GetDescripcion() + "edulcorante,  ";
        }
    }
}
