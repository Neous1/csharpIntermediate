﻿using System;

namespace Properties
{
    public class Person
    {

        //add a private modifier in from of set if one wishes to set a field only once.
        // set is readonly
        public DateTime Birthdate { get; private set; }



        //create a constructor to make birthday accessible only once
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            // no setter need since we can't set the age of a person adn age is calculated based on 
            // birthdate 
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}