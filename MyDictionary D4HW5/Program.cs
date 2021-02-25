using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary_D4HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("Yasin", 20);
            myDictionary.Add("Engin", 35);
            myDictionary.Add("Somebody", 26);
            myDictionary.Remove("Yasin");
            foreach (var deger in myDictionary)
            {
                Console.WriteLine(deger);
            }
            Console.WriteLine();
            int ElemanSayisi = myDictionary.Count();
            Console.WriteLine("Eleman sayisi: " + ElemanSayisi);
        }
    }
}
