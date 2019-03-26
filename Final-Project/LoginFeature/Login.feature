Feature: Login
	In order to access the rest of the app 
	As a user
	I want to able to login into my account

@mytag
Scenario: Login to my account
	Given I want to log into my account
	And I have entered my details
	When I press login 
	Then I should have access to the rest of the app
