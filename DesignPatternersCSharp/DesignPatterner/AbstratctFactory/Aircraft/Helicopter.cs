using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratctFactory.Aircraft {
    class Helicopter : IAircraft {
        public void CheckWind() {
            Console.WriteLine("Verificando o Vento");
        }

        public void GetCargo() {
            Console.WriteLine("Passageiros a bordo");
        }

        public void StartRoute() {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem...");  
        }
    }
}
