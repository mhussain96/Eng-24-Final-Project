Feature: CreateRole
	As a user
	I want to be able to be able to create a new role,
	so that i can add new roles to the system

@mytag
Scenario: Adding new roles
	Given that the add new role page is open
	And I have entered the required role details 
	When I press add
	Then the new role should be added to the database
