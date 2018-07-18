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
using System.Web.Services;
using System.Data.SqlClient;
using ICSSoft.STORMNET.Business;
using IIS.Прокат_велосипедов_2.hndl;
using System.IO;
using System.Runtime.Serialization.Json;

namespace IIS.Прокат_велосипедов_2
{
    public partial class Запрос5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
                string commandText =
                    @"select ТипВелосипеда.Название, AVG(DATEDIFF(HOUR, ПрокатВелосипеда.ДатаНачала, ПрокатВелосипеда.ФактическаяДатаСдачи)) as Среднее
                      from ТипВелосипеда inner join Велосипед on ТипВелосипеда.primaryKey = Велосипед.ТипВелосипеда
                      inner join ПрокатВелосипеда on ПрокатВелосипеда.Велосипед_m0 = Велосипед.primaryKey
                      where ПрокатВелосипеда.ДатаНачала is not null
                            and ПрокатВелосипеда.ФактическаяДатаСдачи is not null
                            and ПрокатВелосипеда.ДатаНачала between @DateFrom and @DateTo
                      group by ТипВелосипеда.primaryKey, ТипВелосипеда.Название";
                JSONStruct toJSON = new JSONStruct();
                try
                {
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
                    toJSON.AddCol("Тип велосипеда", "string");
                    toJSON.AddCol("Средняя продолжительность проката в часах", "number");
                    while (reader.Read())
                    {
                        string[] row = new string[2];
                        row[0] = reader.GetString(0);
                        row[1] = reader.GetInt32(1).ToString();
                        toJSON.AddRow(row);
                    }
                    conn.Close();

                }
                catch (Exception e)
                {
                    throw new Exception("Ошибка при работе с БД: " + e.Message);
                }
           
                return toJSON.ToString();
            }

        }
    }
}
