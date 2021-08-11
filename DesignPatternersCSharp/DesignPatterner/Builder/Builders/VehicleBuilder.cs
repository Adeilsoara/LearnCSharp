using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders {
    class VehicleBuilder : IBuilder {

        private Vehicle vehicle = new Vehicle(); 
        public Vehicle GetVehicle() {
            Vehicle result = vehicle;
            Reset();
            return result;
        }

        public void Reset() {
            vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine) {
            vehicle.Engine = engine;
        }

        public void SetSeats(int seats) {
            vehicle.Seats = seats;
        }

        public void SetTramission(Tramission tramission) {
            vehicle.Tramission = tramission;
        }

        public void SetVehicleType(VehicleType vehicleType) {
            vehicle.VehicleType = vehicleType;  
        }
    }
}
