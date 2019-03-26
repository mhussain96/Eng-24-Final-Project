Feature: UserDetails
	In order to access user details
	As a user
	I want to be able to access an individual page for each user

@mytag
Scenario: Access User Details
	Given I am on the users page
	When I click on a particular user 
	Then I should see the users specific information
