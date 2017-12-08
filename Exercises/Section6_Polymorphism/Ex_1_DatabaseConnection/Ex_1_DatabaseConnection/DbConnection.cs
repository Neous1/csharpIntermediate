using System;

namespace Ex_1_DatabaseConnection
{
    public abstract class DbConnection
    {
        private string _connectionString;

        /*ConnectionString : string
Timeout : TimeSpan*/
        public string ConnectionString
        {
            get { return _connectionString; }
            set
            {
                if (String.IsNullOrEmpty(_connectionString))
                    Console.WriteLine("connection string needed to connect");
                _connectionString = value;
            }
        }

        public TimeSpan Timeout { get; set; }


        public DbConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();


        public abstract void CloseConnection();

    }
}