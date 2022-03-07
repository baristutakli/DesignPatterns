using System;

namespace DesignPatterns.Observer
{
    public class AdminObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Warning!!! new modifications");
        }
    }
}
