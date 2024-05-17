using OpenQA.Selenium;

namespace SpecFlow_mvpForUITests.PageObject
{
    public class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //By channelName = By.LinkText("English Speeches");
        //By channelName = By.PartialLinkText("@EnglishSpeeches");
        //By channelName = By.LinkText("@EnglishSpeeches");
        //By channelName = By.XPath("//*[@id='main-link']");
        //By channelName = By.Id("main-link");
        By channelName = By.XPath("//div[@id='info-section']//a[@id='main-link']");
        

        public ChannelPage clickOnChannel()
        {
            driver.FindElement(channelName).Click();
            return new ChannelPage(driver);
        }
    }
}
