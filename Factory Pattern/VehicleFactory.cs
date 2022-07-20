using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tireCount)
        {
            switch (tireCount)
            {
                case 2:
                    return new Motorcycle();
                
                case 3:
                    return new OtherCar();
                
                case 4:
                    return new Car();

                default:
                    return new Car();
                    
            }
            
        }
    }
}
