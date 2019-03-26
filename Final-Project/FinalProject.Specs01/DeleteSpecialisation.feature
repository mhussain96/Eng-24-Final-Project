Feature: DeleteSpecialisation
	As a user 
	I want to be able to delete an existing specialisation 
	so that Can remove a specialisation from the system when necessary

@mytag
Scenario: Deleting specialisation
	Given that I am on the Edit Specialisation page 
	When I press Delete
	Then the specialisation should be removed from the database
