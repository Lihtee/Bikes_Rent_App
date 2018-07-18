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
    public partial class Запрос3 : System.Web.UI.Page
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
                    @"select 
                    (select count(*) 
                    from ИсторияСостояний inner join СостояниеВелосипеда on ИсторияСостояний.СостояниеВелосипеда = СостояниеВелосипеда.primaryKey
                    where СостояниеВелосипеда.Название = 'Сломан' and ИсторияСостояний.ДатаНачала between @DateFrom and @DateTo ) as Сломано, 
                    (select count(*) as Украдено
                    from ИсторияСостояний inner join СостояниеВелосипеда on ИсторияСостояний.СостояниеВелосипеда = СостояниеВелосипеда.primaryKey
                    where СостояниеВелосипеда.Название = 'Украден' and ИсторияСостояний.ДатаНачала between @DateFrom and @DateTo) as Украдено";

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
                    //toJSON.AddCol("Сломано", "number");
                    //toJSON.AddCol("Украдено", "number");
                    if (reader.Read())
                    {
                        string[] row = new string[2];
                        row[0] = reader.GetInt32(0).ToString();
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
