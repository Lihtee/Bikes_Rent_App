using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using IIS.Прокат_велосипедов_2;
using System.Linq;
using ICSSoft.STORMNET.Security;

namespace BikesUnitTest_2
{
        /// <summary>
        /// Проверка соответствия структуры БД структуре классов
        /// </summary>
    [TestClass]
    public class DataModel
    {
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
                var obj = TestHelper.DS.Query<T>().FirstOrDefault();
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
