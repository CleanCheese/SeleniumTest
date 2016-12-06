Feature: BicycleClaimsForm WhatHasHappened Section
	In order to verify that the 1st section works properly
	I want to change values for all section 1 elements
	And check if the fields are filled properly

Scenario Outline: S1 - Verify radio button
	Click radio button and verify that the correct radio button is selected and that the rest are unselected
	Given I have opened "BicycleClaimForm" page 
	When I click "Bicycle <RadioButton1>" radio button
	Then "Bicycle <RadioButton1>" radio button is selected
	And "Bicycle <RadioButton2>" radio button is unselected
	And "Bicycle has <RadioButton3>" radio button is unselected
	And "Bicycle has <RadioButton4>" radio button is unselected
	Examples: 
	| Version | RadioButton1                                         | RadioButton2                    | RadioButton3    | RadioButton4                                     |
	| 1st btn | or parts of it have been stolen                      | has been vandalized             | got broken      | been damaged in a collision with a motor vehicle |
	| 2nd btn | has been vandalized                                  | or parts of it have been stolen | got broken      | been damaged in a collision with a motor vehicle |
	| 3rd btn | has got broken                                       | or parts of it have been stolen | been vandalized | been damaged in a collision with a motor vehicle |
	| 4th btn | has been damaged in a collision with a motor vehicle | or parts of it have been stolen | been vandalized | got broken                                       |

Scenario: S1 - Fill all fields and wait 5 seconds
	Given I have opened "BicycleClaimForm" page 
	When I click "Bicycle or parts of it have been stolen" radio button
	And I enter "05.10.2016" in field When did the incident happen
	And I enter "Egypti" in field Country
	And I enter "City 1, street 1" in field Street address or place
	And I enter "Stuff happened" in field Describe in details what has happened
	Then I wait for "5" seconds

	
Scenario: S1 - Fill all fields and click Save
	Fill all fields in Section 1 and click Save button. Verify that error label is not present
	Given I have opened "BicycleClaimForm" page 
	When I click "Bicycle or parts of it have been stolen" radio button
	And I enter "05.10.2016" in field When did the incident happen
	And I enter "Egypti" in field Country
	And I enter "City 1, street 1" in field Street address or place
	And I enter "Stuff happened" in field Describe in details what has happened
	And I click Send button
	Then all information is filled in What has happened section