using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikesUnitTest_2
{
    class TestHelper
    {
        public static ICSSoft.STORMNET.Business.IDataService DS
        {
            get
            {
                var tds = DataServiceProvider.DataService;
                var res = (IDataService)Activator.CreateInstance(tds.GetType(), new EmptySecurityManager());
                res.CustomizationString = tds.CustomizationString;
                return res;
            }
        }
    }
}
