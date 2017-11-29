using System;

namespace Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        // create a default constructor
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized");
        }

        public Vehicle( string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }

    }
    
}