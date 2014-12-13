using System;

namespace Vehicle.Transport
{
    public abstract class Vehicle
    {
        private string _driverName;
        private int _placeQty;

        protected Vehicle(string driverName, int placeQty)
        {
            DriverName = driverName;
            PlaceQty = placeQty;
        }

        public string DriverName
        {
            get { return _driverName; }
            set
            {
                if (IsDriverNameNotValid(value))
                {
                    return;
                }
                _driverName = value;
            }
        }

        public int PlaceQty
        {
            get { return _placeQty; }
            protected set
            {
                if (value < 1)
                {
                    Console.WriteLine("PlaceQty must be greate or equal 1");
                    return;
                }
                _placeQty = value;
            }
        }

        protected virtual bool IsDriverNameNotValid(string value)
        {
            if (value == "Igor")
            {
                Console.WriteLine("Wrong driver: Irog not supported");
                return true;
            }
            return false;
        }

        public abstract void Drive();
    }
}