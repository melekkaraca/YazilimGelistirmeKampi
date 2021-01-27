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
            CustomerOperations();
            CampaignOperations();
            GameSaleOperations();
        }

        private static void GameSaleOperations()
        {
            Console.WriteLine("----------------- Oyun Satışlar ------------------");
            GameSaleManager gameSaleService = new GameSaleManager();
            Game game = new Game { Name = "Super Mario" };
            Customer customer = new Customer { FirstName = "Oyuncu 1" };
            Campaign campaign = new Campaign { Name = "%25 İndirim" };
            gameSaleService.Sale(game, customer);
            gameSaleService.SaleOfCampaign(game, customer, campaign);
        }

        private static void CampaignOperations()
        {
            Console.WriteLine("----------------- Kapmanya İşlemleri ------------------");
            Campaign campaign = new Campaign()
            {
                Id = 1,
                Name = "%90 İndirim",
                Discount = 90,
                DeadLine = new DateTime(2021, 01, 27)
            };
            CampaignManager campaignService = new CampaignManager();
            Console.WriteLine("--- Kampanya Ekleme ------------------");
            campaignService.Add(campaign);
            Console.WriteLine("--- Kampanya Güncelleme ------------------");
            campaignService.Update(campaign);
            Console.WriteLine("--- Kampanya Silme ------------------");
            campaignService.Delete(campaign);
        }

        private static void CustomerOperations()
        {
            Console.WriteLine("----------------- Oyuncu İşlemleri ------------------");
            Customer customer = new Customer()
            {
                Id = 1,
                NationalityId = 123,
                FirstName = "Melek",
                LastName = "Karaca",
                DateOfBirth = new DateTime(1988, 4, 23)
            };
            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            Console.WriteLine("--- Oyuncu Ekleme ------------------");
            customerManager.Add(customer);
            Console.WriteLine("--- Oyuncu Güncelleme ------------------");
            customerManager.Update(customer);
            Console.WriteLine("--- Oyuncu Silme ------------------");
            customerManager.Delete(customer);
        }

        private static void CampaignList()
        {
            List<Campaign> campaigns = new List<Campaign>
            {
                new Campaign { Id = 1, Name = "%25 İndirim", DeadLine = new DateTime(2021, 2, 28), Discount = 25 },
                new Campaign { Id = 2, Name = "%5 İndirim", DeadLine = new DateTime(2021, 2, 15), Discount = 5 },
                new Campaign { Id = 3, Name = "%50 İndirim", DeadLine = new DateTime(2021, 1, 29), Discount = 50 }
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
