using System;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomerManager manager = new();
            manager.CreditCalculatorBase = new BeforeTheReductionCalculator();
            manager.SaveResult();
            manager.CreditCalculatorBase = new AfterTheReductionCalculator();
            manager.SaveResult();
        }


    }
}
