using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Polymorphism
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
    }

    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }
    }
    class DbConnection
    {

        private string _connectionString;

        public string ConnectionString
        {
            get
            {
                if (String.IsNullOrEmpty(_connectionString))
                {
                    Console.WriteLine("valid connection string is needed to connect");
                }
                return _connectionString;
            }
            set { _connectionString = value; }
        }

        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            
        }

        public void OpenConnection()
        {

        }

        public void CloseConnection()
        {

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
