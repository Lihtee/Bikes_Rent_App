﻿/*flexberryautogenerated="true"*/
namespace IIS.Прокат_велосипедов_2
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ТипВелосипедаL : BaseListForm<ТипВелосипеда>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ТипВелосипедаL() : base(ТипВелосипеда.Views.ТипВелосипедаL)
        {
            EditPage = ТипВелосипедаE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/TipVelosipeda/TipVelosipedaL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}