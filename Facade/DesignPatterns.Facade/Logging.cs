using System;

namespace DesignPatterns.Facade
{
    public class Logging : ILogger, ICache, IAuthorize
    {
        public void Log() => Console.WriteLine("Logged");
        public void Cache() => Console.WriteLine("Cached");
        public void CheckUser() =>
               Console.WriteLine("User checked");
    }
}
