using _11_Odev5_GameDemo.Concreate;
using _11_Odev5_GameDemo.Entities;
using System;
using System.Collections.Generic;

namespace _11_Odev5_GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GameList();
            CampaignList();
            Customer customer = new Customer()
            {
                Id = 1,
                NationalityId = 123,
                FirstName = "Melek",
                LastName = "Karaca",
                DateOfBirth = new DateTime(1988, 4, 23)
            };
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("----------------- Oyuncu Ekleme ------------------");
            customerManager.Add(customer);
            Console.WriteLine("----------------- Oyuncu Güncelleme ------------------");
            customerManager.Uptate(customer);
            Console.WriteLine("----------------- Oyuncu Silme ------------------");
            customerManager.Delete(customer);

        }

        private static void CampaignList()
        {
            List<Campaign> campaigns = new List<Campaign>
            {
                new Campaign { Id = 1, Name = "%25 Discount", DeadLine = new DateTime(2021, 2, 28), Discount = 25 },
                new Campaign { Id = 2, Name = "%5 Discount", DeadLine = new DateTime(2021, 2, 15), Discount = 5 },
                new Campaign { Id = 3, Name = "%50 Discount", DeadLine = new DateTime(2021, 1, 29), Discount = 50 }
            };
            Console.WriteLine("----------------- Kampanyalar ------------------");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("Kampanya adı: " + campaign.Name + " - İndirim Oranı: %" + campaign.Discount + " - Kampanya bitiş tarihi" + campaign.DeadLine.ToShortDateString());
            }
        }

        private static void GameList()
        {
            List<Game> games = new List<Game>
            {
                new Game { Id = 1, Name = "World Craft", Price = 500 },
                new Game { Id = 2, Name = "World Craft 2", Price = 650 },
                new Game { Id = 3, Name = "Super Mario", Price = 55 },
                new Game { Id = 4, Name = "Magic Piano Tiles", Price = 25 },
                new Game { Id = 5, Name = "Fruit Slice", Price = 30 }
            };
            Console.WriteLine("----------------- Oyunlar ------------------");
            foreach (var game in games)
            {
                Console.WriteLine("Oyun adı: " + game.Name + " - Fiyatı: " + game.Price);
            }
        }
    }

}
