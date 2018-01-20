using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumTest.StepDefinitions
{
    [Binding]
    class SearchJobsSteps
    {
        IWebDriver driver = Variables.driver;
        SearchJobsPage searchPage;

        public SearchJobsSteps()
        {
            searchPage = new SearchJobsPage(driver);
        }

        [Then(@"""(.*)"" of serach are shown")]
        public void VerifySearchResults(String result)
        {
            Assert.AreEqual(result, searchPage.GetsearchResultElement().Text, "Search results are incorrect");

        }
    }
}
