using _11_Odev5_GameDemo.Abstract;
using _11_Odev5_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Odev5_GameDemo.Concreate
{
    public class CampaignService : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }
    }
}
