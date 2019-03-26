using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class UserDetailsSteps
    {
        [When(@"I click on a particular user")]
        public void WhenIClickOnAParticularUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the users specific information")]
        public void ThenIShouldSeeTheUsersSpecificInformation()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
