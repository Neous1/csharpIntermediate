using System.Collections.Generic;

namespace constructors
{
    public class Customer
    {
        public int Id;
        public string Name; // keyworkd public used here to illustrate. 
        public List<Order> Orders;

        //default parameterless constructor
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            :this() // this is meant to call the 1st overload
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // this is meant to call the 2nd overload which in turn calls the 1st overload
        {
            this.Name = name;
        }
    }
}