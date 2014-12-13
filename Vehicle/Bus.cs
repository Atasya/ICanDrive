using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Bus
    public class Bus : UrbanTransport
    {
        private int _placesQuantity;

        private int _comfortLevel;

        protected override bool isValidDriverName(string driverName)
        {
            if (driverName.Contains("Vasya"))
            {
                return false;
            }

            return true;
        }

        public Bus(string name, string driverName, int gasolineConsumption, int costPerKm, int placesQuantity, int comfortLevel) //constructor
        {
            _name = name;
            DriverName = driverName;
            _gasolineConsumption = gasolineConsumption;
            _costPerKm = costPerKm;
            _placesQuantity = placesQuantity;
            _comfortLevel = comfortLevel;

        }

        public override void Drive() //method
        {
            Console.WriteLine(String.Format("Bus {0} is Driving by {1}! Gasoline consumption: {2}. Price (1 km): {3}. Places: {4}. Comfort scale: {5}",
                _name, _driverName, _gasolineConsumption, _costPerKm, _placesQuantity, _comfortLevel));
        }


        //quantity of places
        public int PlacesQuantity
        {
            get
            {
                /*
                 additional logic
                 */
                return _placesQuantity;
            }
        }

        //comfort level
        public int ComfortLevel
        {
            get
            {
                /*
                 additional logic
                 */
                return _comfortLevel;
            }
        }

    }
}
