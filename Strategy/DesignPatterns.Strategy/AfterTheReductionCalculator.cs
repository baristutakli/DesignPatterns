using System;

namespace DesignPatterns.Strategy
{
    public class AfterTheReductionCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("The result after the last reduction:");
        }
    }
}
