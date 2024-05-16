Feature: Data Driven Test

Search for english speeches channel on Youtube

@EnglishSpeechesTag
Scenario: Data Driven Test
	Given I open the browser
	When I enter the youtube url
	And I accept all cookies from the begining
	Then I search for 'English Speeches' channel
