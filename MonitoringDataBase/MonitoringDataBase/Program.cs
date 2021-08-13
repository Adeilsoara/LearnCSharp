using Npgsql;
using System;
using System.Threading.Tasks;

namespace MonitoringDataBase {
    class Program {
        static async Task Main(string[] args) {
            const string connString = "Server=localhost;Port=5432;Database=teste;User Id=postgres;Password=admin;";
            await using var conn = new NpgsqlConnection(connString);
            await conn.OpenAsync();

            conn.Notification += (o, e) => Console.WriteLine("Receiveid notification:" + e.Payload);

            await using (var cmd = new NpgsqlCommand("Listen datachange;", conn)) 
                cmd.ExecuteNonQuery();

            while (true)
                conn.Wait();
        }
    }
}
