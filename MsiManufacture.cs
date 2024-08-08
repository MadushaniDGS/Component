using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace componentGpu
{
    public class MsiManufacture : Company
    {
        public override Component CreateComponent(string type)
        {
            if(type == "gpu")
            {
                return new MsiGpu();
            }
            else
            {
                return new MsiMoniter();
            }
        }
    }
}
