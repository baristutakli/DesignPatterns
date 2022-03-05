using System;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Creater create = new Creater(new SqlDatabase());
            create = new Creater(new MySqlDatabase());
            
        }
    }
}
