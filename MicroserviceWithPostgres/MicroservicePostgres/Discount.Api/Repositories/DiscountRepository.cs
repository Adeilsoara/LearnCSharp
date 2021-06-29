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

        public async Task<bool> Notification() {

            NpgsqlConnection connection = GetConnectionPostgreSQL();
            await connection.OpenAsync();

            //e.Payload is string representation of JSON we constructed in NotifyOnDataChange() function
            connection.Notification += (o, e) => Console.WriteLine("Received notification: " + e.Payload);

            await using (var cmd = new NpgsqlCommand("LISTEN datachange;", connection))
                cmd.ExecuteNonQuery();

            while (true)
                connection.Wait();
        }
        private NpgsqlConnection GetConnectionPostgreSQL() {

            return new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
        }
        public async Task<bool> CreateDiscount(Coupon coupon) {
            NpgsqlConnection connection = GetConnectionPostgreSQL();

            var affectted = await connection.ExecuteAsync("INSERT INTO Coupon (ProductName, Description, Amount) VALUES (@ProductName, @Description, @Amount)",
                new { ProductName = coupon.ProductName, Description = coupon.Description, Amount = coupon.Amount });

            if (affectted == 0)
                return false;

            return true;
        }
        public async Task<bool> DeleteDiscount(string productName) {
            NpgsqlConnection connection = GetConnectionPostgreSQL();

            var affectted = await connection.ExecuteAsync("DELETE FROM Coupon WHERE ProductName=@ProductName", new { ProductName = productName });

            if (affectted == 0)
                return false;

            return true;
        }

        public async Task<Coupon> GetDiscount(string productName) {
            NpgsqlConnection connection = GetConnectionPostgreSQL();

            var coupon = await connection.QueryFirstOrDefaultAsync<Coupon>
                ("SELECT * FROM Coupon WHERE ProductName=@ProductName", 
                new { ProductName = productName });

            if (coupon == null)
                return new Coupon { ProductName = "No discount", Amount = 0, Description = "No discount Desc" };

            return coupon;
        }

        public async Task<bool> UpdateDiscount(Coupon coupon) {
            NpgsqlConnection connection = GetConnectionPostgreSQL();

            var affectted = await connection.
                ExecuteAsync("UPDATE Coupon SET ProductName=@ProductName, Description=@Description, Amount=@Amount" +
                " WHERE Id=@Id",
                new { ProductName = coupon.ProductName, Description = coupon.Description, Amount = coupon.Amount, Id = coupon.Id });

            if (affectted == 0)
                return false;

            return true;
        }
    }
}
