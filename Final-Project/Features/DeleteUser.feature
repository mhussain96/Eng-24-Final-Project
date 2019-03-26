Feature: DeleteUser
	In order to delete a user
	As a user
	I want to be delete an existing user 

@mytag
Scenario: Deleting Users
	Given I am on the users page
	And I want to delete a user from the system
	When I click delete
	Then the user should be deleted from the system
