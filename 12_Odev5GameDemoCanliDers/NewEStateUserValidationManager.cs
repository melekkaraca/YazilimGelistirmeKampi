using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Odev5GameDemoCanliDers
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
