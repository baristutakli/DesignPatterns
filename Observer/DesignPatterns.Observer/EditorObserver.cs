using System;

namespace DesignPatterns.Observer
{
    public class EditorObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Check the curent version of the post!!!!");
        }
    }
}
