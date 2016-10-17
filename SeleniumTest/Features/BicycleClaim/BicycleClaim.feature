Feature: Claims page 
	In order to test web driver
	I want to open Bicycle form
	And check if it loads correctly

Scenario: Bicycle claim - check form and section headers
	Open claim form and check that "what has happened" section is visible
	Given I have opened "BicycleClaimForm" page 
	Then page header is visible
	And section 1/3 header is visible
	And section 2/3 header is visible
	And section 3/3 header is visible

Scenario: Bicycle claim - check Checkbox and Send/Abort buttons
	Open claim form and click I have filled in all the necessary information checkbox
	Given I have opened "BicycleClaimForm" page 
	Then checkbox is visible
	And Send button is visible
	And Abort button is visible