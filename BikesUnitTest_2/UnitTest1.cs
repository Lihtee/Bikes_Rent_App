using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using IIS.Прокат_велосипедов_2;
using System.Linq;

namespace BikesUnitTest_2
{
    [TestClass]
    public class DataModel
    {
        /// <summary>
        /// Проверка соответствия структуры БД структуре классов
        /// </summary>
        [TestMethod]
        public void CheckСостояниеВелосипеда()
        {

            var ds = DataServiceProvider.DataService;
            try
            {
                var состояниеВелосипеда =
                    ds.Query<СостояниеВелосипеда>("СостояниеВелосипедаL")
                    .FirstOrDefault();
                //NewPlatform.Flexberry.SecurityManager
            }
            catch (Exception e)
            {
                Assert.Fail($"Несоответствие в классе СостояниеВелосипеда. Исклюдчение: {e.Message}");
            }
        }

    }
}
