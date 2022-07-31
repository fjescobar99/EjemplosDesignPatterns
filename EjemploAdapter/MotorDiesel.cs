using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapter
{
    class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando desde motor diesel...");
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando desde motor diesel...");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando desde motor diesel...");
        }

        public override void CargarCombustible()
        {
            
        }
    }
}
