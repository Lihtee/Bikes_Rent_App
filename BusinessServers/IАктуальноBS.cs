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
    /// I актуально BS.
    /// </summary>
    // *** Start programmer edit section *** (IАктуальноBS CustomAttributes)

    // *** End programmer edit section *** (IАктуальноBS CustomAttributes)
    [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class IАктуальноBS : ICSSoft.STORMNET.Business.BusinessServer
    {
        
        // *** Start programmer edit section *** (IАктуальноBS CustomMembers)

        // *** End programmer edit section *** (IАктуальноBS CustomMembers)

        
        // *** Start programmer edit section *** (OnUpdateIАктуально CustomAttributes)

        // *** End programmer edit section *** (OnUpdateIАктуально CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateIАктуально(IIS.Прокат_велосипедов_2.IАктуально UpdatedObject)
        {
            // *** Start programmer edit section *** (OnUpdateIАктуально)
            var updateObject = (DataObject)UpdatedObject;


            if (((DataObject)UpdatedObject).GetStatus() == ObjectStatus.Deleted)
            {
                if (!updateObject.CheckLoadedProperty("Актуально"))
                {
                    var ds = DataServiceProvider.DataService;
                    ds.LoadObject(updateObject);
                }

                
                if (((IАктуально)updateObject).Актуально)
                {
                    UpdatedObject.Актуально = false;
                }else
                {
                    throw new Exception("Это уже удалено!");
                }
                ((DataObject)UpdatedObject).SetStatus(ObjectStatus.Altered);
                
            }
            return new ICSSoft.STORMNET.DataObject[1] {((DataObject)UpdatedObject) };
            // *** End programmer edit section *** (OnUpdateIАктуально)
        }
    }
}
