using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class CreateCohortSteps
    {
        [Given(@"I am on the cohorts page")]
        public void GivenIAmOnTheCohortsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to create a new cohort")]
        public void GivenIWantToCreateANewCohort()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on create")]
        public void WhenIClickOnCreate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be a cohort added to the system")]
        public void ThenTheResultShouldBeACohortAddedToTheSystem()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
