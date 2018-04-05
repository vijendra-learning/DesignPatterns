using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class ComputerBuilder 
    {
        protected Computer ComputerObject;

        public ComputerBuilder()
        {

        }

        public void CreateNewComputer()
        {
            ComputerObject = new Computer();
        }
        public abstract void SetComputerType();

        public void SetComputerProperties(string hardDiskCapacity, string RAM, string OSVersion)
        {
            ComputerObject.HardDiskSize = hardDiskCapacity;
            ComputerObject.RAMSize = RAM;
            ComputerObject.OSVersion = OSVersion;
        }

        public Computer GetComputer()
        {
            return ComputerObject;
        }
    }
}
