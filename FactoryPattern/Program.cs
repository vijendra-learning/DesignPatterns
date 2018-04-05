using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the vehicle type desired : ");
            string vehicleType = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle vehicleGiven = factory.GetVehicle(vehicleType);
            if (vehicleGiven != null)
                vehicleGiven.GetVehicle();
            else
                Console.WriteLine("Please enter a valid vehicle type");
            Console.ReadLine();
        }
    }
}
