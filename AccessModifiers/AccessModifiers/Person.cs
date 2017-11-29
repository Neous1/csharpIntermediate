using System;

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
}