using System;

namespace Interfaces
{
    class Program
    {
        //interface new'lenemez.
        static void Main(string[] args)
        {
           IPersonManager customerManager = new CustomerManager();

            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());

        }
    }
    interface IPersonManager//interface de şablonu belirleriz//classlarıda implement ederek bu şablona uyumlu sınıflar haline getiririz.
    {
        void Add();
        void Update();
    }
    //inheritance - class ----------implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müsteri Ekleme Kodları
            Console.WriteLine("Müsteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müsteri guncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel ekleme kodları
            Console.WriteLine("Personel Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel guncellendi.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Guncellendi.");
        }
    }
    class ProjectManager
    {
        //public void AddCustomer(CustomerManager customerManager)
        //{
        //    customerManager.Add();
        //}
        //public void AddEmployee(EmployeeManager employeeManager)
        //{
        //    employeeManager.Add();
        //}
        public void Add(IPersonManager personManager )
        {
            personManager.Add();
        }
    }
}
