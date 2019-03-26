using System;
using TechTalk.SpecFlow;

namespace FinalProject.Specs01
{
    [Binding]
    public class SpecialisationDetailsSteps
    {
        [Given(@"the Specialisation page is open")]
        public void GivenTheSpecialisationPageIsOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Details")]
        public void WhenIPressDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be redirected to a Specialisations Details page")]
        public void ThenIShouldBeRedirectedToASpecialisationsDetailsPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
