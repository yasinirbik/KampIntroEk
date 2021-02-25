using System;

namespace ClassMethodDemoW3HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1245;
            musteri1.Ad = "Mukerrem Semiha";
            musteri1.Soyad = "Tuncdiz";
            musteri1.TcNo = "4578654153247";
            Musteri musteri2 = new Musteri();
            musteri2.Id = 3037;
            musteri2.Ad = "Sabahattin";
            musteri2.Soyad = "Yusufcuk";
            musteri2.TcNo = "53341653554";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteriler);
            Console.WriteLine("//////////////Ekleme islemi/////////////");
            musteriManager.Ekle(musteri1);
            Console.WriteLine("/////////////Silme islemi///////////////");
            musteriManager.Sil(musteri2);
        }
    }
}
