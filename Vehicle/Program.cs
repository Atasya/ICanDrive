using System;
using System.Collections.Generic;
using Vehicle.Transport;

namespace Vehicle
{
    internal class Program
    {
        private static readonly List<Transport.Vehicle> Transport = new List<Transport.Vehicle>();

        //private static void DriveAll()
        //{
        //    foreach (var urbanTransports in Transport)
        //    {
        //        urbanTransports.Drive();
        //    }
        //}

        public static void Main(string[] args)
        {
            Taxi carTaxi = new Taxi("Natalia", 4, 12, 5);
            Transport.Vehicle carTaxi2 = new Taxi("Lucya", 3, 7, 5);
            Car carTaxi3 = new Taxi("Boris", 4, 10, 6);

            var bus = new Bus("Natalia", 24, 20, 3);
            var bus2 = new Bus("Kolya", 8, 20, 800);

            var intercity = new Train("Fedya", 300, 500, 30000);
            var intercity2 = new Train("Simon", 200, 200, 40000);
            intercity.DriverName = "Igor";

            Transport.Add(carTaxi);
            Transport.Add(bus);
            Transport.Add(intercity);
            Transport.Add(carTaxi2);
            Transport.Add(carTaxi3);
            Transport.Add(bus2);
            Transport.Add(intercity2);

            Transport.Add(new Car("Tolyan", 8, 10));
            Transport.Add(new Car("Risya", 4, 9));
            Transport.Add(new Bicycle("Tusya", 1));
            Transport.Add(new Bicycle("Tusya & Boris", 2));
            Transport.Add(new Bike("Zosya", 1));

            foreach (Transport.Vehicle transport in Transport)
            {
                transport.Drive();

                IShipping shipping = transport as IShipping;
                if (shipping == null)
                {
                    Console.WriteLine("Not Shipping. Skip");
                    continue;
                }

                if (shipping.ComfortLevel < 4)
                {
                    Console.WriteLine("Small Comfort level. Skip");
                    continue;
                }


                int cost = shipping.GetCost(50);
                if (cost > 250)
                {
                    Console.WriteLine("Too expencive: {0}. Skip", cost);
                    continue;
                }

                Console.WriteLine("Go. Trip cost: {0}", cost);
            }

            //DriveAll();



            Console.ReadLine();
        }
    }
}