using OpenQA.Selenium;

namespace SpecFlow_mvpForUITests.PageObject
{
    public class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        By searchTextBox = By.XPath("//*[@name='search_query']"); 

        public ResultPage searchText(string text)
        {
            driver.FindElement(searchTextBox).SendKeys(text);
            driver.FindElement(searchTextBox).SendKeys(Keys.Enter);

            return new ResultPage(driver);
        }
    }
}
