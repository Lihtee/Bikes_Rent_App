namespace ICSSoft.STORMNET.Web
{
    using System.Web.Http;

    /// <summary>
    /// Класс конфигурации WebAPI-маршрутов приложения.
    /// </summary>
    public class WebApiConfig
    {
        /// <summary>
        /// Метод для регистрации WebAPI-маршрутов в коллекции.
        /// </summary>
        public static void Register(HttpConfiguration config)
        {
            // Подгрузка сборки с WebAPI контроллерами в домен приложения.
            // Необходима для корректного резолвинга всех контроллеров через MapHttpAttributeRoutes.
            new NewPlatform.Flexberry.Web.Http.Controllers.AjaxDataServiceController();
            
            // Регистрируем маршруты до прикладных WebAPI-контроллеров (если они есть в каталоге Controllers).
            // Обязательно с каким-либо префиксом вроде "api/", без префикса есть вероятность,
            // что HTTP-модуль WebApiSessionModule не сможет распознать запросы к ним как запросы к WebAPI,
            // и у прикладных контроллеров не будет доступа к сессии текущего пользователя.   
            //config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{action}");
            
            config.MapHttpAttributeRoutes();
        }
    }
}