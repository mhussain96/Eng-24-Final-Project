Feature: EditUser
	In order to edit a user
	As a user
	I want to be able to update user information

@mytag
Scenario: Edit users
	Given I am on the users page
	And I want to update information for my user
	When I click edit
	Then I should be able to update user information
