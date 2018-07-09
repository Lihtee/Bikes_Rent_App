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
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Тип велосипеда.
    /// </summary>
    // *** Start programmer edit section *** (ТипВелосипеда CustomAttributes)

    // *** End programmer edit section *** (ТипВелосипеда CustomAttributes)
    [AutoAltered()]
    [Caption("Тип велосипеда")]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("AuditView", new string[] {
            "Название as \'Название\'",
            "ТекущаяСтоимость as \'Текущая стоимость\'",
            "Актуально as \'Актуально\'",
            "ДатаНачалаАктуальности as \'Дата начала актуальности\'",
            "ДатаОкончанияАктуальности as \'Дата окончания актуальности\'"})]
    [AssociatedDetailViewAttribute("AuditView", "ИсторияРасценок", "AuditView", true, "", "История расценок", true, new string[] {
            ""})]
    [View("ТипВелосипедаE", new string[] {
            "Название as \'Название\'",
            "ТекущаяСтоимость as \'Текущая стоимость\'",
            "Актуально as \'Актуально\'",
            "ДатаНачалаАктуальности as \'Дата начала актуальности\'",
            "ДатаОкончанияАктуальности as \'Дата окончания актуальности\'"})]
    [AssociatedDetailViewAttribute("ТипВелосипедаE", "ИсторияРасценок", "ИсторияРасценокE", true, "", "История расценок", true, new string[] {
            ""})]
    [View("ТипВелосипедаL", new string[] {
            "Название as \'Название\'",
            "ТекущаяСтоимость as \'Текущая стоимость\'",
            "Актуально as \'Актуально\'",
            "ДатаНачалаАктуальности as \'Дата начала актуальности\'",
            "ДатаОкончанияАктуальности as \'Дата окончания актуальности\'"})]
    public class ТипВелосипеда : ICSSoft.STORMNET.DataObject, IIS.Прокат_велосипедов_2.IАктуально, IDataObjectWithAuditFields
    {
        
        private string fНазвание;
        
        private bool fАктуально;
        
        private System.DateTime fДатаНачалаАктуальности;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fДатаОкончанияАктуальности;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private IIS.Прокат_велосипедов_2.DetailArrayOfИсторияРасценок fИсторияРасценок;
        
        // *** Start programmer edit section *** (ТипВелосипеда CustomMembers)

        // *** End programmer edit section *** (ТипВелосипеда CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.Название CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.Название CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.Название Get start)

                // *** End programmer edit section *** (ТипВелосипеда.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (ТипВелосипеда.Название Get end)

                // *** End programmer edit section *** (ТипВелосипеда.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.Название Set start)

                // *** End programmer edit section *** (ТипВелосипеда.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (ТипВелосипеда.Название Set end)

                // *** End programmer edit section *** (ТипВелосипеда.Название Set end)
            }
        }
        
        /// <summary>
        /// ТекущаяСтоимость.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.ТекущаяСтоимость CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.ТекущаяСтоимость CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.SQLDataService), @"SELECT ИсторияРасценок.Стоимость
