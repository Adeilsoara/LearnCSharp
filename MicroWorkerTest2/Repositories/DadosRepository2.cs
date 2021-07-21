using Dapper;
using Microsoft.Extensions.Configuration;
using MicroWorkerTest2.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroWorkerTest2.Repositories {
    public class DadosRepository2 : IDadosRepository2 {

        private readonly IConfiguration _configuration;

        public DadosRepository2(IConfiguration configuration) {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        private NpgsqlConnection GetConnectionStringSQL() {
            return new NpgsqlConnection(_configuration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));
        }

        public async Task<bool> CreateDados(Dados2 dados) {
            NpgsqlConnection connection = GetConnectionStringSQL();
            var affectted = await connection.ExecuteAsync("INSERT INTO ponto_importado_corrigido (gid, endereco) VALUES (@gid, @endereco)",
               new { GId = dados.GId, Endereco = dados.Endereco });

            if (affectted == 0)
                return false;

            return true;
        }

        public Task<Dados2> DeleteDados(int gId) {
            throw new NotImplementedException();
        }
    }
}
