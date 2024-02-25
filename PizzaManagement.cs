using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class PizzaManagement
    {
        static List<Pizza> pizzas = new List<Pizza>()
        {
            new Pizza{Id=1,Name="Paneer Pizza",Price=350},
            new Pizza{Id=2,Name="Mushroom Pizza",Price=450},
            new Pizza{Id=3,Name="Corn Pizza",Price=300},
        };
        public List<Pizza> AllPizzas()
        {
            return pizzas;
        }
    }
}
