namespace DesignPatterns.Adapter
{
    public class LogAdapter : ILogger
    {
        public void Log(string message)
        {
            DbLogger dbLogger = new DbLogger();
            dbLogger.Log(message);
        }
    }
}
