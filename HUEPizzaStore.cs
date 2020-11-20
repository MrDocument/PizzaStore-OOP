using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_1.Store
{
    public class HUEPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HUECheesePizza();
                case "greek":
                    return new HUEGreekPizza();
                case "pepperoni":
                    return new HUEPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
