using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_1
{
    public class DNCheesePizza : Pizza
    {
        public DNCheesePizza()
        {
            name = "DN The best cheese pizza";
            dough = "DN Very thin dough";
            sauce = "DN Very spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Cheese");
        }

        public override void Box()
        {
            base.Box();
            Console.WriteLine(name);
        }
    }
}
