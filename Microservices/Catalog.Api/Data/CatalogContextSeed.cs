using Microservices.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Catalog.Api.Data {
    public class CatalogContextSeed {
        public static void SeedData(IMongoCollection<Product> productCollection) {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct) {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts() {
            return new List<Product>() {
                new Product() {
                    Id = "507f1f77bcf86cd799439011",
                    Name = "Iphone X2",
                    Description = "afffdfdafa",
                    Category = "Smartphone",
                    Image = "iphone.png",
                    Price = 3500
                },
                new Product() {
                    Id = "507f1f77bcf86cd799433411",
                    Name = "Iphone 12",
                    Description = "afffdfdafa",
                    Category = "Smartphone",
                    Image = "iphone12.png",
                    Price = 4500
                }
            };
        }
    }
}