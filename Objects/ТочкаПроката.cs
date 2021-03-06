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
    /// Точка проката.
    /// </summary>
    // *** Start programmer edit section *** (ТочкаПроката CustomAttributes)

    // *** End programmer edit section *** (ТочкаПроката CustomAttributes)
    [AutoAltered()]
    [Caption("Точка проката")]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("AuditView", new string[] {
            "Адрес as \'Адрес\'",
            "КоличествоВелосипедов as \'Количество велосипедов\'",
            "Актуально as \'Актуально\'",
            "ДатаНачалаАктуальности as \'Дата начала актуальности\'",
            "ДатаОкончанияАктуальности as \'Дата окончания актуальности\'"})]
    [View("ТочкаПрокатаE", new string[] {
            "Адрес as \'Адрес\'",
            "КоличествоВелосипедов as \'Количество велосипедов\'",
            "Актуально as \'Актуально\'",
            "ДатаНачалаАктуальности as \'Дата начала актуальности\'",
            "ДатаОкончанияАктуальности as \'Дата окончания актуальности\'"})]
    [View("ТочкаПрокатаL", new string[] {
            "Адрес as \'Адрес\'",
            "КоличествоВелосипедов as \'Количество велосипедов\'",
            "Актуально as \'Актуально\'",
            "ДатаНачалаАктуальности as \'Дата начала актуальности\'",
            "ДатаОкончанияАктуальности as \'Дата окончания актуальности\'"})]
    public class ТочкаПроката : ICSSoft.STORMNET.DataObject, IIS.Прокат_велосипедов_2.IАктуально, IDataObjectWithAuditFields
    {
        
        private string fАдрес;
        
        private bool fАктуально;
        
        private System.DateTime fДатаНачалаАктуальности;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fДатаОкончанияАктуальности;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        // *** Start programmer edit section *** (ТочкаПроката CustomMembers)

        // *** End programmer edit section *** (ТочкаПроката CustomMembers)

        
        /// <summary>
        /// Адрес.
        /// </summary>
        // *** Start programmer edit section *** (ТочкаПроката.Адрес CustomAttributes)

        // *** End programmer edit section *** (ТочкаПроката.Адрес CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Адрес
        {
            get
            {
                // *** Start programmer edit section *** (ТочкаПроката.Адрес Get start)

                // *** End programmer edit section *** (ТочкаПроката.Адрес Get start)
                string result = this.fАдрес;
                // *** Start programmer edit section *** (ТочкаПроката.Адрес Get end)

                // *** End programmer edit section *** (ТочкаПроката.Адрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТочкаПроката.Адрес Set start)

                // *** End programmer edit section *** (ТочкаПроката.Адрес Set start)
                this.fАдрес = value;
                // *** Start programmer edit section *** (ТочкаПроката.Адрес Set end)

                // *** End programmer edit section *** (ТочкаПроката.Адрес Set end)
            }
        }
        
        /// <summary>
        /// КоличествоВелосипедов.
        /// </summary>
        // *** Start programmer edit section *** (ТочкаПроката.КоличествоВелосипедов CustomAttributes)

        // *** End programmer edit section *** (ТочкаПроката.КоличествоВелосипедов CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.SQLDataService), "SELECT COUNT(Велосипед.Номер) \r\nFROM (ТочкаПроката INNER JOIN Велосипед ON ТочкаП" +
            "роката.primaryKey = Велосипед.ТочкаПроката) \r\nWHERE Велосипед.ТочкаПроката = Sto" +
            "rmMainObjectKey ")]
        [NotNull()]
        public virtual int КоличествоВелосипедов
        {
            get
            {
                // *** Start programmer edit section *** (ТочкаПроката.КоличествоВелосипедов Get)
                return 0;
                // *** End programmer edit section *** (ТочкаПроката.КоличествоВелосипедов Get)
            }
            set
            {
                // *** Start programmer edit section *** (ТочкаПроката.КоличествоВелосипедов Set)

                // *** End programmer edit section *** (ТочкаПроката.КоличествоВелосипедов Set)
            }
        }
        
        /// <summary>
        /// Актуально.
        /// </summary>
        // *** Start programmer edit section *** (ТочкаПроката.Актуально CustomAttributes)

        // *** End programmer edit section *** (ТочкаПроката.Актуально CustomAttributes)
        public virtual bool Актуально
        {
            get
            {
                // *** Start programmer edit section *** (ТочкаПроката.Актуально Get start)

                // *** End programmer edit section *** (ТочкаПроката.Актуально Get start)
                bool result = this.fАктуально;
                // *** Start programmer edit section *** (ТочкаПроката.Актуально Get end)

                // *** End programmer edit section *** (ТочкаПроката.Актуально Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТочкаПроката.Актуально Set start)

                // *** End programmer edit section *** (ТочкаПроката.Актуально Set start)
                this.fАктуально = value;
                // *** Start programmer edit section *** (ТочкаПроката.Актуально Set end)

                // *** End programmer edit section *** (ТочкаПроката.Актуально Set end)
            }
        }
        
        /// <summary>
        /// ДатаНачалаАктуальности.
        /// </summary>
        // *** Start programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности CustomAttributes)

        // *** End programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности CustomAttributes)
        public virtual System.DateTime ДатаНачалаАктуальности
        {
            get
            {
                // *** Start programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности Get start)

                // *** End programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности Get start)
                System.DateTime result = this.fДатаНачалаАктуальности;
                // *** Start programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности Get end)

                // *** End programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности Set start)

                // *** End programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности Set start)
                this.fДатаНачалаАктуальности = value;
                // *** Start programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности Set end)

                // *** End programmer edit section *** (ТочкаПроката.ДатаНачалаАктуальности Set end)
            }
        }
        
        /// <summary>
        /// ДатаОкончанияАктуальности.
        /// </summary>
        // *** Start programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности CustomAttributes)

        // *** End programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime ДатаОкончанияАктуальности
        {
            get
            {
                // *** Start programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности Get start)

                // *** End programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fДатаОкончанияАктуальности;
                // *** Start programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности Get end)

                // *** End programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности Set start)

                // *** End programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности Set start)
                this.fДатаОкончанияАктуальности = value;
                // *** Start programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности Set end)

                // *** End programmer edit section *** (ТочкаПроката.ДатаОкончанияАктуальности Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (ТочкаПроката.CreateTime CustomAttributes)

        // *** End programmer edit section *** (ТочкаПроката.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (ТочкаПроката.CreateTime Get start)

                // *** End programmer edit section *** (ТочкаПроката.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (ТочкаПроката.CreateTime Get end)

                // *** End programmer edit section *** (ТочкаПроката.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТочкаПроката.CreateTime Set start)

                // *** End programmer edit section *** (ТочкаПроката.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (ТочкаПроката.CreateTime Set end)

                // *** End programmer edit section *** (ТочкаПроката.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (ТочкаПроката.Creator CustomAttributes)

        // *** End programmer edit section *** (ТочкаПроката.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (ТочкаПроката.Creator Get start)

                // *** End programmer edit section *** (ТочкаПроката.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (ТочкаПроката.Creator Get end)

                // *** End programmer edit section *** (ТочкаПроката.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТочкаПроката.Creator Set start)

                // *** End programmer edit section *** (ТочкаПроката.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (ТочкаПроката.Creator Set end)

                // *** End programmer edit section *** (ТочкаПроката.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (ТочкаПроката.EditTime CustomAttributes)

        // *** End programmer edit section *** (ТочкаПроката.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (ТочкаПроката.EditTime Get start)

                // *** End programmer edit section *** (ТочкаПроката.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (ТочкаПроката.EditTime Get end)

                // *** End programmer edit section *** (ТочкаПроката.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТочкаПроката.EditTime Set start)

                // *** End programmer edit section *** (ТочкаПроката.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (ТочкаПроката.EditTime Set end)

                // *** End programmer edit section *** (ТочкаПроката.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (ТочкаПроката.Editor CustomAttributes)

        // *** End programmer edit section *** (ТочкаПроката.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (ТочкаПроката.Editor Get start)

                // *** End programmer edit section *** (ТочкаПроката.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (ТочкаПроката.Editor Get end)

                // *** End programmer edit section *** (ТочкаПроката.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТочкаПроката.Editor Set start)

                // *** End programmer edit section *** (ТочкаПроката.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (ТочкаПроката.Editor Set end)

                // *** End programmer edit section *** (ТочкаПроката.Editor Set end)
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
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(IIS.Прокат_велосипедов_2.ТочкаПроката));
                }
            }
            
            /// <summary>
            /// "ТочкаПрокатаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТочкаПрокатаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТочкаПрокатаE", typeof(IIS.Прокат_велосипедов_2.ТочкаПроката));
                }
            }
            
            /// <summary>
            /// "ТочкаПрокатаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТочкаПрокатаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТочкаПрокатаL", typeof(IIS.Прокат_велосипедов_2.ТочкаПроката));
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
