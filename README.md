C#-UI-Automation-Framework-MVP

This solution is an MVP (Minimum Viable Product) in witch I started from scratch to create a simple SpecFlow Framework.
This framework is still in progress and can be updated but is also good as a start learning point.

In this framework we have some tests in witch we start the browser and navigate to youtube. Here we're searching different things in search bar.
The main purpose is to see how to create:

1. A basic SpeckFlow Test: YoutubeSearchFeature.feature
2. A basic DataDriven Test: DataDrivenTest.feature 
3. A basic DataDriven Test with ScenarioOutline and Examples: ExamplesDataDrivenTest.feature
4. A basic Data Table Test: DataTableDataDrivenTesting.feature
5. A basic Page Object page and a test to use it: PageObjectModel.feature

Also, I have been implemented the ExtentReports. Befor that I used doc .HTML report: 
To implement it I followed the steps below:
	Step 1: Open CMD(anyware): C:\Users\...> dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
	Step 2: Go to your project directory: C:\Users\...> cd C:\Users\...\...\...\[projectName]]\bin\Debug\net6.0
	Step 3: Use this command:C:\Users\...\...\...\[projectName]]\bin\Debug\net6.0> livingdoc test-assembly SpecFlow_mvpForUITests.dll -t TestExecution.json
	*To Regenerare raport(refresh): use the same command from Step3 at the same directory  


Also, I have been implemented the ScreenShot functionality too. This is the reason for what I let some test to fail. In this way we can see the logger and the
screenshots working properly.
