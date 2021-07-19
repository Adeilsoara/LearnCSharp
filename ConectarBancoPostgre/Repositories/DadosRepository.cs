using ConectarBancoPostgre.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConectarBancoPostgre.Repositories {
    public class DadosRepository : IDadosRepository {

        private readonly IConfiguration _configuration;

        public DadosRepository(IConfiguration configuration) {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        private NpgsqlConnection GetConnectionStringSQL() {
            
            return new NpgsqlConnection(_configuration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));
        }
  
        public async Task<Dados> GetDados(int gId) {
            // using var connection = new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            NpgsqlConnection connection = GetConnectionStringSQL();
            string query = "SELECT * FROM ponto_importado_corrigido WHERE gid = @gId";
            Dados dados = await connection.QueryFirstOrDefaultAsync<Dados>(sql: query, param: new { gId});

            return dados;
        }

        public async Task<bool> CreateDados(Dados dados) {
            throw new NotImplementedException();
        }

        public async Task<List<Dados>> GetDadosAll() {
            //using var connection = new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            NpgsqlConnection connection = GetConnectionStringSQL();
            string query = "SELECT gid, endereco FROM ponto_importado_corrigido LIMIT 5; ";
            List<Dados> lista = (await connection.QueryAsync<Dados>(sql: query)).ToList();
            return lista;
        }
    }
}
