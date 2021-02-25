using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine();//satır atlatır.

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.WriteLine(); 
            //Bu şekilde de 
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";
            customer.City = "Ankara";
            //bu sekilde de tanımlayabiliriz.
            Customer customer1 = new Customer {Id = 2,FirstName = "Yasin", LastName = "Irbık",City = "Kutahya"  };

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer.City);

            Console.ReadLine();//bir tuşa basmanı bekliyor
        }
    }
    //Classları bu bölgeye de yazabiliriz projelerin içinde ayrı classlar oluşturarak da kullanabilirz.
   //Product Manager'ı o şekilde kulllandık
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}
