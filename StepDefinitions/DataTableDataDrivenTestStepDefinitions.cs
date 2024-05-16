using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow_mvpForUITests.StepDefinitions
{
    [Binding]
    public class DataTableDataDrivenTestStepDefinitions
    {
        private IWebDriver driver;

        public DataTableDataDrivenTestStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"I enter search keyword in youtube")]
        public void ThenIEnterSearchKeywordInYoutube(Table table)
        {
           var searchCriteria = table.CreateSet<SearchKeyTestData>();

            foreach(var key in searchCriteria)
            {
                driver.FindElement(By.XPath("//*[@name='search_query']")).Clear();
                driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(key.searchKey);
                driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
                Thread.Sleep(1000);
            }
        }

    }

    public class SearchKeyTestData
    {
        public string searchKey { get; set; }
    }
}
