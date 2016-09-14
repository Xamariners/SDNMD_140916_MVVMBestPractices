using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlow.XForms;
using SpecFlow.XFormsNavigation;

namespace MVVMBestPractices.UnitTest
{
    public class ToDoAppTest : TestApp
    {
        protected override void SetViewModelMapping()
        {
            TestViewFactory.EnableCache = false;
            // RegisterView<ToDoListPage, ToDoListPageModel>();
        }
    }
}
