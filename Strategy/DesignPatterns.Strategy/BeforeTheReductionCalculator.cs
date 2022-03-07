using System;

namespace DesignPatterns.Strategy
{
    public class BeforeTheReductionCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("The result before the last reduction:");
        }
    }
}
