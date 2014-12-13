using System;

namespace Vehicle.Transport
{
    public class Taxi : Car, IShipping
    {
        public Taxi(string driverName, int placeQty, int gasolinePer100Km, int kmCost)
            : base(driverName, placeQty, gasolinePer100Km)
        {
            KmCost = kmCost;
        }

        public int KmCost { get; protected set; }

        public int ComfortLevel
        {
            get { return 5; }
        }

        public int GetCost(int totalKm)
        {
            return totalKm*KmCost;
        }

        public override void Drive()
        {
            Console.WriteLine(
                "Taxi car of {0}. Info: consumption - {1} liter of gas per 100 km; capacity: {2} passangers; UAH per Km: {3}",
                DriverName, GasolinePer100Km, PlaceQty, KmCost);
        }
    }
}