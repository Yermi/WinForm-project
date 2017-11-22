using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BE
{
    //properties of drivers
    [DataContract]
    public class Drivers
    {
        [DataMember]
        public int ID_firstDriver { get; set; }

        [DataMember]
        public String name_firstDriver { get; set; }

        [DataMember]
        public int ID_secendDriver { get; set; }

        [DataMember]
        public String name_secendDriver { get; set; }

        // ToString function
        public override string ToString()
        {
            string A;
            A = "first driver ->   Id: " + ID_firstDriver.ToString() + " || name: " + name_firstDriver.ToString() + '\n';
            if (ID_secendDriver != 9999999)
            {
                A += "secend driver ->  Id: " + ID_secendDriver.ToString() + " || name: " + name_secendDriver.ToString() + '\n';
            }

            return A;
        }
    }
}
