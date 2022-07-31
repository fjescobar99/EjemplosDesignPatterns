using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapter
{
    public class MotorElectrico
    {
        public void Activar()
        {
            Console.WriteLine("Activando desde motor electrico...");
        }

        public void Conectar()
        {
            Console.WriteLine("Conectando desde motor electrico...");
        }
        public void Desconectar()
        {
            Console.WriteLine("Desconectando desde motor electrico...");
        }
        public void Enchufar()
        {
            Console.WriteLine("Enchufando desde motor electrico...");
        }
        public void Mover()
        {
            Console.WriteLine("Moviendo desde motor electrico...");
        }
        public void Parar()
        {
            Console.WriteLine("Parando desde motor electrico...");
        }
    }
}
