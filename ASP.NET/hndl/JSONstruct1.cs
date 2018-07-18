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
    public class JSONStruct
    {
        [DataMember]
        public List<JSONCol> Columns;
        [DataMember]
        private List<List<string>> rows;

        public JSONStruct()
        {
            Columns = new List<JSONCol>();
            rows = new List<List<string>>();
        }
        public JSONStruct(List<JSONCol> _columns, List<List<string>> _rows)
        {
            Columns = _columns;
            rows = _rows;
        }

        public void AddCol(string name, string type)
        {
            Columns.Add(new JSONCol(name, type));
        }
        public void AddRow(IEnumerable<string> row)
        {
            var rowAsList = new List<string>();
            foreach (var el in row)
            {
                rowAsList.Add(el);
            }
            rows.Add(rowAsList);
        }
        public override string ToString()
        {
            string res = string.Empty;
            using (MemoryStream stream1 = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(JSONStruct));
                ser.WriteObject(stream1, this);
                using (StreamReader sr = new StreamReader(stream1))
                {
                    stream1.Position = 0;
                    res = sr.ReadToEnd();
                }
            }
            return res;
        }


    }
    
}