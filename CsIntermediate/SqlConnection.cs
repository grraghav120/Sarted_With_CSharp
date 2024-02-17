namespace ConsoleApp1.CsIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString) { }

        public override void openConnection()
        {
            Console.WriteLine("SQL Connection Opened");
        }
        public override void closeConnection()
        {
            Console.WriteLine("SQl Closed Connection");
        }
    }

}
