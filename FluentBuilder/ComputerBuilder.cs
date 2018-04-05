using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class ComputerBuilder
    {
        public string _ComputerType { get; set; }
        public string _HardDiskSize { get; set; }
        public string _RAMSize { get; set; }
        public string _OSVersion { get; set; }

        public ComputerBuilder CreateNewComputer(string computerType)
        {
            this._ComputerType = computerType;
            return this;
        }
        public ComputerBuilder WithHardDiskAs(string hardDiskSize)
        {
            this._HardDiskSize = hardDiskSize;
            return this;
        }
        public ComputerBuilder WithRAMSizeAs(string RAMSize)
        {
            this._RAMSize = RAMSize;
            return this;
        }
        public ComputerBuilder WithOSAs(string OSVersion)
        {
            this._OSVersion = OSVersion;
            return this;
        }

        public static implicit operator Computer(ComputerBuilder cb)// CONVERTS OBJECT OF COMPUTERBUILDER TO TYPE COMPUTER
        {
            return new Computer(cb._ComputerType, cb._HardDiskSize, cb._RAMSize, cb._OSVersion);
        }
    }
}
