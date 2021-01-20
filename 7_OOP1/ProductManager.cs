using System;
using System.Collections.Generic;
using System.Text;

namespace _7_OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            product.Id = 1;
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi.");
        }
        public List<Product> Products(Product product)
        {
            List<Product> products = new List<Product>();

            return products;
        }
        
    }
}
