using System;

namespace DesignPatterns.Adapter
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged, {message}");
        }
    }
}
