using System;

namespace workshop03
{
    class Person
    {
        //Properties
        public string FirstName { get; }
        public string LastName { get; }

        // type DateTime kan inneholde en dato og et klokkeslett
        public DateTime DateOfBirth { get; set; }
        
        //Konstruktør
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}