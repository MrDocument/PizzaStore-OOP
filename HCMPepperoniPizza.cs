using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_1
{
    class HCMPepperoniPizza : Pizza
    {
        public HCMPepperoniPizza()
        {
            name = "HCM The best pepperoni pizza";
            dough = "HCM Thick dough";
            sauce = "HCM Sweet sauce";
            toppings.Add("Tomato");
        }
        public override void Box()
        {
            base.Box();
            Console.WriteLine(name);
        }
    }
}
