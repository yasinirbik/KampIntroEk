using D2HW6;
using System;
using System.Collections.Generic;

namespace D2HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 89;
            product1.Adi = "Kalem";
            product1.Kategori = "Kırtasiye";
            product1.Fiyat = 49;


            Product product2 = new Product();
            product2.Id = 76;
            product2.Adi = "Cep Telefonu";
            product2.Kategori = "Teknoloji";
            product2.Fiyat = 7999;

            Product product3 = new Product();
            product3.Id = 56;
            product3.Adi = "Puskullu Sirt Kasiyici";
            product3.Kategori = "Eglence";
            product3.Fiyat = 6;

            Product[] products = new Product[] { product1, product2, product3 };
            ////Foreach döngüsü ile Listeleme////
            //foreach (var product in products)
            //{
            //    Console.WriteLine("Product Id: " + product.Id + " Product Name: " + product.Adi + " Product Category: " + product.Kategori + " Product Price: " + product.Fiyat + "TL");
            //}
            //For döngüsü ile Listeleme/////
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product Id: " + products[i].Id + " Product Name: " + products[i].Adi + " Product Category: " + products[i].Kategori + " Product Price: " + products[i].Fiyat + "TL");
            }
            //////while dongusu ile Listeleme////
            //int i = 0;
            //while (i < products.Length)
            //{
            //    Console.WriteLine("Product Id: " + products[i].Id + " Product Name: " + products[i].Adi + " Product Category: " + products[i].Kategori + " Product Price: " + products[i].Fiyat + "TL");
            //    i++;
            //}
        }
    }
}
