using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.IdentityNumber==12345678910 && gamer.FirstName == "Muhammed Ali" && gamer.LastName == "TUNÇDEMİR")
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
