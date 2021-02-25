using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin",LastName = "Demirog",City = "Ankara"};
            Customer customer2 = new Customer(2,"Derin","Demirog","Ankara");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Semih";
            customer3.LastName = "Bilinmez";
            customer3.City = "New Orleans";


            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer1.FirstName);
        }
    }
    class Customer
    {
        //parametre istemezsek aşagidajki gibi  ,customer 1 veya 3'teki gibi yazarız
        public Customer()
        {
                
        }
        //default constructor
        //parametre istersak aşagidaki gibi ,customer 2 şeklinde yazarız
        public Customer(int id, string firstName,string lastName,string city) //ctor tab tab
        {
           // camelCase----->PascalCase
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city; //bu 4 satırı yazınca derin yazdı yoksa yazmaazdı.
            
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
