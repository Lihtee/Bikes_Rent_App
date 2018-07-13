using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIS.Прокат_велосипедов_2;
using ICSSoft.STORMNET;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using System.Linq;

namespace BikesUnitTests
{
    /// <summary>
    /// Проверки удалеия записей справочников.
    /// </summary>
    [TestClass]
    public class IАктуальноDelete
    {
        /// <summary>
        /// Проверка обычного удаления записи в спровочнике.
        /// </summary>
        [TestMethod]
        public void Normal()
        {
            var bs = new IАктуальноBS();
            var mock = new СостояниеВелосипеда
            {
                Актуально = true,
                ДатаНачалаАктуальности = DateTime.Parse("10.10.2010"),
                ДатаОкончанияАктуальности = null,
                Название = "Тестовый тип"
            };
            mock.SetLoadedProperties(new string[] { "Актуально" });
            mock.SetStatus(ObjectStatus.Deleted);
            //Удаление обычного объекта
            var res = bs.OnUpdateIАктуально(mock);
            Assert.IsFalse(((IАктуально)res[0]).Актуально);
        }
        /// <summary>
        /// Проверка удаления уже удаленной записи в справочнике.
        /// </summary>
        [TestMethod]
        public void AlreadyDeleted()
        {
         
            var bs = new IАктуальноBS();
            var mock = new СостояниеВелосипеда
            {
                Актуально = false,
                ДатаНачалаАктуальности = DateTime.Parse("10.10.2010"),
                ДатаОкончанияАктуальности = null,
                Название = "Тестовый тип"
            };
            mock.SetLoadedProperties(new string[] { "Актуально" });
            mock.SetStatus(ObjectStatus.Deleted);

            //Удаление удаленного объекта
            try
            {
                mock.Актуально = false;
                 var res = bs.OnUpdateIАктуально(mock);
                Assert.Fail("Здесь должно выбрасываться исключение");
            }
            catch (Exception)
            {

            }
        }
    }

   
}
