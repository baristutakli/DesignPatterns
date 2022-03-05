using System;

namespace DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProductManager productManager = new ProductManager(new LogAdapter());
            productManager.Save();
            
        }
    }
}
