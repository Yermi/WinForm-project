using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BE
{
    // properties of car
    [DataContract]
    public class Car
    {
        [DataMember]
        public int License { get; set; }

        [DataMember]
        public DateTime dateOfProduction { get; set; }

        [DataMember]
        public typeOfCar typeOfCar { get; set; }

        [DataMember]
        public Gear AutoOrManual { get; set; }

        [DataMember]
        public int passengers { get; set; }

        [DataMember]
        public int Doors { get; set; }

        [DataMember]
        public int KM { get; set; }

        [DataMember]
        public String branch { get; set; }

        [DataMember]
        public List<Fault> faults { get; set; }



        public override string ToString()
        {
            string A;
            A = "license:              " + License.ToString() + '\n';
            A += "date of production:  " + dateOfProduction.ToString() + '\n';
            A += "manufactor:          " + typeOfCar.Manufacturer.ToString() + '\n';
            A += "model:               " + typeOfCar.model.ToString() + '\n';
            A += "Engine:              " + typeOfCar.Engine.ToString() + '\n';
            A += "Auto/Manual:         " + AutoOrManual.ToString() + '\n';
            A += "passengers:          " + passengers.ToString() + '\n';
            A += "doors:               " + Doors.ToString() + '\n';
            A += "km:                  " + KM.ToString() + '\n';
            A += "branch:              " + branch.ToString() + '\n';
            A += "faults:              " + faults.ToString() + '\n';

            return A;
        }
    }
}
