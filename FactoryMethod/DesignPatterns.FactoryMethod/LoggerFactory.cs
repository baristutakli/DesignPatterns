using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class LoggerFactory:ILoggerFactory
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
