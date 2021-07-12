using Microsoft.Extensions.Configuration;
using MicroWorkerTest.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroWorkerTest.Repositories {
    public class DadosRepository : IDadosRepository {

        private readonly IConfiguration _configuration;

        public DadosRepository(IConfiguration configuration) {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        private NpgsqlConnection GetConnectionStringSQL() {
            return new NpgsqlConnection(_configuration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));
        }
        public async Task<bool> CreateDados(Dados dados) {
            throw new NotImplementedException();
        }

        public async Task<Dados> GetDados(int gId) {
            throw new NotImplementedException();
        }

        public async Task<List<Dados>> GetDadosAll() {
            throw new NotImplementedException();
        }
    }
}
