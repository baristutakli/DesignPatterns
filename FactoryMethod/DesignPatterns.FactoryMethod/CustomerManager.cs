namespace DesignPatterns.FactoryMethod
{
    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory;
        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        public void Save()
        {
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
