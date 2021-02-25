using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1-) Dictionary sınıfı içinde sizin belirleyeceiğiniz bir key'e uygun olarak deger saklama zırunluluğu vardır.
             2-) key türünü belirlemeniz şart.
             */

            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //veri ekliyoruz,
            AdYas.Add("Amy", 25);
            AdYas.Add("Mehmet", 17);
            AdYas.Add("Birisi", 30); ;
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);

            }
            //deger sayma özelliği vardır.
            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("eleman sayısı: "+ eleman);
            //silme işlemide vardır.
            AdYas.Remove("Birisi");
            Console.WriteLine();
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);

            }
            var YeniEleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("Yeni Eleman sayısı: " + YeniEleman);

            Console.ReadLine();
        }
    }
}
