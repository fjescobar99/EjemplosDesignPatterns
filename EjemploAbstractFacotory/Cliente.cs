using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.ClasesPizzas;

namespace AbstractFactory
{
    public class Cliente
    {
        public Pizzeria pizzeria;
        public Pizza pizza;
        public Empanada empanada;

        public void SetPizzeria(Pizzeria pizzeria)
        {
            this.pizzeria = pizzeria;
        }
        public void SetPizza(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public void SetEmpanada(Empanada empanada)
        {
            this.empanada = empanada;
        }
    }
}
