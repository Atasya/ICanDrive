using System;

namespace Vehicle.Transport
{
    public class Bus : Vehicle, IShipping
    {
        public Bus(string driverName, int placeQty, int gasolinePer100Km, int ticketCost)
            : base(driverName, placeQty)
        {
            GasolinePer100Km = gasolinePer100Km;
            TicketCost = ticketCost;
        }

        public int GasolinePer100Km { get; protected set; }
        public int TicketCost { get; protected set; }


        public override void Drive()
        {
            Console.WriteLine(
                "Big bus with Driver: {0}. Ticket cost: {1}. Info: consumption - {2} liter of gas per 100 km; capacity: {3} passangers",
                DriverName, TicketCost, GasolinePer100Km, PlaceQty);
        }

        public int ComfortLevel
        {
            get { return 3; }
        }

        public int GetCost(int totalKm)
        {
            return TicketCost;
        }
    }
}