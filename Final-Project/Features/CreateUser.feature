Feature: CreateUser
	In order to create a user
	As a user
	I want to be able to create a new user

@mytag
Scenario: Create users
	Given I am on the add new user page
	And I want to create a new user
	When I click create 
	Then I should have added a new user in the system
