using AbstratctFactory.Aircraft;
using AbstratctFactory.Factories;
using AbstratctFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratctFactory.App {
    class Application {
        private IAircraft aircraft;
        private ILandvehicle landvehicle; 

        public Application(ITransportFactory factory) {
            aircraft = factory.CreateTransportAircraft();
            landvehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute() {
            landvehicle.StartRoute();
            aircraft.StartRoute();
        }

    }
}
