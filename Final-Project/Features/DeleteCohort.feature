Feature: DeleteCohort
	In order to delete an existing cohort
	As a user
	I want to be able to delete cohorts from the system

@mytag
Scenario: Deleting cohorts
	Given I am on the page with the cohorts 
	And I want to be able to delete existing cohorts
	When I press delete 
	Then I deleted an existing cohort from the system 
