Feature: Authentication
	In order to gain access to the rest of the app
	As a admin
	I want the user to login before gaining access

@mytag
Scenario: Adding Authentication 
	Given I am the admin
	And I want to gain access to the rest of the app
	When I try to login 
	Then the result should allow the user gaining access to the app
	