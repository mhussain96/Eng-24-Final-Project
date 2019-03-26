Feature: CreateCohort
	In order to create a cohort
	As a user
	I want to be able to create a new cohort

@mytag
Scenario: Create a cohort
	Given I am on the cohorts page
	And I want to create a new cohort
	When I click on create
	Then the result should be a cohort added to the system
