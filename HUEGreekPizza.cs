using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_1
{
    class HUEGreekPizza : Pizza
    {
        public HUEGreekPizza()
        {
            name = "HUE A good greed pizza";
            dough = "HUE Thin dough";
            sauce = "HUE Chille sauce";
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
