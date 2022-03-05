namespace DesignPatterns.AbstractFactory
{
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool DisConnect();
        public abstract string State { get; }

    }
}
