using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorator
{
    class Azucar : AgregadoDecorator
    {
        public Azucar(Bebida bebida)
        {
            this.bebida = bebida;
        }

        public override float Costo()
        {
            return (float)(bebida.Costo() + 0.7);
        }

        public override string GetDescripcion()
        {
            return bebida.GetDescripcion() + "Azucar,  ";
        }
    }
}
