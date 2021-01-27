using _11_Odev5_GameDemo.Abstract;
using _11_Odev5_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Odev5_GameDemo.Concreate
{
    public class GameSaleService : IGameSaleService
    {
        public void Sale(Game game, Customer customer)
        {
            Console.WriteLine("Oyuncu: " + customer.FirstName + " " + game.Name + " oyununu satın aldı.");
        }

        public void SaleOfCampaign(Game game, Customer customer, Campaign campaign)
        {
            Console.WriteLine("Oyuncu: " + customer.FirstName +" "+ game.Name + " oyununu " + campaign.Name +" kampanyası ile satın aldı.");
        }
    }
}
