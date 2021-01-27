using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Odev5GameDemoCanliDers
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer); 
    }
}
