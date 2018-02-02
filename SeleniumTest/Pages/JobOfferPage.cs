using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumTest.CommonHelpers;

namespace SeleniumTest.Pages
{
    class JobOfferPage:BasePage
    {
        public string offerTitle = "//h1[@class='job-title ng-binding']";

        public JobOfferPage(IWebDriver driver)
            :base(driver)
        {
        }
        public IWebElement GetOfferTitle()
        {
            var offerTitleElement = FindWebElement(offerTitle, 30);
            return offerTitleElement;
        }

        private string GetQualificationItemXPath(string qalificationName)
        {
            return "//ul/li[text()='" + qalificationName + "']";
        }

        public IWebElement GetQualificationElement(string elementName)
        {
            var elementXPath = GetQualificationItemXPath(elementName);
            var qalificationElement = FindWebElement(elementXPath, 30);
            return qalificationElement;
        }

    }
}
