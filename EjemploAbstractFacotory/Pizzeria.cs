using AbstractFactory.ClasesPizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Pizzeria
    {
        public abstract Empanada CrearEmpanada();

        public abstract Pizza CrearPizza();

    }
}
