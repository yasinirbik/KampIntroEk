using System;

namespace ReferansTipleriKafamizdaNetlestirme
{
    class Program
    {
        static void Main(string[] args)
        {
            //int decimal,float,enum,boolean - value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;//Değer Eşitlemesi
            sayi2 = 100;
            Console.WriteLine("sayi 1 : " + sayi1);//20
            Console.WriteLine("sayi 2 : "+sayi2);//100

            //arrays,class,interface...  - reference types
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;//Adres Eşitlemesi
            sayilar2[0] = 1000;
            Console.WriteLine("sayilar1[0] = "+ sayilar1[0]);//1000
            Console.WriteLine("sayilar2[0] = " + sayilar2[0]);//1000
            Person person = new Person();
            Person person1 = new Person();
            Person person2 = new Person();
            person.FirstName = "Yasin";
            person1.FirstName = "Engin";
            person2 = person1;//Adres Eşitlemesi
            person1.FirstName = "Derin";
            Console.WriteLine(person1.FirstName);//Derin
            Console.WriteLine(person2.FirstName);//Derin


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Ahmet";
            Console.WriteLine(person3.FirstName);
           // Console.WriteLine(customer.CreditCardNumber);//customer'ı person olarak tanımlayabiliriz fakat bu durumda person inheritance'indaki metotları çalışır customera özel metotlar çalışmaz. 
            //Customer kullanabilmek iççin aşağıdaki kod satırı kullanılabilir
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);//Veli
            personManager.Add(person);//Yasin
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
