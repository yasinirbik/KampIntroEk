using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ" ,Address = "Ankara",CreditCardNumber = "35135135"});
            //Customer customer = new Customer();
            //customer.Id = 1;
            //customer.FirstName = "Engin";
            //customer.LastName = "Demiroğ";
            //customer.Address = "Ankara";
            //customer.CreditCardNumber = "535153335";
            //personManager.Add(customer);
            Student student = new Student { Id = 18 , FirstName ="Yasin" , LastName = "Irbık",  StudentNumber = "12843450840" ,Department = "EEM" };
            personManager.Add(student);
            Console.ReadLine();
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
        public string CreditCardNumber { get; set; }
        public string Address { get; set; }
        //implemente ederiz(interface'de olanları classlarda da tanımlarız. zorundayız. Hata Alırız
        public string FirstName { get; set; }
        public string LastName { get ; set; }
        public int Id { get; set; }
    }
    class Student : IPerson
    {
        public string StudentNumber { get; set; }
        public string Department { get; set; }

        public string FirstName { get ; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName+ " has added!!");
        }
    }
}
