using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals= new ICustomerDal[3]
            {
                new SqlServerDal(), 
                new OracleServerDal(),
                new MySqlServerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Emine", LastName = "Aşçı", Address = "Düzce" });

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Nazmiye",
                LastName = "Aşçı",
                Departmant = "Bilgisayar"
            };

            Worker worker = new Worker()
            {
                Id = 1,
                FirstName = "Mustafa",
                LastName = "Aşçı",
                Departmant = "Eczane"
            };

            personManager.Add(student);
            personManager.Add(worker);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }



    }
    class Customer : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

    }
    
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
