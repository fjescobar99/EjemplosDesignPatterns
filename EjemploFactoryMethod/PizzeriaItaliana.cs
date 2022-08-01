using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFactoryMethod
{
    public class PizzeriaItaliana : Pizzeria
    {
        public override Pizza CrearPizza()
        {
            return new PizzaNapolitana();
        }
    }
}
