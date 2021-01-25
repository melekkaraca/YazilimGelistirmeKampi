using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Odev5_GameDemo.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
