using FactoryPattern.Interfaces;
using FactoryPattern.Classes;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Get user value
            Console.WriteLine("How many wheels does your vehicle have?");
            var numberOfWheels = Console.ReadLine();

            // Validate User input
            if (numberOfWheels == null || numberOfWheels == "")
            {
                throw new NullReferenceException("Please provide a numerical value and try again.");
            }

            var isInputValid = int.TryParse(numberOfWheels, out var vehicleNumber);
            if (isInputValid != false)
            { 
                // Input is valid get Vehicle
                IVehicle vehicle = VehicleFactory.GetVehicle(vehicleNumber);

            } else
            {
                throw new NullReferenceException("Please provide a numerical value and try again.");
            }

        }
    }
}
