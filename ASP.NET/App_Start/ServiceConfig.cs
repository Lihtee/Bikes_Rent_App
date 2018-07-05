namespace ICSSoft.STORMNET.Web
{
    using ICSSoft.Services;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Web;
    using ICSSoft.STORMNET.Web.AjaxControls;
    using ICSSoft.STORMNET.Web.Tools;

    using Microsoft.Practices.Unity;

    using NewPlatform.Flexberry.Services;
    using NewPlatform.Flexberry.Web.Themeable;

    /// <summary>
    /// Класс конфигурации сервисов приложения.
    /// </summary>
    public static class ServiceConfig
    {
        /// <summary>
        /// Метод для конфигурации всех сервисов приложения.
        /// </summary>
        public static void ConfigureServices()
        {
            IUnityContainer container = UnityFactory.CreateContainer();

            // Сервис сессий.
            SessionService.Current = container.IsRegistered<ISessionService>()
                ? container.Resolve<ISessionService>()
                : new DefaultSessionService();

            // Сервис тем оформления.
            ThemeService.Current = container.IsRegistered<IThemeService>()
                ? container.Resolve<IThemeService>()
                : new SessionThemeService(new DefaultThemeService(), SessionService.Current);

            // Сервис аудита.
            AuditSetter.InitAuditService(BridgeToDS.GetDataService());

            // Менеджер расширенных ограничений.
            if (container.IsRegistered<IAdvLimitManager>())
            {
                AdvLimitManager.Current = container.Resolve<IAdvLimitManager>();
            }

            // Сервис настроек пользователя.
            if (container.IsRegistered<IUserSettingsService>())
            {
                UserSettingsService.Current = container.Resolve<IUserSettingsService>();
            }
            else
            {
                LogService.LogWarn("IUserSettingsService не сконфигурирован в Unity. Будет использована реализация по умолчанию.");
            }

            // Делегаты для настройки лукапов.
            BaseMasterEditorLookUp.InitLookUpSettings = FormUtils.InitLookUpSettings;
            BaseMasterEditorLookUp.ChangeLookUpSettings = FormUtils.ChangeLookUpSettings;
            MasterEditorAjaxDropDown.InitDropDownSettings = FormUtils.InitMasterEditorAjaxDropDownSettings;
            MasterEditorAjaxDropDown.ChangeDropDownSettings = FormUtils.ChangeMasterEditorAjaxDropDownSettings;
        }
    }
}