using System;
using System.Collections.Generic;
using System.Linq;

namespace workshop03
{
    class Program
    {
        static void Main(string[] args)
        {
            // to instanser/objekter av klassen person
            var supporter1 = new Person("Bob", "Baker");
            var supporter2 = new Person("John", "Smith");
            var supporter3 = new Person("Jane", "Doe");

            supporter1.DateOfBirth = new DateTime(1988,2,3);
            supporter2.DateOfBirth = new DateTime(1989,6,25);
            supporter3.DateOfBirth = new DateTime(1990,8,18);

            // typen List<T> er en liste av typen T. I dette tilfelle en liste av type Person
            List<Person> personer = new List<Person>();

            // man kan legge inn så mange objekter av riktig type som man vil i en List.
            // i motsetning til en array så utvider List seg automatisk hvis den trenger mer plass
            personer.Add(supporter1);
            personer.Add(supporter2);
            personer.Add(supporter3);

            // sorter personer etter når de ble født fra sist til først
            var sortedPersons = personer.OrderByDescending(p => p.DateOfBirth).ToList();

            Console.WriteLine("Usortert:");
            personer.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName}"));
            
            Console.WriteLine();

            Console.WriteLine("Sortert:");
            sortedPersons.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName}"));
        }
    }
}
