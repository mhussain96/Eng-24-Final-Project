Feature: SpecialisationDetails
	As a user
	I want to be able to access an individual page for each specialisation 
	so that I can see the specialisation information 

@mytag
Scenario: View Specialisation Details 
	Given the Specialisation page is open 
	When I press Details
	Then I should be redirected to a Specialisations Details page
