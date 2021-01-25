using _11_Odev5_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Odev5_GameDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckCustomer(Customer customer);
    }
}
