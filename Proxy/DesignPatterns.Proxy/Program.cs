using System;

namespace DesignPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreditManager manager = new();
            manager.Calculate();
        }
    }
}
