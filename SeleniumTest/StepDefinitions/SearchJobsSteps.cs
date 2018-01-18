using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

        [When(@"I scroll to Search field")]
        public void IScrollToSearchField()
        {
            SearchJobPage searchPage = new SearchJobPage(driver);
            Actions action = new Actions(driver);
            action.MoveToElement(searchPage.SearchField).Perform();

        }
        [When(@"I eneter ""(.*)"" in Search field")]
        public void IEneterTextInSearchField(String keyword)
        {
            SearchJobPage searchPage = new SearchJobPage(driver);
            CommonHelpers.FindWebElement(searchPage.searchField, driver).Click();
            searchPage.SearchField;

        }

        [When(@"I select ""(.*)"" location")]
        public void ISelectLocation(String location)
        {
            SearchJobPage searchPage = new SearchJobPage(driver);
            searchPage.SelectLocationDropDown().SelectCountry(location);

        }
    }
}
