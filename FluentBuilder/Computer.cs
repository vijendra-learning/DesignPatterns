using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class Computer
    {
        public string _ComputerType { get; set; }
        public string _HardDiskSize { get; set; }
        public string _RAMSize { get; set; }
        public string _OSVersion { get; set; }

        public Computer(string ComputerType, string HardDiskSize, string RAMSize, string OSVersion)
        {
            _ComputerType = ComputerType;
            _HardDiskSize = HardDiskSize;
            _RAMSize = RAMSize;
            _OSVersion = OSVersion;
        }
    }
}
