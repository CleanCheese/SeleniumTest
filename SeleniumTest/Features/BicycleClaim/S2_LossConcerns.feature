Feature: BicycleClaimsForm WhatItemTheLossConcerns Section
	In order to verify that the 2st section works properly
	I want to change values for all section 2 elements
	And check if the fields are filled properly

Scenario: S2 - Fill costs and click Save
	Given I have opened "BicycleClaimForm" page 
	When I enter "Other" in field Bicycle
	And I enter "2016" in field Year of purchase
	And I enter "Brand X" in field Brand and model
	And I enter "1000" in field The price of an new item
	And I enter "300" in field Repair costs
	And I enter "Repair shop" in field Repair estimation is based on
	And I wait for "5" seconds
	And I click "Save" button
	Then I wait for "5" seconds