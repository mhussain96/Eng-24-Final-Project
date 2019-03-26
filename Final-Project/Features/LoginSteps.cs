using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I want to log into my account")]
        public void GivenIWantToLogIntoMyAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered my details")]
        public void GivenIHaveEnteredMyDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should have access to the rest of the app")]
        public void ThenIShouldHaveAccessToTheRestOfTheApp()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
