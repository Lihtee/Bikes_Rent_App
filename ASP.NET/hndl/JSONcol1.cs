using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web;

namespace IIS.Прокат_велосипедов_2.hndl
{
    [DataContract]
    public class JSONCol
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Type;

        public JSONCol(string _name, string _type)
        {
            Name = _name;
            Type = _type;
        }
    }
}