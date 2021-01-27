using _11_Odev5_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Odev5_GameDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
