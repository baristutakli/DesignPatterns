using System;

namespace DesignPatterns.State
{
    class Program
    {
        static void Main(string[] args)
        {

            // Followed dofactory notes
            var context = new Context(new OpenScreen());
            // Issue requests, which toggles state
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
}
