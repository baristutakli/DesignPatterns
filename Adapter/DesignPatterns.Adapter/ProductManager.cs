using System;

namespace DesignPatterns.Adapter
{
    public class ProductManager
    {
        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Log("Message");
            Console.WriteLine("Saved");
        }
    }
}
