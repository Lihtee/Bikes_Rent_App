﻿/*flexberryautogenerated="false"*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using ICSSoft.STORMNET.Business;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Web.Services;

namespace IIS.Прокат_велосипедов_2
{
    public partial class Запрос1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }
        protected void btnShowReq1Click(object sender, EventArgs e)
        {
            
        }
        [WebMethod]
        public static string BestWorstRequest_1(string from, string to)
        {
            if (from == null || from == string.Empty)
            {
                from = "01.01.1900";
            }
            if (to == null || to == string.Empty)
            {
                to = DateTime.Now.ToShortDateString();
            }
            using (SqlConnection conn = (SqlConnection)((SQLDataService)DataServiceProvider.DataService).GetConnection())
            {
                string commandText = @"SELECT Название, COUNT(*) as КоличествоПрокатов
                                        FROM
                                        (
                                            SELECT
                                                ТипВелосипеда.primaryKey,
                                                ТипВелосипеда.Название as Название,
                                                ПрокатВелосипеда.ДатаНачала as ДатаНачала
                                            FROM
                                                ТипВелосипеда INNER JOIN Велосипед ON ТипВелосипеда.primaryKey = Велосипед.ТипВелосипеда
                                                              INNER JOIN ПрокатВелосипеда ON ПрокатВелосипеда.Велосипед_m0 = Велосипед.primaryKey
                                        )""SMTH""
                                            WHERE ДатаНачала BETWEEN @DateFrom and @DateTo
                                            GROUP BY Название
                                            ORDER BY КоличествоПрокатов DESC";
                conn.Open();
                SqlCommand com = new SqlCommand(commandText, conn);
                SqlParameter dateFromPar = new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "@DateFrom",
                    Value = Convert.ToDateTime(from),
                };
                SqlParameter dateToPar = new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "@DateTo",
                    Value = Convert.ToDateTime(to),
                };
                com.Parameters.AddRange
                    (new SqlParameter[] { dateFromPar, dateToPar });

                var reader = com.ExecuteReader();
                JSONStruct toJSON = new JSONStruct();
                toJSON.AddCol("Тип велосипеда", "string");
                toJSON.AddCol("Количество прокатов", "number");
                while (reader.Read())
                {
                    string[] row = new string[2];
                    row[0] = reader.GetString(0);
                    row[1] = reader.GetInt32(1).ToString();
                    toJSON.AddRow(row);
                }
                conn.Close();

                string JSONAsString = string.Empty; 
                using (MemoryStream stream1 = new MemoryStream())
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(JSONStruct));
                    ser.WriteObject(stream1, toJSON);
                    using (StreamReader sr = new StreamReader(stream1))
                    {
                        stream1.Position = 0;
                        JSONAsString = sr.ReadToEnd();
                    }
                }
                return JSONAsString;
            }
            
        }

        
    }

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
        public JSONStruct (List<JSONCol> _columns, List<List<string>> _rows)
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
            foreach( var el in row)
            {
                rowAsList.Add(el);
            }
            rows.Add(rowAsList);
        }

        
    }
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