using System;

namespace Vehicle.Transport
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string driverName, int placeQty)
            : base(driverName, placeQty)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Common car of {0}. Capacity: {1} passangers",
                DriverName, PlaceQty);
        }
    }
}