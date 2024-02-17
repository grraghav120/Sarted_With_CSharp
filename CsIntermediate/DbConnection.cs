using System;

namespace ConsoleApp1.CsIntermediate
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeout;

        public DbConnection(String connetionString)
        {
            if (String.IsNullOrEmpty(connetionString))
            {
                throw new InvalidOperationException();
            }
            else
            {
                _connectionString = connetionString;
                Console.WriteLine("Your conn string {0}",connetionString);
            }
        }

        public abstract void openConnection();
        public abstract void closeConnection();
    }
}
