namespace ICSSoft.STORMNET.Web
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using System.Web;
    using System.Web.Configuration;

    using ICSSoft.STORMNET.Web.AjaxControls;
    using ICSSoft.STORMNET.Web.AjaxControls.Forms;
    using ICSSoft.STORMNET.Web.Controls;
    using ICSSoft.STORMNET.Web.Tools;

    /// <summary>
    /// Форма, для отображения информации об исключениях.
    /// </summary>
    public partial class ErrorForm : BasePage
    {
        /// <summary>
        /// Адрес формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/ErrorForm.aspx"; }
        }

        /// <summary>
        /// Окна с информацией о произошедшем исключении, получаемые из контекста запроса.
        /// </summary>
        private List<WebErrorBoxRiser> _contextExceptionsList;

        /// <summary>
        /// Произошедшее исключение.
        /// </summary>
        private Exception _ex;

        /// <summary>
        /// Флаг: показывающий нужно ли отображать подробности об исключении.
        /// </summary>
        private bool _showDetails;

        /// <summary>
        /// Обработчик события загрузки станицы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _showDetails = true;
                string showDetailsConf = WebConfigurationManager.AppSettings["ShowErrorDetails"];
                if (!string.IsNullOrEmpty(showDetailsConf))
                {
                    _showDetails = showDetailsConf.ToLower() == bool.TrueString.ToLower();
                }

                _contextExceptionsList = HttpContext.Current?.Items[WebParamController.PageFilter_WebErrorBoxExceptions] as List<WebErrorBoxRiser>;

                // Извлекаем последнее возникшее исключение из кэша.
                string cacheExceptionKey = HttpContext.Current?.Request[WebParamController.STR_ErrorException];
                if (!string.IsNullOrEmpty(cacheExceptionKey))
                {
                    _ex = CacheHelper.GetFromCache(cacheExceptionKey) as Exception;
                    CacheHelper.RemoveFromCache(cacheExceptionKey);
                }

                if (_ex == null)
                {
                    MessageLabel.Text = "Сведения об ошибке отсутствуют";
                    return;
                }

                int i = 0;
                StringBuilder arr = new StringBuilder();

                bool withInnerExceptions = WithInnerExceptions();
                if (withInnerExceptions)
                {
                    SelectErr.Items.Clear();
                }
                else
                {
                    SelectErr.Visible = false;
                    ErrorNumCaption.Visible = false;
                }

                while (_ex != null)
                {
                    string exceptionNumber = i.ToString(CultureInfo.InvariantCulture);
                    string controlId = AddNewExceptionPanel(_ex, string.Concat("ep", exceptionNumber), i != 0, _showDetails);

                    SelectErr.Items.Add(exceptionNumber);
                    if (arr.Length > 0)
                    {
                        arr.Append(",");
                    }
                    arr.AppendFormat("'{0}'", controlId);

                    _ex = _ex.InnerException;
                    i++;
                }

                string httpContextExceptionsIds = GetHttpContextExceptions(i);
                if (!string.IsNullOrEmpty(httpContextExceptionsIds))
                {
                    arr.AppendFormat(",{0}", httpContextExceptionsIds);
                }

                if (arr.Length > 0 && withInnerExceptions)
                {
                    SelectErr.Attributes["onchange"] = string.Format("OnErrorChanged(this,[{0}])", arr.ToString());
                }

                string modalDialogQueryString = HttpContext.Current?.Request[WebParamController.OpenedInModalDialogParamName];
                bool openedInModalDialog = !string.IsNullOrEmpty(modalDialogQueryString) && modalDialogQueryString.ToLower().Equals("true");

                string newWindowQueryString = Request[WebParamController.OpenedInNewWindowParamName];
                bool openedInNewWindow = !string.IsNullOrEmpty(newWindowQueryString) && newWindowQueryString.ToLower().Equals("true");

                string pageErrorOccured = HttpContext.Current?.Request?.UrlReferrer?.OriginalString;
                if (!(openedInNewWindow || openedInModalDialog || string.IsNullOrEmpty(pageErrorOccured)))
                {
                    MessageLabel.Text = string.Format("<br>Чтобы вернуться назад, кликните <a href='{0}'>здесь</a>.<br><br>", pageErrorOccured);
                }
            }
            catch (Exception ex)
            {
                // Если исключение возниклона самой странице ошибки, тогда выведем сообщение о ней и StackTrace.
                MessageLabel.Text = string.Concat(ex.Message, "<br>", ex.StackTrace);
            }
        }

        /// <summary>
        /// Производит добавление панели с информацией об ошибке.
        /// </summary>
        /// <param name="exc">Исключение, которое должно отображаться на добавляемой панели.</param>
        /// <param name="controlId">Идентификатор конрола.</param>
        /// <param name="hidden">Флаг: показыает должна ли панель быть скрытой.</param>
        /// <param name="showDetails">Флаг: показыает нужно ли отображать подробности об ошибке.</param>
        /// <returns>ClientID главной панели контрола.</returns>
        private string AddNewExceptionPanel(Exception exc, string controlId, bool hidden, bool showDetails)
        {
            var ctrl = new ExceptionPanel
            {
                ID = controlId,
                ExceptionToShow = exc,
                ShowDetails = showDetails,
                EnableViewState = false,
                Hidden = hidden
            };
            Panel4Controls.Controls.Add(ctrl);

            return ctrl.MainPanelClientID;
        }

        /// <summary>
        /// Производит получение текстового представления для окон из <see cref="_contextExceptionsList"/>.
        /// </summary>
        /// <param name="num">
        /// Порядковый номер начального окна.
        /// </param>
        /// <returns>
        /// Текстовое представление для окон из <see cref="_contextExceptionsList"/>.
        /// </returns>
        private string GetHttpContextExceptions(int num = 0)
        {
            if (_contextExceptionsList == null)
            {
                return null;
            }

            int i = num;
            StringBuilder arr = new StringBuilder();

            var reversedExceptionsList = new List<WebErrorBoxRiser>(_contextExceptionsList.ToArray());
            reversedExceptionsList.Reverse();
            foreach (WebErrorBoxRiser riser in reversedExceptionsList)
            {
                Exception ex = riser.Exception;

                while (ex != null)
                {
                    string exceptionNumber = i.ToString(CultureInfo.InvariantCulture);
                    string controlId = AddNewExceptionPanel(ex, string.Concat("ep", exceptionNumber), i != 0, _showDetails);

                    SelectErr.Items.Add(exceptionNumber);
                    if (arr.Length > 0)
                    {
                        arr.Append(",");
                    }
                    arr.AppendFormat("'{0}'", controlId);

                    ex = ex.InnerException;
                    i++;
                }
            }

            return arr.ToString();
        }

        /// <summary>
        /// Осуществляет проверку того, содержит ли текущее исключение внутренние исключения.
        /// </summary>
        /// <returns>Флаг: <c>true</c>, если содержит, <c>false</c>, если не содержит.</returns>
        private bool WithInnerExceptions()
        {
            bool res = true;

            if (_ex == null)
            {
                res = false;
            }
            else
            {
                if (_ex.InnerException == null)
                {
                    res = false;
                }
            }

            // Нужно посмотреть в HttpContext.
            if (!res && _contextExceptionsList != null)
            {
                res = _contextExceptionsList.Count > 0;
            }

            return res;
        }
    }
}