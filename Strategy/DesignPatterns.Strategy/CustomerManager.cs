using System;

namespace DesignPatterns.Strategy
{
    public class CustomerManager
    {
        public CreditCalculatorBase CreditCalculatorBase { get; set; }
        public void SaveResult()
        {
            Console.WriteLine("Business rules");
            CreditCalculatorBase.Calculate();

        }
    }
}
