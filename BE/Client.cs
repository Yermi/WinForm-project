using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BE
{
    // properties of client
    [DataContract]
    public class Client
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public String Adress { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public int CardNumber { get; set; }

        public override string ToString()
        {
            string A;
            A = "name:            " + name + '\n';
            A +=  "ID:            " + ID.ToString() + '\n';
            A += "adress:        " + Adress.ToString() + '\n';
            A += "date birth:    " + DateOfBirth.ToString() + '\n';
            A += "credit number: " + CardNumber.ToString() + '\n';

            return A;
        }


        
    }
}
