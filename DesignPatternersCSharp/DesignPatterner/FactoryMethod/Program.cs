using FactoryMethod.Factory;
using System;

namespace FactoryMethod {
    class Program {
        static void Main(string[] args) {

            Transport transport = null;

            if (args.Length > 0 && args[0] == "--uber") {
                transport = new CarTransport();
            }
            else if (args.Length > 0 && args[0] == "--log"){
                transport = new MotoCycleTransport();
            }
            else {
                Console.WriteLine("selecione o tipo do serviço");
            }

            if (transport != null) {
                transport.StartTransport();
            }
        }
    }
}
