using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumTest.Pages;
using System;
using TechTalk.SpecFlow;


namespace SeleniumTest.StepDefinitions
{
    [Binding]
    public class HomeSteps
    {
        IWebDriver driver = Variables.driver;

        [Given(@"I am on Home page")]
        public void IAmOnHomePage()
        {
            HomePage homePage = new HomePage(driver);
            Assert.IsTrue(homePage.YourCareerText.Displayed, "Eleement not present");

        }

        [When(@"I go to Careers drop down")]
        public void IGoToCareersDropDown()
        {
            HomePage homePage = new HomePage(driver);
            Actions action = new Actions(driver);
            action.MoveToElement(homePage.CareersButton).Perform();

        }

        [When(@"I clcik Your Career")]
        public void IClickYourCareer()
        {
            HomePage homePage = new HomePage(driver);
            homePage.YourCareerButton.Click();

        }
    }
}
