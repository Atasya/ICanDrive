using System;

namespace Vehicle.Transport
{
    public class Bike : Vehicle
    {
        public Bike(string driverName, int placeQty)
            : base(driverName, placeQty)
        {
        }

        public int GasolinePer100Km { get; protected set; }

        public override void Drive()
        {
            Console.WriteLine(
                "Common bike of {0}. Info: consumption - {1} liter of gas per 100 km; capacity: {2} passangers",
                DriverName, GasolinePer100Km, PlaceQty);
        }
    }
}