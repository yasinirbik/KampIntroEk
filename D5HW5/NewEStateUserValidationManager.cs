using System;
using System.Collections.Generic;
using System.Text;

namespace D5HW5GameProject
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true; //bunun false'nu yazmadım çünkü burada sistemdeki değiikliğin projeye entegrasyonu ile ilgilendim.
        }
    }
}
