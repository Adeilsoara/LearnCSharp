using MicroWorkerTest2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroWorkerTest2.Repositories {
    public interface IDadosRepository2 {
        Task<Dados2> DeleteDados(int gId);
        Task<bool> CreateDados(Dados2 dados);
    }
}
