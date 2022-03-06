using System;

namespace DesignPatterns.FactoryMethod
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            // Decide business rules
            return new DBLogger();
        }
    }

    public class DBLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged!");
        }
    }
}
