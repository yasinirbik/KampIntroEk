using System;

namespace D5HW5GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            //Eğer ki yeni bir edevlet doğrulama sistemi olsaydı yalnızca 9. satırın yerini 10. satır alır proje sorunsuz devam ederdi.
            gamerManager.Add(new Gamer {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                BirthYear = 1985, 
                IdentityNumber = "11111"
            });
            //BU ÖDEVİ DEVAM ETTİR. DAHA YARISI BİLE BİTMEDİ SAYILIR.
        }
    }
}
