using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class EditCohortSteps
    {
        [Given(@"I am on the cohort page")]
        public void GivenIAmOnTheCohortPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to edit an existing cohort")]
        public void GivenIWantToEditAnExistingCohort()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the edit button")]
        public void WhenIClickOnTheEditButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should have updated information in the system")]
        public void ThenIShouldHaveUpdatedInformationInTheSystem()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
