using System;
using System.Collections.Generic;
using System.Text;

namespace D5HW5GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService; //Constructor
        public GamerManager(IUserValidationService userValidationService)//Gamer manager'in içinde doğrulamayı yapıyoruz
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Olundu.");
            }
            else
            {
                Console.WriteLine("Dogrulama Basarisiz, Kayit Basarisiz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }
    }

}
