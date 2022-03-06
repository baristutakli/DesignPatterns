namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();
        }
    }
}
