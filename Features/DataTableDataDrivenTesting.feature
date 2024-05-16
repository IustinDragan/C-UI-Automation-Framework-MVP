Feature: DataTable Data Driven Testing

Search in the youtube

@EnglishSpeechesTag
Scenario: DataTable Data Driven Testing
	Given I open the browser
	When I enter the youtube url
	And I accept all cookies from the begining
	Then I enter search keyword in youtube
	| searchKey       |
	| about speckFlow |
	| about selenium  |
	| about c#        |
	| about testing   |