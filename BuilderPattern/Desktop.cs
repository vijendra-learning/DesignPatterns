using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Desktop : ComputerBuilder
    {
      
        public override void SetComputerType()
        {
            ComputerObject.ComputerType = "Desktop";
        }

     
    }
}
