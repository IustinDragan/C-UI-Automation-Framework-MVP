Feature: Examples Data Driven Test

A short summary of the feature

@EnglishSpeechesTag
Scenario Outline: Examples Data Driven Test
	Given I open the browser
	When I enter the youtube url
	And I accept all cookies from the begining
	Then I search with <searchKey>
	Examples: 
	| searchKey       |
	| about speckFlow |
	| about selenium  |
	| about c#        |
	| about testing   |
