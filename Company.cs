using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace componentGpu
{
   public abstract class Company
    {
        public Component AssembleComponent(string type)
        {
            Component component = CreateComponent(type);
            component.Assemble();
            return component;
        }
        public abstract Component CreateComponent(string type);
    }
}
