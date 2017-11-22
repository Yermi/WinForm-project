using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BE
{
    //enum of type of fault
    [DataContract]
    public enum typeFault
    {
        [EnumMember]
        Wheels,

        [EnumMember]
        Engine,

        [EnumMember]
        Exhaust
    }
}
