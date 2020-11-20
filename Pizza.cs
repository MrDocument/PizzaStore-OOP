using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_1
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();
        protected string type;

        

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough..." + dough);
            Console.WriteLine("Adding sauce..." + sauce);
            Console.WriteLine("Adding topping:");
            toppings?.ForEach(
                (topping) => Console.WriteLine("\t" + topping)
            );
        }

        public void Bake()
        {
            Console.WriteLine("Baking " + name + "in 20 mins");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting " + name);
        }
        public virtual void Box()
        {
            Console.WriteLine("Boxing " + name);
        }
    }
}
