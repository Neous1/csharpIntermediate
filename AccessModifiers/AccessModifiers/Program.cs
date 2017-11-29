using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        //create method to access birthdate
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


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
