using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlow_mvpForUITests.PageObject;

namespace SpecFlow_mvpForUITests.StepDefinitions
{
    [Binding]
    public class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;
        SearchPage searchPage;
        ResultPage resultPage;
        ChannelPage channelPage;

        public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I enter the Youtube URL")]
        public void GivenIEnterTheYoutubeURL()
        {
            driver.Url = "https://www.youtube.com/";
        }

        [When(@"I search for the English Speeches")]
        public void WhenISearchForTheEnglishSpeeches()
        {
            searchPage = new SearchPage(driver);
            resultPage = searchPage.searchText("English Speeches");
        }

        [When(@"I navigate to the channel")]
        public void WhenINavigateToTheChannel()
        {
            channelPage = resultPage.clickOnChannel();
        }

        [Then(@"I verify title of the page")]
        public void ThenIVerifyTitleOfThePage()
        {
            Assert.AreEqual("English Speeches - YouTube", channelPage.getTitle());
        }
    }
}
