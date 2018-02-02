using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static SeleniumTest.Variables;

namespace SeleniumTest.StepDefinitions
{
    [Binding]
    class CareersSteps
    {

        CareersPage careersPage;

        public CareersSteps()
        {
            careersPage = new CareersPage(driver);
        }

        [When(@"I scroll to Search field")]
        public void IScrollToSearchField()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("javascript:window.scrollBy(250,350)", careersPage.GetSearchField());

        }
        [When(@"I eneter ""(.*)"" in Search field")]
        public void IEneterTextInSearchField(String keyword)
        {
            careersPage.GetSearchField().SendKeys(keyword);
        }

        [When(@"I click locations drop down")]
        public void IClickDropDown()
        {
            careersPage.GetLocationDropDown().Click();
        }

        [When(@"I scroll to ""(.*)"" location")]
        public void IScrollToLocation(String countryName)
        {
           ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", careersPage.GetCountryElement(countryName));
 
        }

        [When(@"I select ""(.*)"" location")]
        public void ISelectLocation(String countryName)
        {
            careersPage.GetCountryElement(countryName).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,-450)", careersPage.GetLocationDropDown());

        }

        [When(@"I click Search button")]
        public void IClickSearch()
        {
            careersPage.GetSearchButton().Click();
  
        }
    }
}
