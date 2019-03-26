Feature: CreateSpecialisation
	As a user
	I want to be able to create a new specialisation 
	so that i can add a new specialisation.

@mytag
Scenario: Create a new specialisation
	Given I am on the "Create Specialisations" page
	And I have filled in all the required details for a particualr specialisation
	When I press "create"
	Then a new specialisation should be created and added to the database
