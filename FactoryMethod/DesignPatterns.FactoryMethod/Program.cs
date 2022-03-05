using System;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomerManager customerManager = new CustomerManager(new LoggerFactory());
            customerManager.Save();
        }
    }
}
