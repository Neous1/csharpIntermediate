using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {   

        static void Main(string[] args)
        {
            //create a object and pass it an object 
            var dbMigrator = new DbMigrator(new Logger());

            //create a variable and pass it to object
            var logged = new Logger();
            var installer = new Installer(logged);

            dbMigrator.Migrate();
            installer.Install();
            Console.WriteLine();

        }
    }
}
