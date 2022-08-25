using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = Calcutor.Instance;

            var calc = Calcutor.Instance;
            Console.WriteLine(calculator.Add(10, 20));
        }
    }
}
