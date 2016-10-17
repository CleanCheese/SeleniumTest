Feature: BicycleClaimsForm WhatHasHappened Section
	In order to verify that the 1st section works properly
	I want to change values for all section 1 elements
	And check if the fields are filled properly

Scenario Outline: S1 - Verify radio button
	Click radio button and verify that the correct radio button is selected and that the rest are unselected
	Given I have opened "BicycleClaimForm" page 
	When I click "<RadioButton1>" radio button
	Then "<RadioButton1>" radio button is selected
	And "<RadioButton2>" radio button is unselected
	And "<RadioButton3>" radio button is unselected
	And "<RadioButton4>" radio button is unselected
	Examples: 
	| Version | RadioButton1                                                 | RadioButton2                            | RadioButton3                | RadioButton4                                                 |
	| 1st btn | Bicycle or parts of it have been stolen                      | Bicycle has been vandalized             | Bicycle has got broken      | Bicycle has been damaged in a collision with a motor vehicle |
	| 2nd btn | Bicycle has been vandalized                                  | Bicycle or parts of it have been stolen | Bicycle has got broken      | Bicycle has been damaged in a collision with a motor vehicle |
	| 3rd btn | Bicycle has got broken                                       | Bicycle or parts of it have been stolen | Bicycle has been vandalized | Bicycle has been damaged in a collision with a motor vehicle |
	| 4th btn | Bicycle has been damaged in a collision with a motor vehicle | Bicycle or parts of it have been stolen | Bicycle has been vandalized | Bicycle has got broken                                       |

Scenario: S1 - Fill all fields 
	Given I have opened "BicycleClaimForm" page 
	When I click "Bicycle or parts of it have been stolen" radio button
	And I enter "05.10.2016" in field When did the incident happen
	And I enter "Egypti" in field Country
	And I enter "City 1, street 1" in field Street address or place
	And I enter "Stuff happened" in field Describe in details what has happened
	Then I wait for "5" seconds