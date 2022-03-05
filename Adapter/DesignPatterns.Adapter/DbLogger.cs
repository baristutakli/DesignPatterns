using System;

namespace DesignPatterns.Adapter
{
    public class DbLogger
    {
        public void Log(string message)  => Console.WriteLine("DBLogger");
    }
}
