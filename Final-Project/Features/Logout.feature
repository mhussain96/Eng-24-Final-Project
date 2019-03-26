Feature: Logout
	In order to logout on each page
	As a user
	I want to be able to logout out of my account

@mytag
Scenario: Logging out of my account
	Given I am logged in into my account
	When I click on logout on any page
	Then the result should be logging out of my account 
