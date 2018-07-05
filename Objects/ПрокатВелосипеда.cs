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
    /// Прокат велосипеда.
    /// </summary>
    // *** Start programmer edit section *** (ПрокатВелосипеда CustomAttributes)

    // *** End programmer edit section *** (ПрокатВелосипеда CustomAttributes)
    [AutoAltered()]
    [Caption("Прокат велосипеда")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПрокатВелосипедаE", new string[] {
            "ДатаНачала as \'Дата начала\'",
            "ПлановаяДлительность as \'Плановая длительность\'",
            "ФактическаяДатаСдачи as \'Фактическая дата сдачи\'",
            "ПлановаяСтоимость as \'Плановая стоимость\'",
            "ФактическаяСтоимость as \'Фактическая стоимость\'",
            "ТочкаВыдачи as \'Точка выдачи\'",
            "ТочкаВыдачи.Адрес as \'Адрес\'",
            "Клиент as \'Клиент\'",
            "Клиент.ФИО as \'ФИО\'",
            "ТочкаСдачи as \'Точка сдачи\'",
            "ТочкаСдачи.Адрес as \'Адрес\'",
            "Прокатчик as \'Прокатчик\'",
            "Прокатчик.ФИО as \'ФИО\'"}, Hidden=new string[] {
            "ТочкаВыдачи.Адрес",
            "Клиент.ФИО",
            "ТочкаСдачи.Адрес",
            "Прокатчик.ФИО"})]
    [MasterViewDefineAttribute("ПрокатВелосипедаE", "ТочкаВыдачи", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Адрес")]
    [MasterViewDefineAttribute("ПрокатВелосипедаE", "Клиент", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [MasterViewDefineAttribute("ПрокатВелосипедаE", "ТочкаСдачи", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Адрес")]
    [MasterViewDefineAttribute("ПрокатВелосипедаE", "Прокатчик", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    public class ПрокатВелосипеда : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаНачала = System.DateTime.Now;
        
        private int fПлановаяДлительность;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fФактическаяДатаСдачи;
        
        private decimal fПлановаяСтоимость;
        
        private decimal fФактическаяСтоимость;
        
        private IIS.Прокат_велосипедов_2.ТочкаПроката fТочкаВыдачи;
        
        private IIS.Прокат_велосипедов_2.Клиент fКлиент;
        
        private IIS.Прокат_велосипедов_2.ТочкаПроката fТочкаСдачи;
        
        private IIS.Прокат_велосипедов_2.Сотрудник fПрокатчик;
        
        private IIS.Прокат_велосипедов_2.Велосипед fВелосипед;
        
        // *** Start programmer edit section *** (ПрокатВелосипеда CustomMembers)

        // *** End programmer edit section *** (ПрокатВелосипеда CustomMembers)

        
        /// <summary>
        /// ДатаНачала.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.ДатаНачала CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.ДатаНачала CustomAttributes)
        [NotNull()]
        public virtual System.DateTime ДатаНачала
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ДатаНачала Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ДатаНачала Get start)
                System.DateTime result = this.fДатаНачала;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ДатаНачала Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ДатаНачала Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ДатаНачала Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ДатаНачала Set start)
                this.fДатаНачала = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ДатаНачала Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ДатаНачала Set end)
            }
        }
        
        /// <summary>
        /// ПлановаяДлительность.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность CustomAttributes)
        [NotNull()]
        public virtual int ПлановаяДлительность
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность Get start)
                int result = this.fПлановаяДлительность;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность Set start)
                this.fПлановаяДлительность = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяДлительность Set end)
            }
        }
        
        /// <summary>
        /// ФактическаяДатаСдачи.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime ФактическаяДатаСдачи
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fФактическаяДатаСдачи;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи Set start)
                this.fФактическаяДатаСдачи = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяДатаСдачи Set end)
            }
        }
        
        /// <summary>
        /// ПлановаяСтоимость.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость CustomAttributes)
        [NotNull()]
        public virtual decimal ПлановаяСтоимость
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость Get start)
                decimal result = this.fПлановаяСтоимость;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость Set start)
                this.fПлановаяСтоимость = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ПлановаяСтоимость Set end)
            }
        }
        
        /// <summary>
        /// ФактическаяСтоимость.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость CustomAttributes)
        public virtual decimal ФактическаяСтоимость
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость Get start)
                decimal result = this.fФактическаяСтоимость;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость Set start)
                this.fФактическаяСтоимость = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ФактическаяСтоимость Set end)
            }
        }
        
        /// <summary>
        /// Прокат велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи CustomAttributes)
        [PropertyStorage(new string[] {
                "ТочкаВыдачи"})]
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.ТочкаПроката ТочкаВыдачи
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи Get start)
                IIS.Прокат_велосипедов_2.ТочкаПроката result = this.fТочкаВыдачи;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи Set start)
                this.fТочкаВыдачи = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаВыдачи Set end)
            }
        }
        
        /// <summary>
        /// Прокат велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.Клиент CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.Клиент CustomAttributes)
        [PropertyStorage(new string[] {
                "Клиент"})]
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.Клиент Клиент
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.Клиент Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.Клиент Get start)
                IIS.Прокат_велосипедов_2.Клиент result = this.fКлиент;
                // *** Start programmer edit section *** (ПрокатВелосипеда.Клиент Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.Клиент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.Клиент Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.Клиент Set start)
                this.fКлиент = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.Клиент Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.Клиент Set end)
            }
        }
        
        /// <summary>
        /// Прокат велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи CustomAttributes)
        [PropertyStorage(new string[] {
                "ТочкаСдачи"})]
        public virtual IIS.Прокат_велосипедов_2.ТочкаПроката ТочкаСдачи
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи Get start)
                IIS.Прокат_велосипедов_2.ТочкаПроката result = this.fТочкаСдачи;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи Set start)
                this.fТочкаСдачи = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.ТочкаСдачи Set end)
            }
        }
        
        /// <summary>
        /// Прокат велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.Прокатчик CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.Прокатчик CustomAttributes)
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.Сотрудник Прокатчик
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.Прокатчик Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.Прокатчик Get start)
                IIS.Прокат_велосипедов_2.Сотрудник result = this.fПрокатчик;
                // *** Start programmer edit section *** (ПрокатВелосипеда.Прокатчик Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.Прокатчик Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.Прокатчик Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.Прокатчик Set start)
                this.fПрокатчик = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.Прокатчик Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.Прокатчик Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Прокат_велосипедов_2.Велосипед.
        /// </summary>
        // *** Start programmer edit section *** (ПрокатВелосипеда.Велосипед CustomAttributes)

        // *** End programmer edit section *** (ПрокатВелосипеда.Велосипед CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.Велосипед Велосипед
        {
            get
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.Велосипед Get start)

                // *** End programmer edit section *** (ПрокатВелосипеда.Велосипед Get start)
                IIS.Прокат_велосипедов_2.Велосипед result = this.fВелосипед;
                // *** Start programmer edit section *** (ПрокатВелосипеда.Велосипед Get end)

                // *** End programmer edit section *** (ПрокатВелосипеда.Велосипед Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПрокатВелосипеда.Велосипед Set start)

                // *** End programmer edit section *** (ПрокатВелосипеда.Велосипед Set start)
                this.fВелосипед = value;
                // *** Start programmer edit section *** (ПрокатВелосипеда.Велосипед Set end)

                // *** End programmer edit section *** (ПрокатВелосипеда.Велосипед Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПрокатВелосипедаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПрокатВелосипедаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПрокатВелосипедаE", typeof(IIS.Прокат_велосипедов_2.ПрокатВелосипеда));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ПрокатВелосипеда.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfПрокатВелосипеда CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfПрокатВелосипеда CustomAttributes)
    public class DetailArrayOfПрокатВелосипеда : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Прокат_велосипедов_2.DetailArrayOfПрокатВелосипеда members)

        // *** End programmer edit section *** (IIS.Прокат_велосипедов_2.DetailArrayOfПрокатВелосипеда members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ПрокатВелосипеда by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ПрокатВелосипеда.
        /// </summary>
        public DetailArrayOfПрокатВелосипеда(IIS.Прокат_велосипедов_2.Велосипед fВелосипед) : 
                base(typeof(ПрокатВелосипеда), ((ICSSoft.STORMNET.DataObject)(fВелосипед)))
        {
        }
        
        public IIS.Прокат_велосипедов_2.ПрокатВелосипеда this[int index]
        {
            get
            {
                return ((IIS.Прокат_велосипедов_2.ПрокатВелосипеда)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Прокат_велосипедов_2.ПрокатВелосипеда dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
