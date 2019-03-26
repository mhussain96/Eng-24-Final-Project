using System;
using TechTalk.SpecFlow;

namespace FinalProject.Specs01
{
    [Binding]
    public class DeleteSpecialisationSteps
    {
        [Given(@"that I am on the Edit Specialisation page")]
        public void GivenThatIAmOnTheEditSpecialisationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Delete")]
        public void WhenIPressDelete()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the specialisation should be removed from the database")]
        public void ThenTheSpecialisationShouldBeRemovedFromTheDatabase()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
