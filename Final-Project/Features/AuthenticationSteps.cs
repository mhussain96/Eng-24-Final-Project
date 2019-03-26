using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class AuthenticationSteps
    {
        [Given(@"I want access to the app")]
        public void GivenIWantAccessToTheApp()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am a user")]
        public void GivenIAmAUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I login")]
        public void WhenILogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should have access to the app")]
        public void ThenIShouldHaveAccessToTheApp()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
