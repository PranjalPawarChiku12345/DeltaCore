using System.Collections.Generic;

namespace DeltaCore.Models
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1001, Name = "Tools", Description = "Gear tools production specification" },
                new Product { Id = 2001, Name = "Panels", Description = "Switch Gear Panels" },
                new Product { Id = 2008, Name = "DocTonar", Description = "Document Solar Objects" }
            };

            return products;
        }
    }
}