using System;
using System.IO;

namespace Ex_1_DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString;

        public TimeSpan Timeout;


        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new InvalidDataException("connection string is missing");
            }
            ConnectionString = connectionString;

            Timeout = TimeSpan.FromMilliseconds(54000);

        }



        public abstract void OpenConnection();


        public abstract void CloseConnection();

    }
}