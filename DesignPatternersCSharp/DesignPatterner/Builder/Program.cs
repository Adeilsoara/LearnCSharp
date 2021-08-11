using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();

            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine("Criado um veiculo Sedan");

            Console.ReadLine();

        }
    }
}
