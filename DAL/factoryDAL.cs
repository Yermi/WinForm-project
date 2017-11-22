using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // get the implemation of the datasource
    public class factoryDAL
    {
        public static idal getDAL()
        {
            DAL_imp_XML dalXML = new DAL_imp_XML();
            dalXML.DAL_imp_XMLInit();
            return dalXML;
        }
    }
}
