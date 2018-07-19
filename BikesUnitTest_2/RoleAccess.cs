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

namespace BikesUnitTest_2
{
    [TestClass]
    public class RoleAccess
    {
        private IDataService ds;

        public RoleAccess()
        {
            ds = TestHelper.DS;
        }
        [TestMethod]
        public void TestMethod1()
        {
            //var roles = new List<ICSSoft.STORMNET.Security.RoleWithAccesses>();

            //RightManager.EnableAllRightChecks();
            ////InvalidOperationException: The type name or alias
            ////NewPlatform.Flexberry.Security.IAgentManager, NewPlatform.Flexberry.Security
            ////could not be resolved. Please check your configuration file and verify this type name.

            ////var smth = RightManager.GetLimitStrForRoles
            ////    (typeof(Велосипед), out roles);
            //var a = TestHelper.DS.Query<Agent>();
            //TODO прочитать subject and permission через orm
            //TODO разобраться с unity
            //TODO исследовать систему полномочий и аудита 
            

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
        /// Универсальный метод для проверки наличия полномочий на класс.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stored"></param>
        public void Check<T>(bool stored = true) where T : DataObject
        {
            string className = typeof(T).ToString();
            int permCount = ds
                .Query<Permition>()
                .Count(x => x.Subject.IsClass 
                            && x.Agent.IsRole 
                            && x.Subject.Name == className);
            if (permCount == 0)
            {
                Assert.Fail($"На класс {className} отсутствуют какие-либо полномочия");
            }
        }   
    }
}
