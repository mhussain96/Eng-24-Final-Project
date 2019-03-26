using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class DeleteUserSteps
    {
        [Given(@"I want to delete a user from the system")]
        public void GivenIWantToDeleteAUserFromTheSystem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click delete")]
        public void WhenIClickDelete()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user should be deleted from the system")]
        public void ThenTheUserShouldBeDeletedFromTheSystem()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
