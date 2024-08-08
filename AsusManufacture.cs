using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace componentGpu
{
    internal class AsusManufacture : Company
    {
        public override Component CreateComponent(string type)
        {
            if (type == "gpu")
            {
                return new AsusGpu();
            }
            else
            {
                return new AsusMoniter();
            }
        }
    }
}
