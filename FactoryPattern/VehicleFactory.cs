using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Classes;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfWheels)
        {
            switch (numberOfWheels)
            {
                case 4:
                    return new Car();
                case 2:
                    return new Motorcycle();
                default:
                    throw new ArgumentException("Please provide valid number of wheels. 2 or 4");
            }
            
        }
    }
}
