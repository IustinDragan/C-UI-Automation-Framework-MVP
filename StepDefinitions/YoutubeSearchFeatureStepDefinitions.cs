using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_mvpForUITests.StepDefinitions
{
    [Binding]
    public class YoutubeSearchFeatureStepDefinitions
    {
        private IWebDriver driver;

        public YoutubeSearchFeatureStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I open the browser")]
        public void GivenIOpenTheBrowser()
        {}

        [When(@"I enter the youtube url")]
        public void WhenIEnterTheYoutubeUrl()
        {
            driver.Url = "https://www.youtube.com/";
        }

        [When(@"I accept all cookies from the begining")]
        public void WhenIAcceptAllCookiesFromTheBegining()
        {
            driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div[6]/div[1]/ytd-button-renderer[2]/yt-button-shape/button/yt-touch-feedback-shape/div/div[2]"))
                .Click();

            Thread.Sleep(4000);
        }

        [Then(@"I search for the English Speeches channel")]
        public void ThenISearchForTheEnglishSpeechesChannel()
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("English speeches");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
        }
    }
}
