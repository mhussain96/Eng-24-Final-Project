using System;
using TechTalk.SpecFlow;

namespace FinalProject.Specs01
{
    [Binding]
    public class CreateRoleSteps
    {
        [Given(@"that the add new role page is open")]
        public void GivenThatTheAddNewRolePageIsOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered the required role details")]
        public void GivenIHaveEnteredTheRequiredRoleDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the new role should be added to the database")]
        public void ThenTheNewRoleShouldBeAddedToTheDatabase()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
