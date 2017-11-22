using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_WCFservice
{
    public class FactoryBL
    {
        public static IBL getBL()
        {
            return new bl_imp();
        }
    }
}
