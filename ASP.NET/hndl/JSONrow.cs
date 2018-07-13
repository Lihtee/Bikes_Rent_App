using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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


    }
    
}