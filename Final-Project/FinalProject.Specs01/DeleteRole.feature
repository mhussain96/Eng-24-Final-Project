Feature: DeleteRole
As a user 
I want to be able to delete an existing role 
so that I can remove roles from the system when necesarry

@mytag
Scenario: Deleting an existing role
	Given I want to delete a particular role
	And the "Edit Role" page is open
	When I press delete 
	Then the role should be removed from the system
