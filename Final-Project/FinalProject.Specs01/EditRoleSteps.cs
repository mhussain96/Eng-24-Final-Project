using System;
using TechTalk.SpecFlow;

namespace FinalProject.Specs01
{
    [Binding]
    public class EditRoleSteps
    {
        [Given(@"that I am on the ""(.*)"" page")]
        public void GivenThatIAmOnThePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select a ""(.*)"" on a role")]
        public void GivenISelectAOnARole(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I change some details")]
        public void GivenIChangeSomeDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press ""(.*)""")]
        public void WhenIPress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the selected role should be updated")]
        public void ThenTheSelectedRoleShouldBeUpdated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
