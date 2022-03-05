using System;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a concrete phone
            PhoneBuilder samsung = new SamsungBuilder();
            PhoneManager manager = new PhoneManager();
            manager.Create(samsung);

            Console.WriteLine(samsung.Phone.ToString());

            // Create a concrete phone
            PhoneBuilder casper = new CasperBuilder();
            manager.Create(casper);

            Console.WriteLine(samsung.Phone.ToString());
        }
    }
}
