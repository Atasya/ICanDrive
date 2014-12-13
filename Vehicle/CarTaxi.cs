using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    //CarTaxi
    public class CarTaxi : UrbanTransport
    {


        private int _comfortLevel;

        protected override bool isValidDriverName(string driverName)
        {
            if (driverName.Contains("Igor"))
            {
                return false;
            }

            return true;
        }

        public CarTaxi(string name, string driverName, int gasolineConsumption, int costPerKm, int comfortLevel) //constructor
        {
            _name = name;
            DriverName = driverName;
            _gasolineConsumption = gasolineConsumption;
            _costPerKm = costPerKm;
            _comfortLevel = comfortLevel;
        }

        public override void Drive() //method
        {
            Console.WriteLine(String.Format("Taxi {0} is Driving by {1}! Gasoline consumption: {2}. Price (1 km): {3}. Comfort scale: {4}",
                _name, _driverName, _gasolineConsumption, _costPerKm, _comfortLevel));
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
