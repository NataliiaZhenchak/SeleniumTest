using NUnit.Framework;
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
    class JobOfferSteps
    {
        JobOfferPage jobOfferPage;

        public JobOfferSteps()
        {
            jobOfferPage = new JobOfferPage(driver);
        }

        [Then(@"""(.*)"" offer is shown")]
        public void VerifySearchResults(String result)
        {
            Assert.AreEqual(result, jobOfferPage.GetOfferTitle().Text, "Results are incorrect");

        }
        [Then(@"I can see ""(.*)"" qualification")]
        public void IScrollToQualifications(String qualificationType)
        {
            //Actions action = new Actions(driver);
            //action.MoveToElement(jobOfferPage.GetQualificationElement(qualificationType)).Perform();
            ((IJavaScriptExecutor)driver).ExecuteScript("javascript:window.scrollBy(250,350)", jobOfferPage.GetQualificationElement(qualificationType));
            Thread.Sleep(1000);
            Assert.AreEqual(qualificationType, jobOfferPage.GetQualificationElement(qualificationType).Text, "Results are incorrect");

        }
    }
}
