Feature: YoutubeSearchFeature

Search for english speeches channel on Youtube

@EnglishSpeechesTag
Scenario: As a user I want to search for English Speeches channel
	Given I open the browser
	When I enter the youtube url
	And I accept all cookies from the begining
	Then I search for the English Speeches channel

	#The purpose of this test is to fail, so we can see the screenShot and extentReport functionality
Scenario: As a user I want to search for English Speeches channel_madeToFail
	Given I open the browser
	When I enter the youtube url
	Then I search for the English Speeches channel