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
       

        [Given(@"I open Infision web site")]
        public void IOpenInfisionWebSite()
        {

            Variables driver = new Variables;
            driver.Url = "https://www.infusion.com/";
        }

        [When(@"I go to Careers drop down")]
        public void IGoToCareersDropDown()
        {

            Variables driver = new Variables();
            HomePage homePage = new HomePage(driver);
            Actions action = new Actions(driver);
            action.MoveToElement(homePage.CareersButton).Perform();

        }
    }
}
