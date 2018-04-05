using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class VehicleFactory
    {
        public IVehicle GetVehicle(string vehicleType)
        {
            IVehicle vehicle = null;

            switch (vehicleType.ToLower())
            {
                case "car":
                    vehicle = new Car();
                    break;
                case "bike":
                    vehicle = new Bike();
                    break;        
                default:
                    break;
            }

            return vehicle;
        }
    }
}
