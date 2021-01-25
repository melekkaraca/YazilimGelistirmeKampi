using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Odev5_GameDemo.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
