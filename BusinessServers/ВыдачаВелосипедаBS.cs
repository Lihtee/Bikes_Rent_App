﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Прокат_велосипедов_2
{
    using System;
    using System.Xml;
    
    
    // *** Start programmer edit section *** (Using statements)
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// ВыдачаВелосипедаBS.
    /// </summary>
    // *** Start programmer edit section *** (ВыдачаВелосипедаBS CustomAttributes)

    // *** End programmer edit section *** (ВыдачаВелосипедаBS CustomAttributes)
    [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class ВыдачаВелосипедаBS : ICSSoft.STORMNET.Business.BusinessServer
    {
        
        // *** Start programmer edit section *** (ВыдачаВелосипедаBS CustomMembers)

        // *** End programmer edit section *** (ВыдачаВелосипедаBS CustomMembers)

        
        // *** Start programmer edit section *** (OnUpdateВыдачаВелосипеда CustomAttributes)

        // *** End programmer edit section *** (OnUpdateВыдачаВелосипеда CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateВыдачаВелосипеда(IIS.Прокат_велосипедов_2.ВыдачаВелосипеда UpdatedObject)
        {
            // *** Start programmer edit section *** (OnUpdateВыдачаВелосипеда)
            //if (((DataObject)UpdatedObject).GetStatus()== ObjectStatus.Created)
            //{
            //    var storedObject = new IIS.Прокат_велосипедов_2.ПрокатВелосипеда
            //    {
            //        ДатаНачала = UpdatedObject.ДатаНачала,
            //        Велосипед = UpdatedObject.Велосипед,
            //        ПлановаяСтоимость = UpdatedObject.ПлановаяСтоимость,
            //        ПлановаяДлительность = UpdatedObject.ПлановаяДлительность,
            //        ТочкаВыдачи = UpdatedObject.ТочкаВыдачи,
            //        ТочкаСдачи = null,
            //        Прокатчик = UpdatedObject.Прокатчик,
            //        Клиент = UpdatedObject.Клиент,
            //        ФактическаяДатаСдачи = null,
            //        ФактическаяСтоимость = 0
            //    };
            //    storedObject.SetStatus(ObjectStatus.Created);
            //    ((DataObject)UpdatedObject).SetStatus(ObjectStatus.UnAltered);
               
            //    var ds = DataServiceProvider.DataService;
            //    ds.UpdateObject(storedObject);
                

            //}
            return new ICSSoft.STORMNET.DataObject[0];
            // *** End programmer edit section *** (OnUpdateВыдачаВелосипеда)
        }
    }
}
