using Catalog.Api.Data;
using Microservices.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.Api.Repositories {
    public class ProductRepository : IProductRepository {
        private readonly IcatalogContext _context;

        public ProductRepository(IcatalogContext context) {
            _context = context;
        }

        public async Task CreateProduct(Product product) {
            throw new System.NotImplementedException();
        }

        public async Task<bool> DeleteProduct(string id) {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName) {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name) {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProducts() {
            throw new System.NotImplementedException();
        }

        public async Task<Product> GetProducts(string id) {
            throw new System.NotImplementedException();
        }

        public async Task<bool> UpdateProduct(Product product) {
            throw new System.NotImplementedException();
        }
    }
}