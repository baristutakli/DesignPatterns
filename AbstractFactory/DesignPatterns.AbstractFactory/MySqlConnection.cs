using System;

namespace DesignPatterns.AbstractFactory
{
    public class MySqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("MySqlConnection established");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("MySqlConnection Ended");
            return false;
        }
    }
}
