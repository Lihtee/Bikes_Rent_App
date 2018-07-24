using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICSSoft.STORMNET.Business;
using System.Collections.Generic;
using IIS.Прокат_велосипедов_2;
using ICSSoft.STORMNET;
using ICSSoft.Services;
using ICSSoft.STORMNET.Business.LINQProvider;
using ICSSoft.STORMNET.Security;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BikesUnitTest_2
{
    [TestClass]
    public class RoleAccess
    {
        /// <summary>
        /// Универсальный метод для проверки наличия у ролей полномочия на хранимые классы.
        /// </summary>
        [TestMethod]
        public void CheckAcessExistance()
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
                //Смотрим только хранимые объекты.
                if (notStoredAttribute == null)
                {
                    string className = t.ToString();
                    int permCount = ds
                        .Query<Permition>()
                        .Count(x => x.Subject.IsClass
                                    && x.Agent.IsRole
                                    && x.Subject.Name == className);
                    if (permCount == 0)
                    {
                        sb.Append($"На класс {className} отсутствуют какие-либо полномочия");
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
