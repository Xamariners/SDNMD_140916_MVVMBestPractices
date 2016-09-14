using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlow.XForms;
using TechTalk.SpecFlow;

namespace MVVMBestPractices.UnitTest
{
    [Binding]
    public class SetupHook : TestSetupHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            // bootstrap test app with your test app and your starting viewmodel
            //new TestAppBootstrap().RunApplication<ToDoAppTest, ToDoListPageModel>();
        }
    }
}
