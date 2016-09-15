Feature: InitialTest
	In order to test web driver
	I want to open Bicycle form
	And check if it loads correctly

Scenario: Open bicycle claim form 
	Open claim form and check that header is correct
	Given I have opened https://finclaimstest-atest.azurewebsites.net/en/bicycle
	Then search page should be visible