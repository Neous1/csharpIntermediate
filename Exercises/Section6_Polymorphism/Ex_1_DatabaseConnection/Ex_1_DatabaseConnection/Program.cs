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
            var sql = new SqlConnection("connect to sql ");
            var orcl  = new OracleConnection("Oracle connecter");


            Console.WriteLine("Press S or O ");
            var connector = Console.ReadLine();
            if (connector != null)
            {
                connector = connector.ToUpper();
                switch (connector)
                {
                    case "S":
                        sql.OpenConnection();
                        Console.WriteLine("sql is open for business");
                        Console.WriteLine();
                        break;
                    case "O":
                        orcl.OpenConnection();
                        Console.WriteLine("Oracle is open for business");
                        break;
                }
            }

            Console.WriteLine("Press S or O key to close ");
            connector = Console.ReadLine();
            if (connector != null)
            {
                connector = connector.ToUpper();
                switch (connector)
                {
                    case "S":
                        sql.CloseConnection();
                        Console.WriteLine("sql is open for business");
                        Console.WriteLine();
                        break;
                    case "O":
                        orcl.CloseConnection();
                        Console.WriteLine("Oracle is open for business");
                        break;
                }
            }
        }
    }
}
