using System;
using TechTalk.SpecFlow;

namespace FinalProject.Specs01
{
    [Binding]
    public class RoleDetailsSteps
    {
        [Given(@"That the ""(.*)"" page is open")]
        public void GivenThatThePageIsOpen(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select  role")]
        public void GivenISelectRole()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press the ""(.*)"" button")]
        public void WhenIPressTheButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the details of the selected role")]
        public void ThenIShouldSeeTheDetailsOfTheSelectedRole()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
