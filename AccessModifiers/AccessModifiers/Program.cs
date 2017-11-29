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
            var rating = this.CalculateRating(excludeOrders: true); // calculatingRating is accessible 
            //becuase it's a protected modifier which should be used minimally to avoid breaking the program in the case where
            // calculatingRating() gets decommissioned or deleted 
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
