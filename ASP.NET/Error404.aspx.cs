namespace ICSSoft.STORMNET.Web
{
    using System;

    using ICSSoft.STORMNET.Web.AjaxControls.Forms;

    /// <summary>
    /// Страница, отображаемая в случае ошибки 404.
    /// </summary>
    public partial class Error404 : BasePage
    {
        /// <summary>
        /// Адрес формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/Error404.aspx"; }
        }

        /// <summary>
        /// Обработчик события загрузки станицы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.StatusCode = 404;
        }
    }
}