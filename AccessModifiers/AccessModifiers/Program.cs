using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;

namespace AccessModifiers
{

//crteate a class that derives from the customer class
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1980,3,31));
            Console.WriteLine(person.GetBirthdate());

            var customer = new Customer();
            Amazon.RateCalculator calulator = new RateCalculator();
          
        }
    }
}
