namespace ConsoleApp1.CsIntermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            :base(connectionString) { }

        public override void openConnection()
        {
            Console.WriteLine("Oracle DB Connection opened ");
        }
        public override void closeConnection() { Console.WriteLine("Oracle DB connection closed"); }
    }

}
