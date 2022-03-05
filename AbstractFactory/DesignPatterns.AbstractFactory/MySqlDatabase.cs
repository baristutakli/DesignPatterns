namespace DesignPatterns.AbstractFactory
{
    public class MySqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand()
        => new MySqlCommand();

        public override Connection CreateConnection()
        =>
            new MySqlConnection();
    }
}
