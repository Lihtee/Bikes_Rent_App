using ICSSoft.STORMNET;
using ICSSoft.STORMNET.Business;
using IIS.University.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace IIS.Прокат_велосипедов_2.forms
{
    [Route("api/[VidatVelosiped]")]
    public class VidatVelosipedController : ApiController
    {
        //TODO перенести код из вебметода сюда.

        [HttpPost]
        public void Post (VidatVelosiped obj)
            //(string startDate, string plannedDuration, string plannedPrice,
            // string startPoint, string vel, string klient, string employee)
        {
            StringBuilder errorMessageBuilder = new StringBuilder();
            try
            {
                //Проверка входных парамтеров
                DateTime checkedStartDate = new DateTime();
                if (!DateTime.TryParse(obj.startDate, out checkedStartDate))
                {
                    errorMessageBuilder.Append("Дата начала неправильная. ");
                }

                int checkedPlannedDuration = 0;
                if (!Int32.TryParse(obj.plannedDuration, out checkedPlannedDuration))
                {
                    errorMessageBuilder.Append("Планируемое время неправильное. ");
                }

                decimal checkedPlannedPrice = 0;
                if (!decimal.TryParse(obj.plannedPrice, out checkedPlannedPrice))
                {
                    errorMessageBuilder.Append("Планируемая стоимость неправильная. ");
                }

                Guid checkedStartPoint = new Guid();
                if (!Guid.TryParse(obj.startPoint, out checkedStartPoint))
                {
                    errorMessageBuilder.Append("Точка выдачи неправильная. ");
                }


                Guid checkedVel = new Guid();
                if (!Guid.TryParse(obj.vel, out checkedVel))
                {
                    errorMessageBuilder.Append("Велосипед неправильный. ");
                }


                Guid checkedKlient = new Guid();
                if (!Guid.TryParse(obj.klient, out checkedKlient))
                {
                    errorMessageBuilder.Append("Клиент неправильный. ");
                }

                Guid checkedEmployee = new Guid();
                if (!Guid.TryParse(obj.employee, out checkedEmployee))
                {
                    errorMessageBuilder.Append("Прокатчик неправильный. ");
                }

                if (errorMessageBuilder.Length != 0)
                {
                    throw new Exception(errorMessageBuilder.ToString());
                }

                //Заполнение объекта для сохранения.

                var storedObject = new IIS.Прокат_велосипедов_2.ПрокатВелосипеда
                {
                    ДатаНачала = checkedStartDate,
                    Велосипед = PKHelper.CreateDataObject<Велосипед>(checkedVel),
                    ПлановаяСтоимость = checkedPlannedPrice,
                    ПлановаяДлительность = checkedPlannedDuration,
                    ТочкаВыдачи = PKHelper.CreateDataObject<ТочкаПроката>(checkedStartPoint),
                    ТочкаСдачи = null,
                    Прокатчик = PKHelper.CreateDataObject<Сотрудник>(checkedEmployee),
                    Клиент = PKHelper.CreateDataObject<Клиент>(checkedKlient),
                    ФактическаяДатаСдачи = null,
                    ФактическаяСтоимость = 0
                };

                //Сохранение и прочее
                var ds = DataServiceProvider.DataService;
                ds.UpdateObject(storedObject);
                var loadedVel = new Велосипед { __PrimaryKey = checkedVel };
                ds.LoadObject(loadedVel);
                string uLogin = ICSSoft.Services.CurrentUserService.CurrentUser.Login;
                LogService.LogInfo($"Пользователь {uLogin} совершил выдачу велосипеда {loadedVel.Номер.ToString()} ");

                
                
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }

    public class VidatVelosiped
    {
        public string startDate;
        public string plannedDuration;
        public string plannedPrice;
        public string startPoint;
        public string vel;
        public string klient;
        public string employee;
    }
}
