using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var vehicles = new List<Vehicle>();

            Vehicle Tesla = new Car()
            {
                Year = "2022",
                Make = "Tesla",
                Model = "Model 3",
                HasTrunk = true,
                Doors = 2
            };
            vehicles.Add(Tesla);

            Vehicle Yamaha = new Motorcycle()
            {
                Year = "2023",
                Make = "Yamaha",
                Model = "YZF-R6",
                HasSideCart = false,
                Passengers = 2
            };
            vehicles.Add(Yamaha);

            Vehicle genericCar = new Car();
            vehicles.Add(genericCar);

            Vehicle genericMotorcycle = new Motorcycle();
            vehicles.Add(genericMotorcycle);

            foreach(var vehicle in vehicles)
            {
                vehicle.ListTheProperties();
                Console.WriteLine();
            }

            Tesla.DriveAbstract();
            Tesla.DriveVirtual();

            Console.WriteLine();

            Yamaha.DriveAbstract();
            Yamaha.DriveVirtual();

        }
    }
}
