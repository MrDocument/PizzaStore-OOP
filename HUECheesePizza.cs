using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_1
{
    public class HUECheesePizza : Pizza
    {
        public HUECheesePizza()
        {
            name = "HUE The best cheese pizza";
            dough = "HUE Very thin dough";
            sauce = "HUE spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Cheese");
        }

        
    }
}
