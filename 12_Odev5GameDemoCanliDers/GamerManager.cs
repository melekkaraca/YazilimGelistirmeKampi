﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Odev5GameDemoCanliDers
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Oyuncu eklendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi.");
        }
    }
}
