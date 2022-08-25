using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component pizza = new Pizza();
            pizza = new Cheeze(pizza);
            pizza = new Cheeze(pizza);
            pizza = new Pizza();
            Console.WriteLine(pizza.Description() + pizza.Price());
        }
    }
}
