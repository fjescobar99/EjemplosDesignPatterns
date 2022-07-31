using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapter
{
    public class ElectricoAdapter : Motor
    {
        private MotorElectrico motorElectrico;

        public ElectricoAdapter()
        {
            this.motorElectrico = new MotorElectrico();
        }

        public override void Acelerar()
        {
            this.motorElectrico.Activar();
            this.motorElectrico.Mover();
        }

        public override void Apagar()
        {
            this.motorElectrico.Desconectar();
        }

        public override void Arrancar()
        {
            
        }

        public override void CargarCombustible()
        {
            
        }
    }
}
