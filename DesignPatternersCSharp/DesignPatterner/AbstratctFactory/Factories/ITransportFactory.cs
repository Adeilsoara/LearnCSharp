using AbstratctFactory.Aircraft;
using AbstratctFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratctFactory.Factories {
    interface ITransportFactory {
        IAircraft CreateTransportAircraft();
        ILandvehicle CreateTransportVehicle();
    }
}
