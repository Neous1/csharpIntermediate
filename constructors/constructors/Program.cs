using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Yvon";

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
