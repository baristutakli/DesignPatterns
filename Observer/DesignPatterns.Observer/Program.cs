using System;

namespace DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PostManager manager = new();
            manager.AddObserver(new AdminObserver());
            manager.AddObserver(new EditorObserver());
            manager.UpdatePost();
        }
    }
}
