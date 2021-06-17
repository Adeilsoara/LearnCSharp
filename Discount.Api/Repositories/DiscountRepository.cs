using Dapper;
using Discount.Api.Entities;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Api.Repositories {
    public class DiscountRepository : IDiscountRepository {

        private readonly IConfiguration _configuration;

        public DiscountRepository(IConfiguration configuration) {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        private NpgsqlConnection GetConnectionPostgreSQL() {
            return new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
        }

        public async Task<Coupon> GetDiscount(string productName) {
            NpgsqlConnection connection = GetConnectionPostgreSQL();

            var coupon = await connection.QueryFirstOrDefaultAsync<Coupon>
                ("SELECT * FROM Coupon WHERE ProductName = @ProductName", 
                new { ProductName = productName});

            if (coupon == null)
                return new Coupon 
                { ProductName = "No discount", Amount = 0, Description = "No discount Desc" };
           
            return coupon;
        }

        public async Task<bool> CreateDiscount(Coupon coupon) {
            NpgsqlConnection connection = GetConnectionPostgreSQL();
        }

        public async Task<bool> DeleteDiscount(string productName) {
            NpgsqlConnection connection = GetConnectionPostgreSQL();
        }

        public async Task<bool> UpdateDiscount(Coupon coupon) {
            NpgsqlConnection connection = GetConnectionPostgreSQL();
        }
    }
}
