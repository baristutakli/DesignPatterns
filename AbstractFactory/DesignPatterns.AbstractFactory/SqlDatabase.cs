namespace DesignPatterns.AbstractFactory
{
    public class SqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand()
        => new SqlCommand();

        public override Connection CreateConnection()
        =>
            new SqlConnection();
    }
}
