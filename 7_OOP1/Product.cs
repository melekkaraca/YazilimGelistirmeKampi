using System;
using System.Collections.Generic;
using System.Text;

namespace _7_OOP1
{
    public class Product
    {
        //prop : snippet
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
