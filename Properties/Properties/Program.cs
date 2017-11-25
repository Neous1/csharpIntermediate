using System;

namespace Properties
{
    class Program
    {
        static void Main()
        {
            var person = new Person(new DateTime(1983, 3, 31));
            Console.WriteLine(person.Age);
        }
    }
}
