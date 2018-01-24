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
using static SeleniumTest.Variables;

namespace SeleniumTest.StepDefinitions
{
    [Binding]
    class SearchJobsSteps
    {
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

        [Then(@"at least 1 result is shown")]
        public void VerifyAtLeastOneSearchResult()
        {
            Assert.IsTrue(searchPage.GetAllSearchResultElement().Displayed, "Eleement not present");

        }

        [When(@"I select ""(.*)"" offer")]
        public void ISelectOffer(String offerName)
        {
            searchPage.GetOfferElement(offerName).Click();

        }
    }
}
