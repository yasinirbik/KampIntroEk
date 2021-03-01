using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName ="Telefon" },
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Monster Laptop",QuantityPerUnit = "32 GB RAM",UnitPrice = 10000,UnitInStock = 5},
                new Product{ProductId = 2,CategoryId = 1,ProductName = "MSI Laptop",QuantityPerUnit = "16 GB RAM",UnitPrice = 8000,UnitInStock = 3},
                new Product{ProductId = 3,CategoryId = 1,ProductName = "ASUS Laptop",QuantityPerUnit = "8 GB RAM",UnitPrice = 6000,UnitInStock = 2},
                new Product{ProductId = 4,CategoryId = 2,ProductName = "Samsung Telefon",QuantityPerUnit = "4 GB RAM",UnitPrice = 5000,UnitInStock = 15},
                new Product{ProductId = 5,CategoryId = 2,ProductName = "Apple Telefon",QuantityPerUnit = "4 GB RAM",UnitPrice = 8000,UnitInStock = 0},
            };
            Console.WriteLine("Algoritmik----------------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice>7000 && product.UnitInStock>4)//7000 lira üzeri ve stokta 4'ten fazla ürünleri bu şekilde litleleriz (LINQ olmaaddn)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine();
            Console.WriteLine("LINQ-------------------------------------");
            var result = products.Where(p => p.UnitPrice > 7000 && p.UnitInStock > 4);//p yerine product'da yazabilriz fark etmez ama p şeklinde tercih edilir.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            GetProducts();
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 7000 && product.UnitInStock > 4).ToList();
        }


    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit{ get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
