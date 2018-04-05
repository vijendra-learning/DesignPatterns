﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Car : IVehicle
    {
        public void GetVehicle()
        {
            Console.WriteLine("This is a car !");
        }
    }
}
