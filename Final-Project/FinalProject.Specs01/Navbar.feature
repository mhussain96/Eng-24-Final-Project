Feature: Navbar_Feature
As a user 
I want a navbar to be available on every page 
so that I can always navigate to any page.

@mytag
Scenario: clicking on navbar button
	Given I am on the hompage or any page
	When I click on a navbar button
	Then I should be redirected to the page associated with that button
