using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BE
{
    // properties of renting
    [DataContract]
    public class Renting
    {
        [DataMember]
        public int Booking { get; set; }

        [DataMember]
        public DateTime start { get; set; }

        [DataMember]
        public DateTime end { get; set; }

        [DataMember]
        public Drivers drivers { get; set; }

        [DataMember]
        public int CarLicense { get; set; }

        [DataMember]
        public int numOfDrivers { get; set; }

        [DataMember]
        public int KM_start { get; set; }

        [DataMember]
        public int KM_end { get; set; }

        [DataMember]
        public int total_KM { get; set; }

        [DataMember]
        public string statusOfRenting { get; set; }

        [DataMember]
        public bool fault { get; set; }

        [DataMember]
        public float price { get; set; }


        // ToString function
        public override string ToString()
        {
            string A;
            A =  "number of booking:     " + Booking.ToString() + '\n';
            A += "Start Date:            " + start.ToString() + '\n';
            A += "End Date:              " + end.ToString() + '\n';
            A += "ID main driver:        " + drivers.ID_firstDriver.ToString() + '\n';
            A += "name main driver:      " + drivers.name_firstDriver.ToString() + '\n';
            A += "ID secend driver:      " + drivers.ID_secendDriver.ToString() +'\n';
            A += "name secend driver:    " + drivers.name_secendDriver.ToString() +'\n';
            A += "license:               " + CarLicense.ToString() + '\n';
            A += "number of drivers:     " + numOfDrivers.ToString() + '\n';
            A += "start KM:              " + KM_start.ToString() + '\n';
            A += "end KM:                " + fault.ToString() + '\n';
            A += "total KM:              " + (KM_end - KM_start).ToString() + '\n';
            A += "faults:                " + KM_start.ToString() + '\n';
            A += "price:                 " + price.ToString() + '\n';

            return A;
        }
    }
}
