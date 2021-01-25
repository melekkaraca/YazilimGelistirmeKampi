using _11_Odev5_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Odev5_GameDemo.Abstract
{
    public interface ICustomerManager
    {
        void Add(Customer customer);
        void Uptate(Customer customer);
        void Delete(Customer customer);
    }
}
