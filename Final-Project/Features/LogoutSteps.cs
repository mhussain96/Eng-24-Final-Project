using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class LogoutSteps
    {
        [Given(@"I am logged in into my account")]
        public void GivenIAmLoggedInIntoMyAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on logout on any page")]
        public void WhenIClickOnLogoutOnAnyPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be logging out of my account")]
        public void ThenTheResultShouldBeLoggingOutOfMyAccount()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
