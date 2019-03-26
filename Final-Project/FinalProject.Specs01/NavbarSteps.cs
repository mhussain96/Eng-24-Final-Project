using System;
using TechTalk.SpecFlow;

namespace FinalProject.Specs01
{
    [Binding]
    public class NavbarSteps
    {
        [Given(@"I am on the hompage or any page")]
        public void GivenIAmOnTheHompageOrAnyPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on a navbar button")]
        public void WhenIClickOnANavbarButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be redirected to the page associated with that button")]
        public void ThenIShouldBeRedirectedToThePageAssociatedWithThatButton()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
