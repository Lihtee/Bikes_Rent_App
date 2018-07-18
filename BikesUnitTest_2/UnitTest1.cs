using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using IIS.Прокат_велосипедов_2;
using System.Linq;
using ICSSoft.STORMNET.Security;

namespace BikesUnitTest_2
{
    [TestClass]
    public class DataModel
    {
        /// <summary>
        /// Проверка соответствия структуры БД структуре классов
        /// </summary>

        private IDataService ds;

        public DataModel()
        {
            //Решение с форума: на основе стандартного ds создать аналогичный, но с пустым sm.
            var tds = DataServiceProvider.DataService;
            ds = (IDataService)Activator.CreateInstance(tds.GetType(), new EmptySecurityManager());
            ds.CustomizationString = tds.CustomizationString;
        }
        [TestMethod]
        public void CheckСостояниеВелосипеда()
        {
            Check<СостояниеВелосипеда>();
        }

        [TestMethod]
        public void CheckВелосипед()
        {
            Check<Велосипед>();
        }

        [TestMethod]
        public void CheckВелосипедВПеревозке()
        {
            Check<ВелосипедВПеревозке>();
        }

        [TestMethod]
        public void CheckВыдачаВелосипеда()
        {
            Check<ВыдачаВелосипеда>(false);
        }

        [TestMethod]
        public void CheckИсторияРасценок()
        {
            Check<ИсторияРасценок>();
        }


        [TestMethod]
        public void CheckИсторияСостояний()
        {
            Check<ИсторияСостояний>();
        }

        [TestMethod]
        public void CheckКлиент()
        {
            Check<Клиент>();
        }


        [TestMethod]
        public void CheckПеревозкаВелосипеда()
        {
            Check<ПеревозкаВелосипеда>();
        }


        [TestMethod]
        public void CheckПриемВелосипеда()
        {
            Check<ПриемВелосипеда>(false);
        }


        [TestMethod]
        public void CheckПрокатВелосипеда()
        {
            Check<ПрокатВелосипеда>();
        }


        [TestMethod]
        public void CheckСотрудник()
        {
            Check<Сотрудник>();
        }

        [TestMethod]
        public void CheckТипВелосипеда()
        {
            Check<ТипВелосипеда>();
        }
        [TestMethod]
        public void CheckТочкаПроката()
        {
            Check<ТочкаПроката>();
        }

        /// <summary>
        /// Унивесальный метод для проверки соответствия класса таблице БД.
        /// </summary>
        /// <typeparam name="T">Тип, наследуемый от DataObject</typeparam>
        /// <param name="stored">Хранимый ли класс, по умолчанию false</param>
        public void Check<T>(bool stored=true) where T : ICSSoft.STORMNET.DataObject
        {
            try
            {
                var obj = ds.Query<T>().FirstOrDefault();
                if (!stored)
                {
                    Assert.Fail($"Несответствие в классе {typeof(T)}. Данный класс не должен быть хранимым.");
                }
            }
            
            catch (Exception e)
            {
                if (stored)
                {
                    Assert.Fail($"Несответствие в классе {typeof(T)}. Исключение: {e.Message}");
                }
            }
        }
        
    }
}
