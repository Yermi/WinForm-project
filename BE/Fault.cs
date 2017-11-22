using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BE
{
    //properties of fault
    [DataContract]
    public class Fault
    {
        [DataMember]
        public int License { get; set; }

        [DataMember]
        public DateTime dateOfFault { get; set; }

        [DataMember]
        public typeFault typeOfFault { get; set; }

        [DataMember]
        public bool Negligence { get; set; }

        [DataMember]
        public float Price { get; set; }

        [DataMember]
        public string Garage { get; set; }

        public override string ToString()
        {
            string A;
            A = "License:      " + License.ToString() + '\n';
            A += "date:        " + dateOfFault.ToString() + '\n';
            A += "type:        " + typeOfFault.ToString() + '\n';
            A += "Negligence:  " + Negligence.ToString() + '\n';
            A += "price:       " + Price.ToString() + '\n';
            A += "Garage:      " + Garage.ToString() + '\n';

            return A;
        }
    }
}
