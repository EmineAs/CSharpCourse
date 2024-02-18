using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Engin"
                },
                new Student
                {
                    FirstName="Emine"
                },
                new Person
                {
                    FirstName="Nazmiye"
                }
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine(); 
        }
    }

    class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string city { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
    
}
