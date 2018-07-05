namespace ICSSoft.STORMNET.Web
{
    using System;
    using System.Web;
    using System.Web.Configuration;
    using System.Web.Http;
    using System.Web.Routing;
    using System.Web.SessionState;

    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Web;
    using ICSSoft.STORMNET.Web.Tools;
    using ICSSoft.STORMNET.Web.Tools.Monads;

    using global::Resources;

    /// <summary>
    /// Класс ASP.NET приложения.
    /// </summary>
    public class Global : HttpApplication
    {
        /// <summary>
        /// Значение параметра конфигурации, отвечающего за отключение кэширования.
        /// </summary>
        private bool? _noCache;

        /// <summary>
        /// Обработчик события начала запроса к приложению.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (_noCache == null)
            {
                string noCache = WebConfigurationManager.AppSettings["NoCache"];
                _noCache = !string.IsNullOrEmpty(noCache) && noCache.ToLower() == "true";
            }

            if (_noCache.Value)
            {
                CacheHelper.ClearCache();
            }
        }

        /// <summary>
        /// Обработчик события запуска приложения.
        /// Все зависимости (сервисы) должны разрешаться именно тут.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ServiceConfig.ConfigureServices();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        /// <summary>
        /// Обработчик события завершения приложения.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        protected void Application_End(object sender, EventArgs e)
        {
            // Для того, чтобы все объекты, которые сейчас в кэше, но должны обновиться в базе обновились.
            CacheHelper.RemoveFromCache(string.Empty);
        }

        /// <summary>
        /// Обработчик события возникновения необработанного исключения.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        protected void Application_Error(object sender, EventArgs e)
        {
            string noHideError = WebConfigurationManager.AppSettings["NoHideError"];

            if (string.IsNullOrEmpty(noHideError) || noHideError.ToLower() != "true")
            {
                try
                {
                    // Ловим последнее возникшее исключение.
                    Exception lastError = Server.GetLastError();

                    // Обнуление ошибки на сервере.
                    Server.ClearError();

                    if (lastError != null)
                    {
                        string strErr = "App_error";
                        string userName = HttpContext.Current?.User?.Identity?.Name;
                        if (!string.IsNullOrEmpty(userName))
                        {
                            strErr = string.Concat(strErr, " User:", userName);
                        }

                        LogService.Log.Error(strErr, lastError);

                        // Если в списке параметров присутствует WebParamController.STR_ErrorException,
                        // значит перенаправление на страницу отображения ошибки само привело к ошибке,
                        // чтобы избежать зацикливания, кидаем исключение, которое будет обработано как критическая ошибка.
                        string cacheUnhandledExceptionKey = HttpContext.Current?.Request?.QueryString?.Get(WebParamController.STR_ErrorException);
                        if (!string.IsNullOrEmpty(cacheUnhandledExceptionKey))
                        {
                            // Вычищаем из кэша предыдущее необработанное исключение.
                            CacheHelper.RemoveFromCache(cacheUnhandledExceptionKey);

                            throw lastError;
                        }

                        // Перенаправление на страницу отображения ошибки.
                        // Для корректного подключения скриптов к страницам, нужно чтобы после перенаправления запрос прошел бы полный жизненный цикл,
                        // это гарантируется методами Server.TransferRequest и Response.Redirect.
                        // Методы Server.Transfer, Server.Execute перенаправят на указанную страницу в контексте текущего запроса, и скрипты не подключатся.
                        if ((lastError as HttpException).Return(x => x.GetHttpCode() == 404, false))
                        {
                            // На странице Error404.aspx скрипты не требуются, поэтому можем использовать Server.Transfer.
                            Server.Transfer($"{Error404.FormPath}");
                        }
                        else
                        {
                            // Запоминаем последнее возникшее исключение в кэше.
                            // Не используем сессию. т.к. при Redirect-е данные из нее почему-то иногда теряются.
                            string cacheExceptionKey = Guid.NewGuid().ToString("D");
                            CacheHelper.SetToCache(cacheExceptionKey, lastError);

                            // Добавляем к параметрам URL ключ, по которому сохранили исключение.
                            string queryString = HttpContext.Current?.Request?.QueryString?.ToString();
                            queryString = string.IsNullOrEmpty(queryString)
                                ? $"{WebParamController.STR_ErrorException}={cacheExceptionKey}"
                                : $"{queryString}&{WebParamController.STR_ErrorException}={cacheExceptionKey}";

                            // На странице ErrorForm.aspx требуются скрипты для нормальной работы контрола ExceptionPanel,
                            // в mono не реализован Server.TransferRequest поэтому используем Response.Redirect.
                            Response.Redirect($"{ErrorForm.FormPath}?{queryString}", true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Если мы всё же приходим сюда - значит обработка исключения сама сгенерировала исключение.
                    // Прерываем обработку, чтобы не создать бесконечный цикл.
                    Response.Write(Server.HtmlEncode(string.Format(Resource.Crirical_Error, ex)));
                }
            }
        }
    }
}