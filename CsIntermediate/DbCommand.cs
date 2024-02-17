namespace ConsoleApp1.CsIntermediate
{
    public class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _command;
        public DbCommand(DbConnection conn,string Command)
        {
            if(conn == null)
            {
                throw new InvalidOperationException();
            }
            if (String.IsNullOrEmpty(Command))
            {
                throw new InvalidOperationException();
            }
            _connection = conn;
            _command = Command;

        }
        public void Execute()
        {
            _connection.openConnection();
            Console.WriteLine("Executing the {0}",_command);
            _connection.closeConnection();
        }
    }
}
