Feature: ListSpecialisation_Feature
	As a user,
	I want to see a list of specialisations,
	so that i can see all of the specialisations available.

@mytag
Scenario: List of Specialisations 
	Given I am on the "Specialisations" page
	When I click on specialisations
	Then a list of specialisations should become available
