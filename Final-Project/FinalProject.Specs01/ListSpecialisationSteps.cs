using System;
using TechTalk.SpecFlow;

namespace FinalProject.Specs01
{
    [Binding]
    public class ListSpecialisationSteps
    {
        [Given(@"I am on the ""(.*)"" page")]
        public void GivenIAmOnThePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on specialisations")]
        public void WhenIClickOnSpecialisations()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a list of specialisations should become available")]
        public void ThenAListOfSpecialisationsShouldBecomeAvailable()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
