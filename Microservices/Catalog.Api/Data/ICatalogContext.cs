

using Microservices.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Data {
    public interface IcatalogContext {
        IMongoCollection<Product> Products { get;}
    }
}