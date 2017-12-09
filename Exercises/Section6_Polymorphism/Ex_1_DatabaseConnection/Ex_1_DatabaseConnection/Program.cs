using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ask for connectinon 
            if connection is O create a a oracle object 
            open oracle db
            */
            
            Console.WriteLine("Press S or O ");
            var connector = Console.ReadLine();
            if (connector != null)
            {
                connector = connector.ToUpper();
                switch (connector)
                {
                    case "S":
                        var sql = new SqlConnection(connector);
                        sql.OpenConnection();
                        Console.WriteLine("sql is open for business");
                        Console.WriteLine();
                        sql.CloseConnection();
                        break;
                    case "O":
                        var orcl = new OracleConnection("Oracle connecter");
                        orcl.OpenConnection();
                        Console.WriteLine("Oracle is open for business");
                        orcl.CloseConnection();
                        break;
                }
            }

        }
    }
}
