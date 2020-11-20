using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_1
{
    public class HCMCheesePizza : Pizza
    {
        public HCMCheesePizza()
        {
            name = "HCM The best cheese pizza";
            dough = "HCM Very thin dough";
            sauce = "HCM Very spicy sauce";
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
