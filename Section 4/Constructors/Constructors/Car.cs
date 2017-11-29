using System;

namespace Constructors
{
    //define a class Car that derives from vehicle
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("car is being initialized. {0}", registrationNumber);
        }
    }
}