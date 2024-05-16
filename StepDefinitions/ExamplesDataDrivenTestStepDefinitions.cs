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
    public class ExamplesDataDrivenTestStepDefinitions
    {
        private IWebDriver driver;

        public ExamplesDataDrivenTestStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"I search with (.*)")]
        public void ThenISearchWithAboutSpeckFlow(string searchKey)
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
        }

    }
}
