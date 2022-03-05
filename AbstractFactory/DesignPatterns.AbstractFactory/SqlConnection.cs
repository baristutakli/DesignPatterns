using System;

namespace DesignPatterns.AbstractFactory
{
    public class SqlConnection : Connection
    {
        public override string State => throw new NotImplementedException();

        public override bool Connect()
        {
            Console.WriteLine("Connection Established");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("Connection ended");
            return false;
        }
    }
}
