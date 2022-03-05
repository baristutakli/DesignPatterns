using System;

namespace DesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Category c1 = new Category(1, "Body", "Meta title", "Title");
            Category c2 = (Category)c1.Clone();

            if (c1.Equals(c2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal!!!");
            }
            Console.ReadLine();
        }
    }
}
