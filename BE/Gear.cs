using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BE
{
    // enum of type of gear
    [DataContract]
    public enum Gear
    {
        [EnumMember]
        Auto,

        [EnumMember]
        Manual
    }
}
