using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        By channelName = By.Id("main-link");

        public ChannelPage clickOnChannel()
        {
            driver.FindElement(channelName).Click();
            return new ChannelPage(driver);
        }
    }
}
