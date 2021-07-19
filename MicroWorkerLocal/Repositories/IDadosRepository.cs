using MicroWorkerLocal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroWorkerLocal.Repositories {
    public interface IDadosRepository {
        Task<Dados> GetDados(int gId);
        Task<List<Dados>> GetDadosAll();
        Task<bool> CreateDados(Dados dados);
    }
}
