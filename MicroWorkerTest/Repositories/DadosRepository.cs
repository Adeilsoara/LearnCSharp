using Microsoft.Extensions.Configuration;
using MicroWorkerTest.Entities;
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

        public Task<bool> CreateDados(Dados dados) {
            throw new NotImplementedException();
        }

        public Task<Dados> GetDados(int gId) {
            throw new NotImplementedException();
        }

        public Task<List<Dados>> GetDadosAll() {
            throw new NotImplementedException();
        }
    }
}
