using System;

namespace DesignPatterns.AbstractFactory
{
    public class SqlCommand : Command
    {
        public override void Execute(string query) =>
            Console.WriteLine("Execute");
    }
}
