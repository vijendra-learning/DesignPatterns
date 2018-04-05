using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DellCompany dellManufacturer = new DellCompany();
            Computer dellLaptop = dellManufacturer.Construct(new Laptop(),"400GB", "8GB", "Windows8");

            Console.WriteLine(dellLaptop.ComputerType + " is built with " 
                                                      + dellLaptop.HardDiskSize + " as hard disk capacity and " 
                                                      + dellLaptop.RAMSize + " as RAM capacity and "
                                                      + dellLaptop.OSVersion + " as Operating System");

           Computer dellDesktop = dellManufacturer.Construct(new Desktop(), "600GB", "6GB", "Windows10");
           Console.WriteLine(dellDesktop.ComputerType + " is built with " 
                                                      + dellDesktop.HardDiskSize + " as hard disk capacity and "
                                                      + dellDesktop.RAMSize + " as RAM capacity and "
                                                      + dellDesktop.OSVersion + " as Operating System");

            Console.ReadLine();
        }
    }
}
