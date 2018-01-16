using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumTest.Pages;
using System;
using TechTalk.SpecFlow;


namespace SeleniumTest.StepDefinitions
{
    [Binding]
    public class TestSteps
    {
        IWebDriver driver = Variables.driver;

        [Given(@"I open Infision web site")]
        public void IOpenInfisionWebSite()
        {

            driver.Url = "https://www.infusion.com/";
        }

        [When(@"I go to Careers drop down")]
        public void IGoToCareersDropDown()
        {
            HomePage homePage = new HomePage(driver);
            Actions action = new Actions(driver);
            action.MoveToElement(homePage.CareersButton).Perform();

        }
    }
}
