using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIS.Прокат_велосипедов_2;
using ICSSoft.STORMNET;
using ICSSoft.STORMNET.Business;

namespace BikesUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIАктуальноDelete()
        {
            //TODO сделать отдельный метод для второго условия
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

            //Удаление удаленного объекта
            try
            {
                mock.Актуально = false;
                res = bs.OnUpdateIАктуально(mock);
                Assert.Fail("Здесь должно выбрасываться исключение");
            }
            catch (Exception)
            {
                
            }
        }
        [TestMethod]
        public void CheckMapping()
        {
            var obj1 = DataServiceProvider.DataService;
        }
    }
}
