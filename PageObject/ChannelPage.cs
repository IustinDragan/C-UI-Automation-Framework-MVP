using OpenQA.Selenium;

namespace SpecFlow_mvpForUITests.PageObject
{
    public class ChannelPage
    {
        private IWebDriver driver;

        public ChannelPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string getTitle()
        {
            return driver.Title;
        }
    }
}
