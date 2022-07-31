using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new ElectricoAdapter();
            //Motor motor = new MotorDiesel();

            motor.Acelerar();
            motor.Apagar();

            Console.ReadLine();
        }
    }
}
