using ConectarBancoPostgre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConectarBancoPostgre.Repositories {
    public interface IDadosRepository {
        Task<Dados> GetDados(int gId);
        Task<List<Dados>> GetDadosAll();
        Task<bool> CreateDados(Dados dados);
    }
}
