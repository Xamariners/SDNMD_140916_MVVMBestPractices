using System;
using FreshMvvm;
using MVVMBestPractices.PageModels;
using SpecFlow.XForms;
using TechTalk.SpecFlow;
using SpecFlow.XFormsDependency;
using SpecFlow.XFormsExtensions;
using SpecFlow.XFormsNavigation;

namespace MVVMBestPractices.UnitTest
{
    [Binding]
    public class ToDoSteps : TestStepBase
    {
        public ToDoSteps(ScenarioContext scenarioContext)
            : base(scenarioContext)
        {
            // you need to instantiate your steps by passing the scenarioContext to the base
        }

        [Given(@"I am on the ToDoList Page")]
        public void GivenIAmOnTheToDoListPage()
        {
            Resolver.Instance.Resolve<INavigationService>().PushAsync<ToDoListPageModel>();
            Resolver.Instance.Resolve<INavigationService>().CurrentViewModelType.ShouldEqualType<ToDoListPageModel>();
        }
        
        [Then(@"I should see (.*) items")]
        public void ThenIShouldSeeItems(int amount)
        {
            //GetCurrentViewModel<ToDoListPageModel>().SetViewModel(null);
            GetCurrentViewModel<ToDoListPageModel>().ToDoItems.Count.ShouldEqual(amount);
        }
    }
}
