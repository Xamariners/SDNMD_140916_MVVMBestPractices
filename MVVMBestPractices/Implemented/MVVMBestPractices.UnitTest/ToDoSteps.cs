using System;
using TechTalk.SpecFlow;

namespace MVVMBestPractices.UnitTest
{
    [Binding]
    public class ToDoSteps
    {
        [Given(@"I am on the ToDoList Page")]
        public void GivenIAmOnTheToDoListPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see (.*) items")]
        public void ThenIShouldSeeItems(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
