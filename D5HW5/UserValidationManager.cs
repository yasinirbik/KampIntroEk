using System;
using System.Collections.Generic;
using System.Text;

namespace D5HW5GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "Engin" && gamer.LastName == "Demiroğ" && gamer.IdentityNumber ==  "11111")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
