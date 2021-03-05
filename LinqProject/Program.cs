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
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Monster Laptop",QuantityPerUnit = "32 GB RAM",UnitPrice = 10001,UnitInStock = 5},
                new Product{ProductId = 2,CategoryId = 1,ProductName = "MSI Laptop",QuantityPerUnit = "32 GB RAM",UnitPrice = 10000,UnitInStock = 3},
                new Product{ProductId = 3,CategoryId = 1,ProductName = "ASUS Laptop",QuantityPerUnit = "8 GB RAM",UnitPrice = 6000,UnitInStock = 2},
                new Product{ProductId = 4,CategoryId = 2,ProductName = "Samsung Telefon",QuantityPerUnit = "4 GB RAM",UnitPrice = 5000,UnitInStock = 15},
                new Product{ProductId = 5,CategoryId = 2,ProductName = "Apple Telefon",QuantityPerUnit = "4 GB RAM",UnitPrice = 8000,UnitInStock = 0},
            };
            //Test(products);
            // GetProductsLinq(products);
            // AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            // AscDescTest(products);
            //ClassicLinqTest(products);
            var result = from p in products
                         join c in categories//productlardakı her bir p il ecategories'deki her bir c'yi join'ledik.
                         on p.CategoryId equals c.CategoryId//CategoryId'leerin ortaklığını kullanarak
                         where p.UnitPrice>5500
                         orderby p.UnitPrice//5500 ÜSTÜ ARTAN ŞEKİLDE SIRALA
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                //Console.WriteLine("Ürün: "+productDto.ProductName + "      Kategori: "+productDto.CategoryName );Altta alternatif bir yazımı mevcuttur.
                Console.WriteLine("{0}----{1}-------{2}",productDto.ProductName,productDto.CategoryName,productDto.UnitPrice);
            }                         

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 7000 && p.ProductName.Contains("Laptop")
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
                //Bu da bir kullanım yöntemi koşullara(where) uyan bütün product'ların productname'is listeelnir
                //MSI ve mosnter laptop koşullara(Where) uyduğu için listelenir daha pahalı olan monster da önce (order by)listelenmektedir
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            //single line query
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenByDescending(p => p.ProductName);//orderbydescending ile de düşen fiyat şeklinde sıralayabliriz.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
                //içerisinde top olanları ürün fiyatına bakarak artan şekilde listeler eğer ki eşitlik varsa da alfabetik sıraya tersten(z-a) sırayla lsiteler.
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));//Ürün adında top geçen productlar llstesi döner.
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);//3 nol'lu ıd'ye sahip ürünü getirir.
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop"); //Acaer laptop var mı? True or False döner.Olmadığı için False dönecektir.
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik----------------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 7000 && product.UnitInStock > 4)//7000 lira üzeri ve stokta 4'ten fazla ürünleri bu şekilde litleleriz (LINQ olmaaddn)
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
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 7000 && product.UnitInStock > 4).ToList();
        }


    }
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
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
