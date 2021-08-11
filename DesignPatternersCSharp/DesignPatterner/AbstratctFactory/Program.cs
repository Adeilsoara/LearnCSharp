using AbstratctFactory.App;
using AbstratctFactory.Factories;
using System;

namespace AbstratctFactory {
    class Program {

        static Application ConfigureApplication() {
            Application app;

            ITransportFactory transportFactory;

            string company = "Uber";
            if (company == "Uber") {
                transportFactory = new UberTransport();
            }
            else {
                transportFactory = new NineNineTransport();
            }

            app = new Application(transportFactory);
            return app;
        }
        static void Main(string[] args) {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
