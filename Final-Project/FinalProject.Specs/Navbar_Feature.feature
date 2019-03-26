Feature: Navbar_Feature
	If I selected a button on the navbar 
	I want to be redirected to that page.

@mytag
Scenario: Go to details page
	Given I am on the home page
	And I hover over the details button
	When I click on the details button
	Then I should be redirected to the details page
