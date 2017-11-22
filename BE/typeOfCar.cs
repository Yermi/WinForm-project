using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BE
{
    // properties of typeOfCar
    [DataContract]
    public class typeOfCar
    {
        [DataMember]
        public String Manufacturer { get; set; }

        [DataMember]
        public String model { get; set; }

        [DataMember]
        public int Engine { get; set; }

        public override string ToString()
        {
            string A;
            A=  "Manufacturer:  " + Manufacturer.ToString() + '\n';
            A += "model:               " + model.ToString() + '\n';
            A += "engine:              " + Engine.ToString() + '\n';

            return A;
        }
    }
}
