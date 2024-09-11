using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes
{
    internal class Car: IVehicle
    {
        public int NumberOfWheels { get; }

        public Car()
        {
            NumberOfWheels = 4;
            Console.WriteLine("Building a Car!");
        }
    }
}
