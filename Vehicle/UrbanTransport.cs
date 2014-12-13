using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class UrbanTransport : Vehicle
    {
        protected string _name; //field
        protected int _gasolineConsumption; //field

        public int GasolineConsumption
        {
            get
            {
                /*
                 additional logic
                 */
                return _gasolineConsumption;
            }
        }

        //cost per kilometer

        protected int _costPerKm; //field

        public int CostPerKm
        {
            get
            {
                /*
                 additional logic
                 */
                return _costPerKm;
            }
        }

        protected string _driverName; //field
        public string DriverName
        {
            get
            {
                /*
                 additional logic
                 */
                return _driverName;
            }
            set
            {
                //if (isValidDriverName(value) == false)
                if (!isValidDriverName(value))
                {
                    Console.WriteLine(String.Format("Can't change driver on {0}!", value));
                    return;
                }

                _driverName = value;
                Console.WriteLine(String.Format("Driver was changed at {0}", DateTime.Now));
            }
        }

        protected abstract bool isValidDriverName(string driverName);

        public virtual void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
