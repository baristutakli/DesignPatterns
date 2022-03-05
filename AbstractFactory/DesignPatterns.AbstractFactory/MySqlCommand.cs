using System;

namespace DesignPatterns.AbstractFactory
{
    public class MySqlCommand : Command
    {
        public override void Execute(string query)
        =>
            Console.WriteLine("Executed MySql Command");
    }
}
