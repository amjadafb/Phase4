Feature: FirstFeature
	Open checkout page and search for Total: 0

@mytag
Scenario: Open checkout page
	Given the Pizza Website home page 
	When Click checkout Link 
	Then the result will be Total: 0