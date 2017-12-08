using System;

namespace Ex_1_DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            //throw new NotImplementedException();
            Console.WriteLine("open a Oracle DB");
        }

        public override void CloseConnection()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Close Oracle DB");
        }
    }
}