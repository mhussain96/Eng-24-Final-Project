Feature: Authentication
	In order to gain access to the rest of the app
	As an admin
	I want the user to login before accessing the rest of the app

@mytag
Scenario: Authentication
	Given I want access to the app
	And I am a user 
	When I login 
	Then I should have access to the app
