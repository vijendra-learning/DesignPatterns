using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class DellCompany
    {
        public Computer Construct(ComputerBuilder computerBuilder, string hardDiskSize, string RAMSize, string OSVersion)
        {
            computerBuilder.CreateNewComputer();
            computerBuilder.SetComputerType(); // SETTING SPECIFIC PROPERTIES OF CONCRETE CLASSES
            computerBuilder.SetComputerProperties(hardDiskSize, RAMSize, OSVersion); // SETTING COMMON PROPERTIES
            return computerBuilder.GetComputer();
        }
    }
}
