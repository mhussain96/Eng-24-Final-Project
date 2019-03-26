using System;
using TechTalk.SpecFlow;

namespace FinalProject.Specs01
{
    [Binding]
    public class DeleteRoleSteps
    {
        [Given(@"I want to delete a particular role")]
        public void GivenIWantToDeleteAParticularRole()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the ""(.*)"" page is open")]
        public void GivenThePageIsOpen(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press delete")]
        public void WhenIPressDelete()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the role should be removed from the system")]
        public void ThenTheRoleShouldBeRemovedFromTheSystem()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
