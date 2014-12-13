using System;

namespace Vehicle.Transport
{
    public class Train : Vehicle, IShipping
    {
        public Train(string driverName, int placeQty, int ticketCost, int electricity100Km) : base(driverName, placeQty)
        {
            TicketCost = ticketCost;
            Electricity100Km = electricity100Km;
        }

        public int Electricity100Km { get; protected set; }
        public int TicketCost { get; protected set; }

        public override void Drive()
        {
            Console.WriteLine("Train with cheif {0}. Electricity: {1}. Capacity: {2} passangers",
                DriverName, Electricity100Km, PlaceQty);
        }

        public int ComfortLevel
        {
            get { return 4; }
        }

        public int GetCost(int totalKm)
        {
            return TicketCost;
        }
    }
}