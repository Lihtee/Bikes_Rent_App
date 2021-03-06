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
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Выдача велосипеда.
    /// </summary>
    // *** Start programmer edit section *** (ВыдачаВелосипеда CustomAttributes)

    // *** End programmer edit section *** (ВыдачаВелосипеда CustomAttributes)
    [BusinessServer("IIS.Прокат_велосипедов_2.ВыдачаВелосипедаBS, Прокат_велосипедов_2.BusinessServers" +
        "", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnInsertToStorage)]
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored()]
    [Caption("Выдача велосипеда")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ВыдачаВелосипедаE", new string[] {
            "ДатаНачала as \'Дата начала\'",
            "ПлановаяДлительность as \'Плановая длительность\'",
            "ПлановаяСтоимость as \'Плановая стоимость\'",
            "ТочкаВыдачи as \'Точка выдачи\'",
            "Велосипед as \'Велосипед\'",
            "Клиент as \'Клиент\'",
            "Прокатчик as \'Прокатчик\'"})]
    [MasterViewDefineAttribute("ВыдачаВелосипедаE", "ТочкаВыдачи", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Адрес")]
    [MasterViewDefineAttribute("ВыдачаВелосипедаE", "Велосипед", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Номер")]
    [MasterViewDefineAttribute("ВыдачаВелосипедаE", "Клиент", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [MasterViewDefineAttribute("ВыдачаВелосипедаE", "Прокатчик", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [View("ВыдачаВелосипедаL", new string[] {
            "ДатаНачала as \'Дата начала\'",
            "ПлановаяДлительность as \'Плановая длительность\'",
            "ПлановаяСтоимость as \'Плановая стоимость\'",
            "ТочкаВыдачи.Адрес as \'Адрес\'",
            "Велосипед.Номер as \'Номер\'"})]
    public class ВыдачаВелосипеда : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаНачала = System.DateTime.Now;
        
        private int fПлановаяДлительность;
        
        private decimal fПлановаяСтоимость;
        
        private IIS.Прокат_велосипедов_2.Сотрудник fПрокатчик;
        
        private IIS.Прокат_велосипедов_2.ТочкаПроката fТочкаВыдачи;
        
        private IIS.Прокат_велосипедов_2.Клиент fКлиент;
        
        private IIS.Прокат_велосипедов_2.Велосипед fВелосипед;
        
        // *** Start programmer edit section *** (ВыдачаВелосипеда CustomMembers)

        // *** End programmer edit section *** (ВыдачаВелосипеда CustomMembers)

        
        /// <summary>
        /// ДатаНачала.
        /// </summary>
        // *** Start programmer edit section *** (ВыдачаВелосипеда.ДатаНачала CustomAttributes)

        // *** End programmer edit section *** (ВыдачаВелосипеда.ДатаНачала CustomAttributes)
        public virtual System.DateTime ДатаНачала
        {
            get
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ДатаНачала Get start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ДатаНачала Get start)
                System.DateTime result = this.fДатаНачала;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ДатаНачала Get end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ДатаНачала Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ДатаНачала Set start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ДатаНачала Set start)
                this.fДатаНачала = value;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ДатаНачала Set end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ДатаНачала Set end)
            }
        }
        
        /// <summary>
        /// ПлановаяДлительность.
        /// </summary>
        // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность CustomAttributes)

        // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность CustomAttributes)
        public virtual int ПлановаяДлительность
        {
            get
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность Get start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность Get start)
                int result = this.fПлановаяДлительность;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность Get end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность Set start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность Set start)
                this.fПлановаяДлительность = value;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность Set end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяДлительность Set end)
            }
        }
        
        /// <summary>
        /// ПлановаяСтоимость.
        /// </summary>
        // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость CustomAttributes)

        // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость CustomAttributes)
        public virtual decimal ПлановаяСтоимость
        {
            get
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость Get start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость Get start)
                decimal result = this.fПлановаяСтоимость;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость Get end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость Set start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость Set start)
                this.fПлановаяСтоимость = value;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость Set end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ПлановаяСтоимость Set end)
            }
        }
        
        /// <summary>
        /// Выдача велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ВыдачаВелосипеда.Прокатчик CustomAttributes)

        // *** End programmer edit section *** (ВыдачаВелосипеда.Прокатчик CustomAttributes)
        [PropertyStorage(new string[] {
                "Прокатчик"})]
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.Сотрудник Прокатчик
        {
            get
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Прокатчик Get start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Прокатчик Get start)
                IIS.Прокат_велосипедов_2.Сотрудник result = this.fПрокатчик;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Прокатчик Get end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Прокатчик Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Прокатчик Set start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Прокатчик Set start)
                this.fПрокатчик = value;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Прокатчик Set end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Прокатчик Set end)
            }
        }
        
        /// <summary>
        /// Выдача велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи CustomAttributes)

        // *** End programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи CustomAttributes)
        [PropertyStorage(new string[] {
                "ТочкаВыдачи"})]
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.ТочкаПроката ТочкаВыдачи
        {
            get
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи Get start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи Get start)
                IIS.Прокат_велосипедов_2.ТочкаПроката result = this.fТочкаВыдачи;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи Get end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи Set start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи Set start)
                this.fТочкаВыдачи = value;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи Set end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.ТочкаВыдачи Set end)
            }
        }
        
        /// <summary>
        /// Выдача велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ВыдачаВелосипеда.Клиент CustomAttributes)

        // *** End programmer edit section *** (ВыдачаВелосипеда.Клиент CustomAttributes)
        [PropertyStorage(new string[] {
                "Клиент"})]
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.Клиент Клиент
        {
            get
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Клиент Get start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Клиент Get start)
                IIS.Прокат_велосипедов_2.Клиент result = this.fКлиент;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Клиент Get end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Клиент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Клиент Set start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Клиент Set start)
                this.fКлиент = value;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Клиент Set end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Клиент Set end)
            }
        }
        
        /// <summary>
        /// Выдача велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ВыдачаВелосипеда.Велосипед CustomAttributes)

        // *** End programmer edit section *** (ВыдачаВелосипеда.Велосипед CustomAttributes)
        [PropertyStorage(new string[] {
                "Велосипед"})]
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.Велосипед Велосипед
        {
            get
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Велосипед Get start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Велосипед Get start)
                IIS.Прокат_велосипедов_2.Велосипед result = this.fВелосипед;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Велосипед Get end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Велосипед Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Велосипед Set start)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Велосипед Set start)
                this.fВелосипед = value;
                // *** Start programmer edit section *** (ВыдачаВелосипеда.Велосипед Set end)

                // *** End programmer edit section *** (ВыдачаВелосипеда.Велосипед Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ВыдачаВелосипедаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ВыдачаВелосипедаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ВыдачаВелосипедаE", typeof(IIS.Прокат_велосипедов_2.ВыдачаВелосипеда));
                }
            }
            
            /// <summary>
            /// "ВыдачаВелосипедаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ВыдачаВелосипедаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ВыдачаВелосипедаL", typeof(IIS.Прокат_велосипедов_2.ВыдачаВелосипеда));
                }
            }
        }
    }
}
