using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
            Actions action = new Actions(driver);
            action.MoveToElement(careersPage.GetSearchField()).Perform();


        }
        [When(@"I eneter ""(.*)"" in Search field")]
        public void IEneterTextInSearchField(String keyword)
        {
            careersPage.GetSearchField().SendKeys(keyword);
           
        }

        [When(@"I select ""(.*)"" location")]
        public void ISelectLocation(String location)
        {
            careersPage.GetLocationDropDown().Click();
            careersPage.GetCountryElement(location).Click();

        }

        [When(@"I click Search button")]
        public void IClickSearch()
        {
            careersPage.GetSearchButton().Click();
          
        }
    }
}
