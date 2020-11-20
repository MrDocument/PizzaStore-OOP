using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_1
{
    class HCMGreekPizza : Pizza
    {
        public HCMGreekPizza()
        {
            name = "HCM A good greed pizza";
            dough = "HCM Thin dough";
            sauce = "HCM Chille sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");

        }
        public override void Box()
        {
            base.Box();
            Console.WriteLine(name);
        }
    }
}
