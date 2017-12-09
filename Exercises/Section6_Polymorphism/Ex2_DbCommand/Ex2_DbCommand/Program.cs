namespace Ex2_DbCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructions = "Select * from All tables";
            var newCommand = new DbCommand(new OracleConnection("s"), instructions );
            
            newCommand.Execute();




/*            Console.WriteLine("Press S or O ");
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
                        var orcl = new OracleConnection(connector);
                        orcl.OpenConnection();
                        Console.WriteLine("Oracle is open for business");
                        orcl.CloseConnection();
                        break;
                }
            }*/
        }
    }
}
