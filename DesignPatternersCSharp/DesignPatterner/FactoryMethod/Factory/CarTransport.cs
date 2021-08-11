using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory {
    class CarTransport : Transport{
        protected override IVehicle CreateTransport() {
            return new Car();
        }
    }
}
