using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumTest.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SeleniumTest.Variables;

namespace SeleniumTest.StepDefinitions
{
    [Binding]
    public class HomeSteps
    {
        HomePage homePage;
        
        public HomeSteps()
        {
            homePage = new HomePage(driver);
        }

        [Given(@"I am on Home page")]
        public void IAmOnHomePage()
        {
            Assert.IsTrue(homePage.GetAvanadeFeatureBlock().Displayed, "Eleement not present");
            Thread.Sleep(3000);

        }

        [When(@"I go to ""(.*)"" drop down")]
        public void IGoToCareersDropDown(string elementName)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(homePage.GetNavigationBarElement(elementName)).Perform();


        }

        [When(@"I clcik ""(.*)"" item")]
        public void IClickDropDownItem(string elementName)
        {
            homePage.GetDropDownElement(elementName).Click();

        }
    }
}
