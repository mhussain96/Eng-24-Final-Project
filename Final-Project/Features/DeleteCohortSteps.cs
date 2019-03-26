using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class DeleteCohortSteps
    {
        [Given(@"I am on the page with the cohorts")]
        public void GivenIAmOnThePageWithTheCohorts()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to be able to delete existing cohorts")]
        public void GivenIWantToBeAbleToDeleteExistingCohorts()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press delete")]
        public void WhenIPressDelete()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I deleted an existing cohort from the system")]
        public void ThenIDeletedAnExistingCohortFromTheSystem()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
