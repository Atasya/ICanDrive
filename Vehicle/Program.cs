using ConsoleApplication1;
using OOP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public static ICanDrive iCanDriveInstance { get; set; }


        private static List<ICanDrive> UrbanTransport = new List<ICanDrive>();
//        private static ArrayList vehicles_al = new ArrayList();
/*        private static void driveAll()
        {
            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
            }
        }*/

        private static void driveAll()
        {
            foreach (ICanDrive urbanTransports in UrbanTransport)
            {
                urbanTransports.Drive();
            }
        }

        static void Main(string[] args)
        {
            var cartaxi = new CarTaxi("BMW X9", "Natalia", 8, 100, 5);
            var bus = new Bus("Volvo", "Natalia", 15, 100, 20, 3);

            var subway = new Underground(4);

            /*vehicles.Add(car);
            vehicles.Add(bus);
            vehicles.Add(subway);*/

            UrbanTransport.Add(carTaxi);
            urbanTransports.Add(bus);

            driveAll();

/*            var car = new Car("BMW X9", "Natalia", 8, 100);
            car.Drive();

            string driver = car.DriverName;
            Console.WriteLine(car.DriverName);

            car.DriverName = "Igor";
            Console.WriteLine(car.DriverName);

            car.DriverName = "Boris";
            Console.WriteLine(car.DriverName);

            var bus = new Bus("Volvo", "Natalia", 15, 100, 20);
            bus.Drive();

            Console.WriteLine(bus.DriverName);

            bus.DriverName = "Vasya";
            Console.WriteLine(bus.DriverName);

            bus.DriverName = "Boris";
            Console.WriteLine(bus.DriverName);*/

            Console.ReadLine();

        }
    }
}
