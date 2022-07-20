using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class OtherCar : IVehicle
    {
        public OtherCar()
        {

        }
        public void Drive()
        {
            Console.WriteLine("Lets try again");
        }
    }
}
