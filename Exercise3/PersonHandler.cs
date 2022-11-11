using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class PersonHandler
    {
        public static void SetAge(Person person, int age)
        {
            person.Age = age;
        }
        public static void SetFirstName(Person person, string firstName)
        {
            person.FirstName = firstName;
        }

        public static void SetLastName(Person person, string lastName)
        {
            person.LastName = lastName;
        }
        public static void SetHeight(Person person, double height)
        {
            person.Height = height;
        }
        public static void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
        }

        public static Person CreatePerson(string firstName, string lastName, int age, double height, double weight)
        {
            Console.WriteLine("Creating a person!");
            Person person = new Person(firstName, lastName, age, height, weight);
            return person;
        }


        public static Person CreatePerson(string firstName, string lastName)
        {
            Console.WriteLine("Creating a person!");
            Person person = new Person(firstName, lastName);
            return person;
        }
    }
}
