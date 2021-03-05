using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity Framework --- Bir ORM --Object Relational Mapping
            //NHibernate //Dapper
           // GetAll();//Üürnlerin hepsini getiren metot
            GetProductsByCategoryId(1);//KategoriId = 1 olan ürünlerimizi listeleyen metot.
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void GetProductsByCategoryId(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var product in result)
            {
                Console.WriteLine(product.CategoryId +"-------->"+ product.ProductName);
            }
        }
    }
}
