Feature: InitialTest
	In order to test web driver
	I want to open Bicycle form
	And check if it loads correctly

Scenario: Open bicycle claim form and check header
	Open claim form and check that header is correct
	Given I have opened URL https://finclaimstest-atest.azurewebsites.net/en/bicycle
	Then page header is visible

Scenario: Open bicycle claim form and check 1st section header
	Open claim form and check that "what has happened" section is visible
	Given I have opened URL https://finclaimstest-atest.azurewebsites.net/en/bicycle
	Then section 1/3 header is visible
	
Scenario: Open bicycle claim form and check 2st section header
	Open claim form and check that "What item the loss concerns" section is visible
	Given I have opened URL https://finclaimstest-atest.azurewebsites.net/en/bicycle
	Then section 2/3 header is visible
	
Scenario: Open bicycle claim form and check 3rd section header
	Open claim form and check "please give the personal details" section is visible
	Given I have opened URL https://finclaimstest-atest.azurewebsites.net/en/bicycle
	Then section 3/3 header is visible
	
Scenario: Open bicycle claim form and check checkbox
	Open claim form and click I have filled in all the necessary information checkbox
	Given I have opened URL https://finclaimstest-atest.azurewebsites.net/en/bicycle
	Then checkbox is visible
	
Scenario: Open bicycle claim form and check Send button
	Open claim form and click I have filled in all the necessary information checkbox
	Given I have opened URL https://finclaimstest-atest.azurewebsites.net/en/bicycle
	Then Send button is visible
	
Scenario: Open bicycle claim form and check Abort button
	Open claim form and click I have filled in all the necessary information checkbox
	Given I have opened URL https://finclaimstest-atest.azurewebsites.net/en/bicycle
	Then Abort button is visible