using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;
using SuperShop105.Data.Entities;

namespace SuperShop105.Data

{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Product 1", Price = 10 });
            products.Add(new Product { Id =2, Name = "Product 2", Price = 20 });
            products.Add(new Product {Id = 3, Name = "Product 3", Price = 30 });
            products.Add(new Product {Id = 4, Name = "Product 4", Price = 40 });
            products.Add(new Product {Id = 5, Name = "Product 5", Price = 50 });

            return products;

        }

        public bool ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
