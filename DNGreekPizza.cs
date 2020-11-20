using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_1
{
    class DNGreekPizza : Pizza
    {
        public DNGreekPizza()
        {
            name = "DN A good greed pizza";
            dough = "DN Thin dough";
            sauce = "DN Chille sauce";
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
