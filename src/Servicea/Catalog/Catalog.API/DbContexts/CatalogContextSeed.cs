using Catalog.API.Entities;
using MongoDB.Driver;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.DbContexts
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> ProductCollection)
        {
            bool existProduct = ProductCollection.Find(p => true).Any();
            if (!existProduct)
            {
                ProductCollection.InsertMany(GetPreConfigureProduct());
            }
        }

        private static IEnumerable<Product> GetPreConfigureProduct()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "1",
                    Name = "IPhone X",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "2",
                    Name = "Samsung 10",
                    Price = 840.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "3",
                    Name = "Huawei Plus",
                    Price = 650.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Id = "4",
                    Name = "Xiaomi Mi 9",
                    Price = 470.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Id = "5",
                    Name = "HTC U11+ Plus",
                    Price = 380.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "6",
                    Name = "LG G7 ThinQ",
                    Price = 240.00M,
                    Category = "Home Kitchen"
                }
            };
        }
    }
}