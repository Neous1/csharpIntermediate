using System;

namespace Ex2_DbCommand
{
    public class DbCommand
    {
        public DbConnection DbConnection;
        public string Instructions;

        public DbCommand(DbConnection dbConnection, string instructions)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("We need a connectionString");


            
            if (instructions == null)
                throw new InvalidOperationException("What would you like to do in your opened db");

            DbConnection = dbConnection;
            Instructions = instructions;
        }

        public void Execute()
        {

            //open db
            DbConnection.OpenConnection();


            //send instructions
            Console.WriteLine(Instructions);
            

            //close connecgtion
            DbConnection.CloseConnection();
            
            
        }
    }
}