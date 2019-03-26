using System;
using TechTalk.SpecFlow;

namespace FinalProject.Specs01
{
    [Binding]
    public class CreateSpecialisationSteps
    {
        [Given(@"I have filled in all the required details for a particualr specialisation")]
        public void GivenIHaveFilledInAllTheRequiredDetailsForAParticualrSpecialisation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a new specialisation should be created and added to the database")]
        public void ThenANewSpecialisationShouldBeCreatedAndAddedToTheDatabase()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
