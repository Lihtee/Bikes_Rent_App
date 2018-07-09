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
    /// Прием велосипеда.
    /// </summary>
    // *** Start programmer edit section *** (ПриемВелосипеда CustomAttributes)

    // *** End programmer edit section *** (ПриемВелосипеда CustomAttributes)
    [BusinessServer("IIS.Прокат_велосипедов_2.ПриемВелосипедаBS, Прокат_велосипедов_2.BusinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnInsertToStorage)]
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored()]
    [Caption("Прием велосипеда")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПриемВелосипедаE", new string[] {
            "ПрокатВелосипеда.Велосипед",
            "ПрокатВелосипеда.Велосипед.Номер",
            "ПрокатВелосипеда as \'Прокат велосипеда\'",
            "ДатаПриема as \'Дата приема\'",
            "ФактическаяСтоимость as \'Фактическая стоимость\'",
            "Прокатчик as \'Прокатчик\'"}, Hidden=new string[] {
            "ПрокатВелосипеда.Велосипед",
            "ПрокатВелосипеда.Велосипед.Номер"})]
    [MasterViewDefineAttribute("ПриемВелосипедаE", "ПрокатВелосипеда", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Велосипед.Номер")]
    [MasterViewDefineAttribute("ПриемВелосипедаE", "Прокатчик", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [View("ПриемВелосипедаL", new string[] {
            "ДатаПриема as \'Дата приема\'",
            "ФактическаяСтоимость as \'Фактическая стоимость\'",
            "ПрокатВелосипеда.Велосипед.Номер",
            "ПрокатВелосипеда.Велосипед",
            "ПрокатВелосипеда as \'Прокат велосипеда\'",
            "Прокатчик.ФИО as \'ФИО\'"}, Hidden=new string[] {
            "ПрокатВелосипеда.Велосипед.Номер",
            "ПрокатВелосипеда.Велосипед"})]
    [MasterViewDefineAttribute("ПриемВелосипедаL", "ПрокатВелосипеда", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Велосипед.Номер")]
    public class ПриемВелосипеда : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаПриема = System.DateTime.Now;
        
        private decimal fФактическаяСтоимость;
        
        private IIS.Прокат_велосипедов_2.Сотрудник fПрокатчик;
        
        private IIS.Прокат_велосипедов_2.ПрокатВелосипеда fПрокатВелосипеда;
        
        // *** Start programmer edit section *** (ПриемВелосипеда CustomMembers)

        // *** End programmer edit section *** (ПриемВелосипеда CustomMembers)

        
        /// <summary>
        /// ДатаПриема.
        /// </summary>
        // *** Start programmer edit section *** (ПриемВелосипеда.ДатаПриема CustomAttributes)

        // *** End programmer edit section *** (ПриемВелосипеда.ДатаПриема CustomAttributes)
        public virtual System.DateTime ДатаПриема
        {
            get
            {
                // *** Start programmer edit section *** (ПриемВелосипеда.ДатаПриема Get start)

                // *** End programmer edit section *** (ПриемВелосипеда.ДатаПриема Get start)
                System.DateTime result = this.fДатаПриема;
                // *** Start programmer edit section *** (ПриемВелосипеда.ДатаПриема Get end)

                // *** End programmer edit section *** (ПриемВелосипеда.ДатаПриема Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПриемВелосипеда.ДатаПриема Set start)

                // *** End programmer edit section *** (ПриемВелосипеда.ДатаПриема Set start)
                this.fДатаПриема = value;
                // *** Start programmer edit section *** (ПриемВелосипеда.ДатаПриема Set end)

                // *** End programmer edit section *** (ПриемВелосипеда.ДатаПриема Set end)
            }
        }
        
        /// <summary>
        /// ФактическаяСтоимость.
        /// </summary>
        // *** Start programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость CustomAttributes)

        // *** End programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость CustomAttributes)
        public virtual decimal ФактическаяСтоимость
        {
            get
            {
                // *** Start programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость Get start)

                // *** End programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость Get start)
                decimal result = this.fФактическаяСтоимость;
                // *** Start programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость Get end)

                // *** End programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость Set start)

                // *** End programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость Set start)
                this.fФактическаяСтоимость = value;
                // *** Start programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость Set end)

                // *** End programmer edit section *** (ПриемВелосипеда.ФактическаяСтоимость Set end)
            }
        }
        
        /// <summary>
        /// Прием велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ПриемВелосипеда.Прокатчик CustomAttributes)

        // *** End programmer edit section *** (ПриемВелосипеда.Прокатчик CustomAttributes)
        [PropertyStorage(new string[] {
                "Прокатчик"})]
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.Сотрудник Прокатчик
        {
            get
            {
                // *** Start programmer edit section *** (ПриемВелосипеда.Прокатчик Get start)

                // *** End programmer edit section *** (ПриемВелосипеда.Прокатчик Get start)
                IIS.Прокат_велосипедов_2.Сотрудник result = this.fПрокатчик;
                // *** Start programmer edit section *** (ПриемВелосипеда.Прокатчик Get end)

                // *** End programmer edit section *** (ПриемВелосипеда.Прокатчик Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПриемВелосипеда.Прокатчик Set start)

                // *** End programmer edit section *** (ПриемВелосипеда.Прокатчик Set start)
                this.fПрокатчик = value;
                // *** Start programmer edit section *** (ПриемВелосипеда.Прокатчик Set end)

                // *** End programmer edit section *** (ПриемВелосипеда.Прокатчик Set end)
            }
        }
        
        /// <summary>
        /// Прием велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда CustomAttributes)

        // *** End programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда CustomAttributes)
        [PropertyStorage(new string[] {
                "ПрокатВелосипеда"})]
        [NotNull()]
        public virtual IIS.Прокат_велосипедов_2.ПрокатВелосипеда ПрокатВелосипеда
        {
            get
            {
                // *** Start programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда Get start)

                // *** End programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда Get start)
                IIS.Прокат_велосипедов_2.ПрокатВелосипеда result = this.fПрокатВелосипеда;
                // *** Start programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда Get end)

                // *** End programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда Set start)

                // *** End programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда Set start)
                this.fПрокатВелосипеда = value;
                // *** Start programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда Set end)

                // *** End programmer edit section *** (ПриемВелосипеда.ПрокатВелосипеда Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПриемВелосипедаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПриемВелосипедаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПриемВелосипедаE", typeof(IIS.Прокат_велосипедов_2.ПриемВелосипеда));
                }
            }
            
            /// <summary>
            /// "ПриемВелосипедаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПриемВелосипедаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПриемВелосипедаL", typeof(IIS.Прокат_велосипедов_2.ПриемВелосипеда));
                }
            }
        }
    }
}
