using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.PageModels;
using MVVMBestPractices.Pages;
using SpecFlow.XForms;
using SpecFlow.XFormsDependency;
using SpecFlow.XFormsNavigation;

namespace MVVMBestPractices.UnitTest
{
    public class ToDoAppTest : TestApp
    {
        protected override void SetViewModelMapping()
        {
            TestViewFactory.EnableCache = false;
            RegisterView<ToDoListPage, ToDoListPageModel>();
        }

        protected override void InitialiseContainer()
        {
            base.InitialiseContainer();
        }
    }
}