using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemoW3HW3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli " + musteri.Id + " ID numarasina sahip musteri basariyla eklenmistir.");
        }
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Asagida Liste Halinde Musteriler gosterilmektedir.");
            Console.WriteLine("---------------------------------------------");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri Adi: " + musteri.Ad + " Musteri Soyadi: " + musteri.Soyad + " Musteri Id: " + musteri.Id + " Musteri TcNo: " + musteri.TcNo);
                Console.WriteLine("********************");
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " ID numarasina sahip " + musteri.Ad + " " + musteri.Soyad + " isimli musteri basariyla silinmistir.");
        }
    }
}
