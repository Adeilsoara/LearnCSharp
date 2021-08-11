using AbstratctFactory.Aircraft;
using AbstratctFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratctFactory.Factories {
    class NineNineTransport : ITransportFactory {
        public IAircraft CreateTransportAircraft() {
            return new Helicopter();
        }

        public ILandvehicle CreateTransportVehicle() {
            return new Motocycle();
        }
    }
}
