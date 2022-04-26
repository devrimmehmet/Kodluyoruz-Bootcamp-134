using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Business
{
    
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            var products = new List<Product>
            {
                new Product{ Id = 1, Name ="Product 1", Price=100,CategoryId=1,Description="Product 1 description",ImageUrl="https://placehold.it/300x300"},
                new Product{ Id = 2, Name ="Product 2", Price=200,CategoryId=1,Description="Product 2 description",ImageUrl="https://placehold.it/300x300"},
                new Product{ Id = 3, Name ="Product 3", Price=300,CategoryId=1,Description="Product 3 description",ImageUrl="https://placehold.it/300x300"},
                new Product{ Id = 4, Name ="Product 4", Price=400,CategoryId=1,Description="Product 4 description",ImageUrl="https://placehold.it/300x300"},
                new Product{ Id = 5, Name ="Product 5", Price=500,CategoryId=1,Description="Product 5 description",ImageUrl="https://placehold.it/300x300"}
            };
        }
        public List<Product> GetAll()
        {
            return products;
        }
    }
}
