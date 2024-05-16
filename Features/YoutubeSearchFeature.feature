Feature: YoutubeSearchFeature

Search for english speeches channel on Youtube

@EnglishSpeechesTag
Scenario: As a user I want to search for English Speeches channel
	Given I open the browser
	When I enter the youtube url
	And I accept all cookies from the begining
	Then I search for the English Speeches channel

	#living doc .HTML report in specFlow
	#min 1h:23 min:https://www.youtube.com/watch?v=7xPcalwU76c&list=PLUeDIlio4THGmh41cgOGHMPxAJyK44WrA&index=2
	#Step 1: C:\Users\Iustin>            dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
	#Step 2: C:\Users\Iustin>            cd C:\Users\Iustin\source\repos\SpecFlow_mvpForUITests\bin\Debug\net6.0
	#Step 3: C:\Users\Iustin\source\repos\SpecFlow_mvpForUITests\bin\Debug\net6.0>       livingdoc test-assembly SpecFlow_mvpForUITests.dll -t TestExecution.json
	#Regenerare raport(refresh):      


	#The purpose of this test is to fail, so we can see the screenShot and extentReport functionality
Scenario: As a user I want to search for English Speeches channel_madeToFail
	Given I open the browser
	When I enter the youtube url
	Then I search for the English Speeches channel