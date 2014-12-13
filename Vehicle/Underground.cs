using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Underground : ICanDrive
    {
        public void Drive()
        {
            Console.WriteLine("Underground! {0}", _comfortLevel);
        }

        public Underground(int comfortLevel) //constructor
        {
            _comfortLevel = comfortLevel;

        }

        private int _comfortLevel;

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
