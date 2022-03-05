using System;

namespace DesignPatterns.Facade
{
    public class Caching : ICache
    {
        public void Cache() => Console.WriteLine("Cached");
    }
}
