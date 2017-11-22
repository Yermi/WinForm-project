using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    // get the implemation of the Logical layer
    public class FactoryBL
    {
        public static IBL getBL()
        {
            return new bl_imp();
        }
    }
}
