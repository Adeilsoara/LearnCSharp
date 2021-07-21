using MicroWorkerTest2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroWorkerTest2.Repositories {
    public class DadosRepository2 : IDadosRepository2 {


        public Task<bool> CreateDados(Dados2 dados) {
            throw new NotImplementedException();
        }

        public Task<Dados2> DeleteDados(int gId) {
            throw new NotImplementedException();
        }
    }
}
