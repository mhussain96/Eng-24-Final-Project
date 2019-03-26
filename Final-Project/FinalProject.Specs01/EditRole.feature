Feature: EditRole_Feature
As a user
I want to be able to edit an existing role,
so that i can update when necessary.

@mytag
Scenario: Editing Roles
	Given that I am on the "Edit Roles" page 
	And I select a "Edit" on a role
	And I change some details
	When I press "Update"
	Then the selected role should be updated 
