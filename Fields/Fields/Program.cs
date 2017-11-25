using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // create constructors for customer
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id,string name)
            :this(id)
        {
            this.Name = name;
        }
    }

    public class Order
    {
        
    }

class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
