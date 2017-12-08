using System;

namespace Ex_1_DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public override void CloseConnection()
        {
            throw new NotImplementedException();
        }
    }
}