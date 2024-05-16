Feature: Page Object Model

Search EnglishSpeeches in youtube

@EnglishSpeechesTag
Scenario: Page Object Model
	Given I enter the Youtube URL
	When I accept all cookies from the begining
	And I search for the English Speeches 
	And I navigate to the channel
	Then I verify title of the page
