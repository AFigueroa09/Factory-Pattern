using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Classes
{
    internal class Motorcycle: IVehicle
    {
        public int NumberOfWheels { get; }

        public Motorcycle()
        {
            NumberOfWheels = 2;
            Console.WriteLine("Building a Motorcycle!");
        }
    }
}
