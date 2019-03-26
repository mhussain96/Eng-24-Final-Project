using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class CohortDetailsSteps
    {
        [Given(@"I have entered the cohorts page")]
        public void GivenIHaveEnteredTheCohortsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the button")]
        public void WhenIClickOnTheButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result is to see list of all cohorts available")]
        public void ThenTheResultIsToSeeListOfAllCohortsAvailable()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
