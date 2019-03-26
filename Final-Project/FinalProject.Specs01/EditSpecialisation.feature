Feature: EditSpecialisation
	As a user
	I want to be able to edit an existing specialisation,
	so that I can update when necessary.

@mytag
Scenario: Add two numbers
	Given that I am on the "Specialisation" page 
	And I select a "Edit" on a specialisation
	And I change some details
	When I press "Update"
	Then the selected specialisation should be updated 
