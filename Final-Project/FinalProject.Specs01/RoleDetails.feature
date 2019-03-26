Feature: RoleDetails
	As a user 
	I want to be able to access an individual page for each role
	so that i can see the information for each role 

@mytag
Scenario: Access Role Details 
	Given That the "Roles" page is open 
	And I select  role
	When I press the "Role Details" button
	Then I should see the details of the selected role
