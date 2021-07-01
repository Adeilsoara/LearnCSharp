using ConectarBancoPostgre.Entities;
using Microsoft.Extensions.Configuration;
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

        public async Task<Dados> GetDados(int gId) {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateDados(Dados dados) {
            throw new NotImplementedException();
        }

    }
}
