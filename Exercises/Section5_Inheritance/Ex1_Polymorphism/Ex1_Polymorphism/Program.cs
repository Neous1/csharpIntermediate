using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Polymorphism
{
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


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
