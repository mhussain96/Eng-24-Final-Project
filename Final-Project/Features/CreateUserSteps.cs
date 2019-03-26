using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class CreateUserSteps
    {
        [Given(@"I am on the add new user page")]
        public void GivenIAmOnTheAddNewUserPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to create a new user")]
        public void GivenIWantToCreateANewUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click create")]
        public void WhenIClickCreate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should have added a new user in the system")]
        public void ThenIShouldHaveAddedANewUserInTheSystem()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
