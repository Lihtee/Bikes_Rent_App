using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using IIS.Прокат_велосипедов_2;
using System.Linq;
using System.Reflection;
using System.Text;
using ICSSoft.STORMNET.Security;
using ICSSoft.STORMNET;

namespace BikesUnitTest_2
{
        /// <summary>
        /// Проверка соответствия структуры БД структуре классов
        /// </summary>
    [TestClass]
    public class DataModel
    {
        /// <summary>
        /// Универсальный метод для проверки соответствия классов таблицам БД.
        /// </summary>
        [TestMethod]
        public void CheckFromReflection()
        {
            //Создаем велосипед, чтобы загрузилась сборка.
            var vel = new Велосипед();
            var ass = AppDomain.CurrentDomain
                .GetAssemblies()
                .FirstOrDefault(x => x.FullName.Contains("Прокат_велосипедов_2.Objects"));
            if (ass == null)
            {
                Assert.Fail("Не загружается сборка");
            }

            Assembly a = Assembly.Load(ass.FullName);
            var types = a.GetTypes().Where(x => x.BaseType == typeof(DataObject)).ToList();
            var ds = TestHelper.DS;

            var sb = new StringBuilder();
            foreach (var t in types)
            {
                object obj = Activator.CreateInstance(t);
                View v = new View();
                v.DefineClassType = t;
                var lcs = LoadingCustomizationStruct.GetSimpleStruct(t, v);
                var notStoredAttribute = t.GetCustomAttribute(typeof(NotStoredAttribute));
                try
                {
                    var objects = ds.LoadObjects(lcs);
                    if ( notStoredAttribute!= null)
                    {
                        //Успешно загрузли нехранимые объекты.
                        sb.Append($"Класс {t} не должен храниться в БД {Environment.NewLine}");
                    }
                    else
                    {
                        //Хранимые объекты загружены нормально.
                    }
                }
                catch (Exception)
                {
                    if (notStoredAttribute == null)
                    {
                        //Не загрузились хранимые объекты
                        sb.Append($"Несоответствие в классе {t} {Environment.NewLine}");
                    }
                    else
                    {
                        //Нехранимые объекты не загрузились.
                    }

                }
            }

            if (sb.Length != 0)
            {
                Assert.Fail(sb.ToString());
            }
        }
        
    }
}
