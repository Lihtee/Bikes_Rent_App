﻿/*flexberryautogenerated="false"*/
//TODO Удалить лишнюю кнопку
namespace IIS.Прокат_велосипедов_2
{
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Web.Controls;
    using ICSSoft.STORMNET.Web.AjaxControls;
    using ICSSoft.STORMNET.Business;
    using System;

    public partial class ПриемВелосипедаE : BaseEditForm<ПриемВелосипеда>
    {
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public ПриемВелосипедаE()
            : base(ПриемВелосипеда.Views.ПриемВелосипедаE)
        {
        }

        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/PriemVelosipeda/PriemVelosipedaE.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
            bool hasRights = RightManager.AccessCheck("Выдать велосипед");
            if (!hasRights)
            {
                throw new Exception("У вас нет прав для выполнения этой операции");
            }
        }

        /// <summary>
        /// Здесь лучше всего писать бизнес-логику, оперируя только объектом данных.
        /// </summary>
        protected override void PreApplyToControls()
        {
            ctrlДатаПриема.ReadOnly = true;
            if (Request.QueryString["success"] == "true")
            {
                Response.Redirect(ПриемВелосипедаE.FormPath);
            }
        }

        /// <summary>
        /// Здесь лучше всего изменять свойства контролов на странице,
        /// которые не обрабатываются WebBinder.
        /// </summary>
        protected override void PostApplyToControls()
        {
            Page.Validate();
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }

        /// <summary>
        /// Валидация объекта для сохранения.
        /// </summary>
        /// <returns>true - продолжать сохранение, иначе - прекратить.</returns>
        protected override bool PreSaveObject()
        {
            return base.PreSaveObject();
        }

        /// <summary>
        /// Нетривиальная логика сохранения объекта.
        /// </summary>
        /// <returns>Объект данных, который сохранился.</returns>
        protected override DataObject SaveObject()
        {
            //TODO вывести уведомление о том, что сохранение прошло успешно

            try
            {
                var ds = DataServiceProvider.DataService;
                var storedObj = DataObject.ПрокатВелосипеда;
                storedObj.ТочкаСдачи = DataObject.ТочкаСдачи;
                storedObj.ФактическаяДатаСдачи
                    = (ICSSoft.STORMNET.UserDataTypes.NullableDateTime)DataObject.ДатаПриема;
                storedObj.ФактическаяСтоимость = DataObject.ФактическаяСтоимость;
                ds.UpdateObject(storedObj);

                var cycle = storedObj.Велосипед;
                ds.LoadObject(cycle);

                string uLogin = ICSSoft.Services.CurrentUserService.CurrentUser.Login;
                LogService.LogInfo($"Пользователь {uLogin} совершил прием велосипеда {cycle.Номер} ");

                Response.Redirect(ПриемВелосипедаE.FormPath +  "?success=true");
                return DataObject;
            }
            catch (System.Exception e )
            {
                throw e;
            }
        }
        protected void btnSaveClick(object sender, System.EventArgs e)
        {
           SaveObject();
        }
    }
}