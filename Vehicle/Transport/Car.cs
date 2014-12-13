using System;

namespace Vehicle.Transport
{
    public class Car : Vehicle
    {
        public Car(string driverName, int placeQty, int gasolinePer100Km)
            : base(driverName, placeQty)
        {
            GasolinePer100Km = gasolinePer100Km;
        }

        public int GasolinePer100Km { get; protected set; }

        public override void Drive()
        {
            Console.WriteLine(
                "Common car of {0}. Info: consumption - {1} liter of gas per 100 km; capacity: {2} passangers",
                DriverName, GasolinePer100Km, PlaceQty);
        }
    }
}