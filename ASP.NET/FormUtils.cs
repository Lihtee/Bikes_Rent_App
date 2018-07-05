namespace ICSSoft.STORMNET.Web
{
    using System;
    using ICSSoft.STORMNET.Web.AjaxControls;
    using ICSSoft.STORMNET;
    using Resources;

    /// <summary>
    /// Статические утилиты для работы с формами.
    /// </summary>
    public static class FormUtils
    {
        /// <summary>
        /// Делегат для инициализации настроек <see cref="BaseMasterEditorLookUp"/>.
        /// </summary>
        /// <param name="lookup">
        /// Экземпляр <see cref="BaseMasterEditorLookUp"/>, настройки которого требуется инициализировать.
        /// </param>
        public static void InitLookUpSettings(BaseMasterEditorLookUp lookup)
        {
        }

        /// <summary>
        /// Делегат для изменения настроек <see cref="BaseMasterEditorLookUp"/>.
        /// </summary>
        /// <param name="lookup">
        /// Экземпляр <see cref="BaseMasterEditorLookUp"/>, настройки которого требуется изменить.
        /// </param>
        public static void ChangeLookUpSettings(BaseMasterEditorLookUp lookup)
        {
            try
            {
                Type type = Type.GetType(lookup.MasterTypeName);
                string caption = Information.GetClassCaption(type);
                lookup.LookUpFormCaption = !string.IsNullOrEmpty(caption) ? caption : Resource.Select_Value;
            }
            catch (Exception)
            {
                lookup.LookUpFormCaption = Resource.Select_Value;
            }
        }

        /// <summary>
        /// Делегат для инициализации настроек <see cref="MasterEditorAjaxDropDown"/>.
        /// </summary>
        /// <param name="dropdown">
        /// Экземпляр <see cref="MasterEditorAjaxDropDown"/>, настройки которого требуется инициализировать.
        /// </param>
        public static void InitMasterEditorAjaxDropDownSettings(MasterEditorAjaxDropDown dropdown)
        {
        }

        /// <summary>
        /// Делегат для изменения настроек <see cref="MasterEditorAjaxDropDown"/>.
        /// </summary>
        /// <param name="dropdown">
        /// Экземпляр <see cref="MasterEditorAjaxDropDown"/>, настройки которого требуется изменить.
        /// </param>
        public static void ChangeMasterEditorAjaxDropDownSettings(MasterEditorAjaxDropDown dropdown)
        {
        }
    }
}