FROM ИсторияРасценок
WHERE ИсторияРасценок.ТипВелосипеда = StormMainObjectKey AND
               ИсторияРасценок.ДатаОкончания IS NULL 
               OR getdate() BETWEEN  
               ИсторияРасценок.ДатаНачала AND ИсторияРасценок.ДатаОкончания")]
        [NotNull()]
        public virtual decimal ТекущаяСтоимость
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.ТекущаяСтоимость Get)
                return 0;
                // *** End programmer edit section *** (ТипВелосипеда.ТекущаяСтоимость Get)
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.ТекущаяСтоимость Set)

                // *** End programmer edit section *** (ТипВелосипеда.ТекущаяСтоимость Set)
            }
        }
        
        /// <summary>
        /// Актуально.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.Актуально CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.Актуально CustomAttributes)
        public virtual bool Актуально
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.Актуально Get start)

                // *** End programmer edit section *** (ТипВелосипеда.Актуально Get start)
                bool result = this.fАктуально;
                // *** Start programmer edit section *** (ТипВелосипеда.Актуально Get end)

                // *** End programmer edit section *** (ТипВелосипеда.Актуально Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.Актуально Set start)

                // *** End programmer edit section *** (ТипВелосипеда.Актуально Set start)
                this.fАктуально = value;
                // *** Start programmer edit section *** (ТипВелосипеда.Актуально Set end)

                // *** End programmer edit section *** (ТипВелосипеда.Актуально Set end)
            }
        }
        
        /// <summary>
        /// ДатаНачалаАктуальности.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности CustomAttributes)
        public virtual System.DateTime ДатаНачалаАктуальности
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности Get start)

                // *** End programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности Get start)
                System.DateTime result = this.fДатаНачалаАктуальности;
                // *** Start programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности Get end)

                // *** End programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности Set start)

                // *** End programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности Set start)
                this.fДатаНачалаАктуальности = value;
                // *** Start programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности Set end)

                // *** End programmer edit section *** (ТипВелосипеда.ДатаНачалаАктуальности Set end)
            }
        }
        
        /// <summary>
        /// ДатаОкончанияАктуальности.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime ДатаОкончанияАктуальности
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности Get start)

                // *** End programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fДатаОкончанияАктуальности;
                // *** Start programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности Get end)

                // *** End programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности Set start)

                // *** End programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности Set start)
                this.fДатаОкончанияАктуальности = value;
                // *** Start programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности Set end)

                // *** End programmer edit section *** (ТипВелосипеда.ДатаОкончанияАктуальности Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.CreateTime CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.CreateTime Get start)

                // *** End programmer edit section *** (ТипВелосипеда.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (ТипВелосипеда.CreateTime Get end)

                // *** End programmer edit section *** (ТипВелосипеда.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.CreateTime Set start)

                // *** End programmer edit section *** (ТипВелосипеда.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (ТипВелосипеда.CreateTime Set end)

                // *** End programmer edit section *** (ТипВелосипеда.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.Creator CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.Creator Get start)

                // *** End programmer edit section *** (ТипВелосипеда.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (ТипВелосипеда.Creator Get end)

                // *** End programmer edit section *** (ТипВелосипеда.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.Creator Set start)

                // *** End programmer edit section *** (ТипВелосипеда.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (ТипВелосипеда.Creator Set end)

                // *** End programmer edit section *** (ТипВелосипеда.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.EditTime CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.EditTime Get start)

                // *** End programmer edit section *** (ТипВелосипеда.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (ТипВелосипеда.EditTime Get end)

                // *** End programmer edit section *** (ТипВелосипеда.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.EditTime Set start)

                // *** End programmer edit section *** (ТипВелосипеда.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (ТипВелосипеда.EditTime Set end)

                // *** End programmer edit section *** (ТипВелосипеда.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.Editor CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.Editor Get start)

                // *** End programmer edit section *** (ТипВелосипеда.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (ТипВелосипеда.Editor Get end)

                // *** End programmer edit section *** (ТипВелосипеда.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.Editor Set start)

                // *** End programmer edit section *** (ТипВелосипеда.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (ТипВелосипеда.Editor Set end)

                // *** End programmer edit section *** (ТипВелосипеда.Editor Set end)
            }
        }
        
        /// <summary>
        /// Тип велосипеда.
        /// </summary>
        // *** Start programmer edit section *** (ТипВелосипеда.ИсторияРасценок CustomAttributes)

        // *** End programmer edit section *** (ТипВелосипеда.ИсторияРасценок CustomAttributes)
        public virtual IIS.Прокат_велосипедов_2.DetailArrayOfИсторияРасценок ИсторияРасценок
        {
            get
            {
                // *** Start programmer edit section *** (ТипВелосипеда.ИсторияРасценок Get start)

                // *** End programmer edit section *** (ТипВелосипеда.ИсторияРасценок Get start)
                if ((this.fИсторияРасценок == null))
                {
                    this.fИсторияРасценок = new IIS.Прокат_велосипедов_2.DetailArrayOfИсторияРасценок(this);
                }
                IIS.Прокат_велосипедов_2.DetailArrayOfИсторияРасценок result = this.fИсторияРасценок;
                // *** Start programmer edit section *** (ТипВелосипеда.ИсторияРасценок Get end)

                // *** End programmer edit section *** (ТипВелосипеда.ИсторияРасценок Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипВелосипеда.ИсторияРасценок Set start)

                // *** End programmer edit section *** (ТипВелосипеда.ИсторияРасценок Set start)
                this.fИсторияРасценок = value;
                // *** Start programmer edit section *** (ТипВелосипеда.ИсторияРасценок Set end)

                // *** End programmer edit section *** (ТипВелосипеда.ИсторияРасценок Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(IIS.Прокат_велосипедов_2.ТипВелосипеда));
                }
            }
            
            /// <summary>
            /// "ТипВелосипедаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТипВелосипедаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТипВелосипедаE", typeof(IIS.Прокат_велосипедов_2.ТипВелосипеда));
                }
            }
            
            /// <summary>
            /// "ТипВелосипедаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТипВелосипедаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТипВелосипедаL", typeof(IIS.Прокат_велосипедов_2.ТипВелосипеда));
                }
            }
        }
        
        /// <summary>
        /// Audit class settings.
        /// </summary>
        public class AuditSettings
        {
            
            /// <summary>
            /// Включён ли аудит для класса.
            /// </summary>
            public static bool AuditEnabled = true;
            
            /// <summary>
            /// Использовать имя представления для аудита по умолчанию.
            /// </summary>
            public static bool UseDefaultView = false;
            
            /// <summary>
            /// Включён ли аудит операции чтения.
            /// </summary>
            public static bool SelectAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции чтения.
            /// </summary>
            public static string SelectAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции создания.
            /// </summary>
            public static bool InsertAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции создания.
            /// </summary>
            public static string InsertAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции изменения.
            /// </summary>
            public static bool UpdateAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции изменения.
            /// </summary>
            public static string UpdateAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции удаления.
            /// </summary>
            public static bool DeleteAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции удаления.
            /// </summary>
            public static string DeleteAuditViewName = "AuditView";
            
            /// <summary>
            /// Путь к форме просмотра результатов аудита.
            /// </summary>
            public static string FormUrl = "";
            
            /// <summary>
            /// Режим записи данных аудита (синхронный или асинхронный).
            /// </summary>
            public static ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode WriteMode = ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode.Synchronous;
            
            /// <summary>
            /// Максимальная длина сохраняемого значения поля (если 0, то строка обрезаться не будет).
            /// </summary>
            public static int PrunningLength = 0;
            
            /// <summary>
            /// Показывать ли пользователям в изменениях первичные ключи.
            /// </summary>
            public static bool ShowPrimaryKey = false;
            
            /// <summary>
            /// Сохранять ли старое значение.
            /// </summary>
            public static bool KeepOldValue = true;
            
            /// <summary>
            /// Сжимать ли сохраняемые значения.
            /// </summary>
            public static bool Compress = false;
            
            /// <summary>
            /// Сохранять ли все значения атрибутов, а не только изменяемые.
            /// </summary>
            public static bool KeepAllValues = false;
        }
    }
}
