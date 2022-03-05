using System;

namespace DesignPatterns.Facade
{
    public class Authorize : IAuthorize
    {
        public void CheckUser() =>
               Console.WriteLine("User checked");
    }
}
