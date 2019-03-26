using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class EditUserSteps
    {
        [Given(@"I am on the users page")]
        public void GivenIAmOnTheUsersPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to update information for my user")]
        public void GivenIWantToUpdateInformationForMyUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click edit")]
        public void WhenIClickEdit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to update user information")]
        public void ThenIShouldBeAbleToUpdateUserInformation()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
