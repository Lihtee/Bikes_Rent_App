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
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// История расценок.
    /// </summary>
    // *** Start programmer edit section *** (ИсторияРасценок CustomAttributes)

    // *** End programmer edit section *** (ИсторияРасценок CustomAttributes)
    [AutoAltered()]
    [Caption("История расценок")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ИсторияРасценокE", new string[] {
            "ДатаНачала as \'Дата начала\'",
            "ДатаОкончания as \'Дата окончания\'",
            "Стоимость as \'Стоимость\'"})]
    public class ИсторияРасценок : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаНачала;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fДатаОкончания;
        
        private decimal fСтоимость;
        
        private IIS.Прокат_велосипедов_2.ТипВелосипеда fТипВелосипеда;
        
        // *** Start programmer edit section *** (ИсторияРасценок CustomMembers)

        // *** End programmer edit section *** (ИсторияРасценок CustomMembers)

        
        /// <summary>
        /// ДатаНачала.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРасценок.ДатаНачала CustomAttributes)

        // *** End programmer edit section *** (ИсторияРасценок.ДатаНачала CustomAttributes)
        [NotNull()]
        public virtual System.DateTime ДатаНачала
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРасценок.ДатаНачала Get start)

                // *** End programmer edit section *** (ИсторияРасценок.ДатаНачала Get start)
                System.DateTime result = this.fДатаНачала;
                // *** Start programmer edit section *** (ИсторияРасценок.ДатаНачала Get end)

                // *** End programmer edit section *** (ИсторияРасценок.ДатаНачала Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРасценок.ДатаНачала Set start)

                // *** End programmer edit section *** (ИсторияРасценок.ДатаНачала Set start)
                this.fДатаНачала = value;
                // *** Start programmer edit section *** (ИсторияРасценок.ДатаНачала Set end)

                // *** End programmer edit section *** (ИсторияРасценок.ДатаНачала Set end)
            }
        }
        
        /// <summary>
        /// ДатаОкончания.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРасценок.ДатаОкончания CustomAttributes)

        // *** End programmer edit section *** (ИсторияРасценок.ДатаОкончания CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime ДатаОкончания
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРасценок.ДатаОкончания Get start)

                // *** End programmer edit section *** (ИсторияРасценок.ДатаОкончания Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fДатаОкончания;
                // *** Start programmer edit section *** (ИсторияРасценок.ДатаОкончания Get end)

                // *** End programmer edit section *** (ИсторияРасценок.ДатаОкончания Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРасценок.ДатаОкончания Set start)

                // *** End programmer edit section *** (ИсторияРасценок.ДатаОкончания Set start)
                this.fДатаОкончания = value;
                // *** Start programmer edit section *** (ИсторияРасценок.ДатаОкончания Set end)

                // *** End programmer edit section *** (ИсторияРасценок.ДатаОкончания Set end)
            }
        }
        
        /// <summary>
        /// Стоимость.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРасценок.Стоимость CustomAttributes)

        // *** End programmer edit section *** (ИсторияРасценок.Стоимость CustomAttributes)
        [NotNull()]
        public virtual decimal Стоимость
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРасценок.Стоимость Get start)

                // *** End programmer edit section *** (ИсторияРасценок.Стоимость Get start)
                decimal result = this.fСтоимость;
                // *** Start programmer edit section *** (ИсторияРасценок.Стоимость Get end)

                // *** End programmer edit section *** (ИсторияРасценок.Стоимость Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРасценок.Стоимость Set start)

                // *** End programmer edit section *** (ИсторияРасценок.Стоимость Set start)
                this.fСтоимость = value;
                // *** Start programmer edit section *** (ИсторияРасценок.Стоимость Set end)

                // *** End programmer edit section *** (ИсторияРасценок.Стоимость Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Прокат_велосипедов_2.ТипВелосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ИсторияРасценок.ТипВелосипеда CustomAttributes)

        // *** End programmer edit section *** (ИсторияРасценок.ТипВелосипеда CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ТипВелосипеда"})]
        public virtual IIS.Прокат_велосипедов_2.ТипВелосипеда ТипВелосипеда
        {
            get
            {
                // *** Start programmer edit section *** (ИсторияРасценок.ТипВелосипеда Get start)

                // *** End programmer edit section *** (ИсторияРасценок.ТипВелосипеда Get start)
                IIS.Прокат_велосипедов_2.ТипВелосипеда result = this.fТипВелосипеда;
                // *** Start programmer edit section *** (ИсторияРасценок.ТипВелосипеда Get end)

                // *** End programmer edit section *** (ИсторияРасценок.ТипВелосипеда Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИсторияРасценок.ТипВелосипеда Set start)

                // *** End programmer edit section *** (ИсторияРасценок.ТипВелосипеда Set start)
                this.fТипВелосипеда = value;
                // *** Start programmer edit section *** (ИсторияРасценок.ТипВелосипеда Set end)

                // *** End programmer edit section *** (ИсторияРасценок.ТипВелосипеда Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ИсторияРасценокE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ИсторияРасценокE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ИсторияРасценокE", typeof(IIS.Прокат_велосипедов_2.ИсторияРасценок));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ИсторияРасценок.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfИсторияРасценок CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfИсторияРасценок CustomAttributes)
    public class DetailArrayOfИсторияРасценок : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Прокат_велосипедов_2.DetailArrayOfИсторияРасценок members)

        // *** End programmer edit section *** (IIS.Прокат_велосипедов_2.DetailArrayOfИсторияРасценок members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ИсторияРасценок by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ИсторияРасценок.
        /// </summary>
        public DetailArrayOfИсторияРасценок(IIS.Прокат_велосипедов_2.ТипВелосипеда fТипВелосипеда) : 
                base(typeof(ИсторияРасценок), ((ICSSoft.STORMNET.DataObject)(fТипВелосипеда)))
        {
        }
        
        public IIS.Прокат_велосипедов_2.ИсторияРасценок this[int index]
        {
            get
            {
                return ((IIS.Прокат_велосипедов_2.ИсторияРасценок)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Прокат_велосипедов_2.ИсторияРасценок dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
