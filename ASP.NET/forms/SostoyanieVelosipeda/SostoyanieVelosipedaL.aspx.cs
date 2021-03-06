﻿/*flexberryautogenerated="false"*/
namespace IIS.Прокат_велосипедов_2
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;
    using IIS.University.Tools;
    using System.Web.UI.WebControls;

    public partial class СостояниеВелосипедаL : BaseListForm<СостояниеВелосипеда>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        private ICSSoft.STORMNET.FunctionalLanguage.Function fncActual;
        private bool showActual;
        public СостояниеВелосипедаL() : base(СостояниеВелосипеда.Views.СостояниеВелосипедаL)
        {
            EditPage = СостояниеВелосипедаE.FormPath;
            fncActual = FunctionBuilder.BuildEquals<СостояниеВелосипеда>(x => x.Актуально, true);
            showActual = false;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/SostoyanieVelosipeda/SostoyanieVelosipedaL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
            switch (fldActual.Value)
            {
                case "hide":
                    WebObjectListView1.LimitFunction = fncActual; break;
                case "show":
                    WebObjectListView1.LimitFunction = null; break;
            }
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
            WebObjectListView1.AddImageButton
                (id: "btnHideActual", 
                 cssClass: "ics-wolv-toolbar-button ics-wolv-toolbar-button-filter ics-wolv-toolbar-button-disabled", 
                 alternateText: "Скрыть/показать неактуальные записи", 
                 clientClickHandler: "btnActualClickHandler",
                 clientClickAddParams:""
                 );
           
        }
        

    }
}
