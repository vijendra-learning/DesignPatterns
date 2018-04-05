using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{

    // Builder Pattern - To create a new object it may be needed to pass huge number of parameters. To avoid this we can use Fluent Builder API.
    class Program
    {
        static void Main(string[] args)
        {
            ComputerBuilder builder = new ComputerBuilder();
            Computer dellLaptop = builder.CreateNewComputer("Laptop")
                                         .WithHardDiskAs("500 GB")
                                         .WithRAMSizeAs("6 GB")
                                         .WithOSAs("Windows 8");
                                         

            Console.WriteLine(dellLaptop._ComputerType + " is built with "
                                                       + dellLaptop._HardDiskSize + " as hard disk capacity and "
                                                       + dellLaptop._RAMSize + " as RAM capacity and "
                                                       + dellLaptop._OSVersion + " as Operating System");

            Console.ReadLine();
        }
    }
}
