using _11_Odev5_GameDemo.Abstract;
using _11_Odev5_GameDemo.Entities;
using ServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Odev5_GameDemo.Concreate
{
    public class CustomerManager : ICustomerManager, ICustomerCheckService
    {
        
        public void Add(Customer customer)
        {
            //Mernis Doğrulaması
            if (CheckCustomer(customer))
            {
                Console.WriteLine("Oyuncu eklendi: " + customer.FirstName);
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi: " + customer.FirstName);
            }
            
        }

        public bool CheckCustomer(Customer customer)
        {
            CustomerCheckService customerCheckService = new CustomerCheckService();
            return customerCheckService.CheckCustomer(customer);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Oyuncu güncellendi: " + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Oyuncu silindi: " + customer.FirstName);
        }
        
    }
}
