using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{

//crteate a class that derives from the customer class
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1980,3,31));
            Console.WriteLine(person.GetBirthdate());


        }
    }
}
