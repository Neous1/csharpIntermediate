using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_DatabaseConnection
{
    public class DbConnection
    {
        private string _connectionString;

        /*ConnectionString : string
Timeout : TimeSpan*/
        public string ConnectionString
        {
            get { return _connectionString; }
            set
            {
                if (_connectionString == null)
                    Console.WriteLine("connection string needed to connect");
                _connectionString = value;
            }
        }

        public TimeSpan Timeout { get; set; }


        public DbConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract OpenConnection()
        {
            
        }

        public as CloseConnection()
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
